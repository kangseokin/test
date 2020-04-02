using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace 제품분석도우미
{
    class 성분및기계적성질비교
    {
        private string _HeatNO;

        private string _강종;
        private string _호칭;

        private string _검사구분압연NO;


        private string _화학성분_C;
        private string _화학성분_Si;
        private string _화학성분_Mn;
        private string _화학성분_P;
        private string _화학성분_S;
        private string _화학성분_Cu;
        private string _화학성분_Cr;
        private string _화학성분_Ni;
        private string _화학성분_V;
        private string _화학성분_CEQ;

        private string _철근시험항복값;
        private string _철근시험인장값;
        private string _철근시험신율값;
        private string _철근검사단중;


        private string _시편분석_C;
        private string _시편분석_Si;
        private string _시편분석_Mn;
        private string _시편분석_P;
        private string _시편분석_S;
        private string _시편분석_Cu;
        private string _시편분석_Cr;
        private string _시편분석_Ni;
        private string _시편분석_V;








        public string HeatNO
        {
            get { return _HeatNO; }
            set { _HeatNO = value; }
        }

        public string 강종
        {
            get { return _강종; }
            set { _강종 = value; }
        }

        public string 호칭
        {
            get { return _호칭; }
            set { _호칭 = value; }
        }

        public string 검사구분압연NO
        {
            get { return _검사구분압연NO; }
            set { _검사구분압연NO = value; }
        }


        public string 화학성분_C
        {
            get { return _화학성분_C; }
            set { _화학성분_C = value; }
        }

        public string 화학성분_Si
        {
            get { return _화학성분_Si; }
            set { _화학성분_Si = value; }
        }

        public string 화학성분_Mn
        {
            get { return _화학성분_Mn; }
            set { _화학성분_Mn = value; }
        }

        public string 화학성분_P
        {
            get { return _화학성분_P; }
            set { _화학성분_P = value; }
        }

        public string 화학성분_S
        {
            get { return _화학성분_S; }
            set { _화학성분_S = value; }
        }

        public string 화학성분_Cu
        {
            get { return _화학성분_Cu; }
            set { _화학성분_Cu = value; }
        }

        public string 화학성분_Cr
        {
            get { return _화학성분_Cr; }
            set { _화학성분_Cr = value; }
        }

        public string 화학성분_Ni
        {
            get { return _화학성분_Ni; }
            set { _화학성분_Ni = value; }
        }

        public string 화학성분_V
        {
            get { return _화학성분_V; }
            set { _화학성분_V = value; }
        }

        public string 화학성분_CEQ
        {
            get { return _화학성분_CEQ; }
            set { _화학성분_CEQ = value; }
        }

        public string 철근시험항복값
        {
            get { return _철근시험항복값; }
            set { _철근시험항복값 = value; }
        }

        public string 철근시험인장값
        {
            get { return _철근시험인장값; }
            set { _철근시험인장값 = value; }
        }

        public string 철근시험신율값
        {
            get { return _철근시험신율값; }
            set { _철근시험신율값 = value; }
        }

        public string 철근검사단중
        {
            get { return _철근검사단중; }
            set { _철근검사단중 = value; }
        }

/*

        public string 시편분석_C
        {
            get { return _시편분석_C; }
            set { _시편분석_C = value; }
        }

        public string 시편분석_Si
        {
            get { return _시편분석_Si; }
            set { _시편분석_Si = value; }
        }

        public string 시편분석_Mn
        {
            get { return _시편분석_Mn; }
            set { _시편분석_Mn = value; }
        }

        public string 시편분석_P
        {
            get { return _시편분석_P; }
            set { _시편분석_P = value; }
        }

        public string 시편분석_S
        {
            get { return _시편분석_S; }
            set { _시편분석_S = value; }
        }

        public string 시편분석_Cu
        {
            get { return _시편분석_Cu; }
            set { _시편분석_Cu = value; }
        }

        public string 시편분석_Cr
        {
            get { return _시편분석_Cr; }
            set { _시편분석_Cr = value; }
        }

        public string 시편분석_Ni
        {
            get { return _시편분석_Ni; }
            set { _시편분석_Ni = value; }
        }

        public string 시편분석_V
        {
            get { return _시편분석_V; }
            set { _시편분석_V = value; }
        }
        */


        public static List<성분및기계적성질비교> GetOrders(string 일자, int 근무형태, int 압연공장)
        {
            //MessageBox.Show(일자 + " - " + 근무형태.ToString() + " - " + 압연공장.ToString());
            SqlDataAdapter dataAdapter;

            DataSet dataSet;

            List<성분및기계적성질비교> orders;

            orders = new List<성분및기계적성질비교>();

            /* // 압연NO에 해당하는 내용을 불려온다.....DB에 저장된 내용이 없으면 NULL 값을 가져온다.
               // (단, T/D내용은 가져오지 않는다...) 
            SELECT  TQCQ1200.HeatNo, TQCQ1200.AYNO, TQCQ1200.GSIL, TQCQ1200.HCNM, TQCQ1200.GJGB, 
               TQCQ1100.HHC AS 제품분석성분_C, TQCQ1100.HHSi AS 제품분석성분_Si, 
               TQCQ1100.HHMn AS 제품분석성분_Mn, TQCQ1100.HHP AS 제품분석성분_P, 
               TQCQ1100.HHS AS 제품분석성분_S, TQCQ1100.HHCu AS 제품분석성분_Cu, 
               TQCQ1100.HHCr AS 제품분석성분_Cr, TQCQ1100.HHNi AS 제품분석성분_Ni, 
               TQCQ1100.HHV AS 제품분석성분_V, TQCQ1200.GGJSJYP1, TQCQ1200.GGJSJTS1, TQCQ1200.GGJSJEL1, 
               TQCQ1200.DWMGPST1
FROM     TQCQ1200 FULL OUTER JOIN
               TQCQ1100 ON TQCQ1200.HeatNo = TQCQ1100.HeatNo AND TQCQ1200.GSIL = TQCQ1100.GSIL AND 
               TQCQ1200.AYNO = TQCQ1100.AYNO
WHERE  (TQCQ1200.GSIL = '2011-04-20') AND (TQCQ1200.FACGB = 1) AND (TQCQ1200.AYNO LIKE '1%')
ORDER BY TQCQ1200.AYNO

            */
            /*
            dataAdapter = new SqlDataAdapter(
                "SELECT  TQCQ1200.HeatNo, TQCQ1200.AYNO, TQCQ1200.GSIL,  TQCQ1200.HCNM,TQCQ1200.GJGB, " +
                "        TQCQ1100.HHC as TD성분_C, TQCQ1100.HHSi as TD성분_Si, TQCQ1100.HHMn as TD성분_Mn, TQCQ1100.HHP as TD성분_P, " +
                "        TQCQ1100.HHS as TD성분_S, TQCQ1100.HHCu as TD성분_Cu, TQCQ1100.HHCr as TD성분_Cr, TQCQ1100.HHNi as TD성분_Ni, TQCQ1100.HHV as TD성분_V, " +
                "        TQCQ1200.GGJSJYP1, TQCQ1200.GGJSJTS1, TQCQ1200.GGJSJEL1, TQCQ1200.DWMGPST1, " +
                "        TQCQ1100_1.HHC AS 압연시편성분_C, TQCQ1100_1.HHSi AS 압연시편성분_Si, TQCQ1100_1.HHMn AS 압연시편성분_Mn, " +
                "        TQCQ1100_1.HHP AS 압연시편성분_P, TQCQ1100_1.HHS AS 압연시편성분_S, TQCQ1100_1.HHCu AS 압연시편성분_Cu, " +
                "        TQCQ1100_1.HHCr AS 압연시편성분_Cr, TQCQ1100_1.HHNi AS 압연시편성분_Ni, TQCQ1100_1.HHV AS 압연시편성분_V " +
                "FROM    TQCQ1200 INNER JOIN " +
               "         TQCQ1100 ON TQCQ1200.HeatNo = TQCQ1100.HeatNo FULL OUTER JOIN " +
               "         TQCQ1100 AS TQCQ1100_1 ON TQCQ1200.AYNO = TQCQ1100_1.AYNO  AND " +
               "         TQCQ1200.HeatNo = TQCQ1100_1.HeatNo " +
                "WHERE   (TQCQ1200.GSIL = '" + 일자 + "') AND (TQCQ1200.FACGB = " + (압연공장 + 1) + ") AND (TQCQ1200.AYNO LIKE '" + (근무형태 + 1) + "%') AND " +
                "        (TQCQ1100.GSGB = 'T') AND (TQCQ1100.GSSEQ = 1)  " +
                "ORDER BY TQCQ1200.AYNO ",
                "Data Source=HK;Initial Catalog=hkqcdb;User ID=sa;Password=samanager");
                */
            dataAdapter = new SqlDataAdapter(
                // 압연NO에 해당하는 내용을 불려온다.....DB에 저장된 내용이 없으면 NULL 값을 가져온다.
                // (단, T/D내용은 가져오지 않는다...) 
                "SELECT    TQCQ1200.HeatNo, TQCQ1200.AYNO, TQCQ1200.GSIL, TQCQ1200.HCNM, TQCQ1200.GJGB, " +
                "          TQCQ1100.HHC  AS 압연시편성분_C,  TQCQ1100.HHSi AS 압연시편성분_Si, " +
                "          TQCQ1100.HHMn AS 압연시편성분_Mn, TQCQ1100.HHP  AS 압연시편성분_P, " +
                "          TQCQ1100.HHS  AS 압연시편성분_S,  TQCQ1100.HHCu AS 압연시편성분_Cu, " +
                "          TQCQ1100.HHCr AS 압연시편성분_Cr, TQCQ1100.HHNi AS 압연시편성분_Ni, " +
                "          TQCQ1100.HHV  AS 압연시편성분_V, TQCQ1100.CEQ  AS 압연시편성분_CEQ, TQCQ1200.GGJSJYP1, TQCQ1200.GGJSJTS1, " +
                "          TQCQ1200.GGJSJEL1, TQCQ1200.DWMGPST1 " +
                "FROM      TQCQ1200 FULL OUTER JOIN TQCQ1100 ON TQCQ1200.HeatNo = TQCQ1100.HeatNo AND " +
                "          TQCQ1200.GSIL = TQCQ1100.GSIL AND TQCQ1200.AYNO = TQCQ1100.AYNO " +
                "WHERE     (TQCQ1200.GSIL = '" + 일자 + "') AND (TQCQ1200.FACGB = " + (압연공장 + 1) + ") AND " +
                "          (TQCQ1200.AYNO LIKE '" + (근무형태 + 1) + "%')  " +
                "ORDER BY  TQCQ1200.AYNO ",
                "Data Source=HK;Initial Catalog=hkqcdb;User ID=sa;Password=samanager");

            //"select DISTINCT YKWGI, HCNM , GJGB , COUNT(GJGB) , SUM(BonQty) , SUM(JRKg) , SUM(KEGI) from TQCQ1100 " + " where GSIL = '" + DateString + "' AND GSGB='T' AND GSSEQ = '1' GROUP BY YKWGI,GJGB,HCNM ORDER BY HCNM ASC,YKWGI ASC, GJGB ASC;", "Data Source=HKS02;Initial Catalog=hkqcdb;User ID=hkqcuser;Password=hkqcuser");
            //                             //"SELECT DISTINCT  YKWGI, HCNM, GJGB, COUNT(GJGB) AS Expr1, SUM(BonQty) AS Expr2, SUM(JRKg) AS Expr3, SUM(KEGI) AS Expr4 FROM   TQCQ1100 AS [ + ] WHERE  (GSIL = '" + DateString + "') AND (GSGB = 'T') AND (GSSEQ = '1') GROUP BY YKWGI, GJGB, HCNM ORDER BY HCNM, YKWGI, GJGB"
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "TQCQ1100");

            성분및기계적성질비교 order;

            string ChNo = "";

            //MessageBox.Show(dataSet.Tables[0].Rows.Count.ToString());
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=HK;Initial Catalog=hkqcdb;User ID=sa;Password=samanager";

            /*
            SELECT  HeatNo, HHC, HHSi, HHMn, HHP, HHS, HHCu, HHCr, HHNi, HHV, FROM TQCQ1100 WHERE  (GSGB = 'T') AND (GSSEQ = 1) AND (HeatNo = '112110')

            */


            //con.Open();

            foreach (DataRow drOrder in dataSet.Tables[0].Rows)
            {
                if (ChNo != Convert.ToString(drOrder[0]))
                {
                    //order = new 성분및기계적성질비교();

                    /*
                    string 압연시편DB저장쿼리_BEGINTRAN = "SELECT  HeatNo,GJGB AS 강종, HCNM AS 호칭,HHC AS TD성분_C, HHSi AS TD성분_Si, " +
                                                          "        HHMn AS TD성분_Mn, HHP AS TD성분_P, HHS AS TD성분_S, HHCu AS TD성분_Cu, " +
                                                          "        HHCr AS TD성분_Cr, HHNi AS TD성분_Ni, HHV AS TD성분_V " +
                                                          "FROM    TQCQ1100 WHERE  (GSGB = 'T') AND (GSSEQ = 1) AND (HeatNo = '" + drOrder["HeatNo"] + "')";
                    */
                    string 압연시편DB저장쿼리_BEGINTRAN =  " SELECT  HeatNo,  GJGB AS 강종, HCNM AS 호칭,HHC AS TD성분_C, HHSi AS TD성분_Si, " +
                                                          "         HHMn AS TD성분_Mn, HHP AS TD성분_P, HHS AS TD성분_S, HHCu AS TD성분_Cu, " +
                                                          "         HHCr AS TD성분_Cr, HHNi AS TD성분_Ni, HHV AS TD성분_V, CEQ AS TD성분_CEQ ,GSGB, GSSEQ ,BIGO " +
                                                          " FROM    TQCQ1100 WHERE  (GSGB != 'J') and (GSGB != 'C') AND (HeatNo = '" + drOrder["HeatNo"] + "')";

                    SqlCommand cmd3 = new SqlCommand(압연시편DB저장쿼리_BEGINTRAN, con);

                    SqlDataReader outData = null;
                    con.Open();
                    outData = cmd3.ExecuteReader();

                    if (outData.HasRows)
                    {
                        while (outData.Read())
                        {
                            //order.화학성분_Fe = outData["HeatNo"].ToString();
                            if (Convert.ToString(outData["GSGB"]).ToString() != "C")
                            {

                                order = new 성분및기계적성질비교();

                                order.HeatNO = Convert.ToString(outData["HeatNo"]);
                                switch (Convert.ToString(outData["GSGB"]))
                                {
                                    case "L":
                                        order.검사구분압연NO = "L/D";
                                        break;
                                    case "T":
                                        order.검사구분압연NO = "T/D";
                                        break;
                                }
                                //order.검사구분압연NO = Convert.ToString(outData["GSGB"]);
                                //MessageBox.Show(Convert.ToString(outData["GSGB"]));
                                ChNo = Convert.ToString(outData["HeatNo"]);
                                order.강종 = Convert.ToString(outData["강종"]);
                                order.호칭 = Convert.ToString(outData["호칭"]);

                                order.화학성분_C = Convert.ToString(Convert.ToInt32(Convert.ToDouble(outData["TD성분_C"]) * 100));
                                order.화학성분_Si = Convert.ToString(Convert.ToInt32(Convert.ToDouble(outData["TD성분_Si"]) * 100));
                                order.화학성분_Mn = Convert.ToString(Convert.ToInt32(Convert.ToDouble(outData["TD성분_Mn"]) * 100));
                                order.화학성분_P = Convert.ToString(Convert.ToInt32(Convert.ToDouble(outData["TD성분_P"]) * 1000));
                                order.화학성분_S = Convert.ToString(Convert.ToInt32(Convert.ToDouble(outData["TD성분_S"]) * 1000));
                                order.화학성분_Cu = Convert.ToString(Convert.ToInt32(Convert.ToDouble(outData["TD성분_Cu"]) * 100));
                                order.화학성분_Cr = Convert.ToString(Convert.ToInt32(Convert.ToDouble(outData["TD성분_Cr"]) * 100));
                                order.화학성분_Ni = Convert.ToString(Convert.ToInt32(Convert.ToDouble(outData["TD성분_Ni"]) * 100));
                                order.화학성분_V = Convert.ToString(Convert.ToInt32(Convert.ToDouble(outData["TD성분_V"]) * 1000));
                                if (outData["TD성분_CEQ"] == DBNull.Value)
                                {
                                    order.화학성분_CEQ = " ";
                                }
                                else {
                                    order.화학성분_CEQ = Convert.ToString(Convert.ToInt32(Convert.ToDouble(outData["TD성분_CEQ"]) * 100));
                                }
                                order.철근시험항복값 = Convert.ToString(outData["BIGO"]);

                                orders.Add(order);
                            }
                        }
                    }
                    else //HeatNO의 데이터가 없으면...
                    {
                        order = new 성분및기계적성질비교();
                        order.HeatNO = Convert.ToString(drOrder["HeatNo"]);
                        order.검사구분압연NO = "T/D";
                        ChNo = Convert.ToString(drOrder["HeatNo"]);
                        order.강종 = Convert.ToString(drOrder["GJGB"]);
                        order.호칭 = Convert.ToString(drOrder["HCNM"]);

                        order.화학성분_C = "-";
                        order.화학성분_Si = "-";
                        order.화학성분_Mn = "-";
                        order.화학성분_P = "-";
                        order.화학성분_S = "-";
                        order.화학성분_Cu = "-";
                        order.화학성분_Cr = "-";
                        order.화학성분_Ni = "-";
                        order.화학성분_V = "-";
                        order.화학성분_CEQ = "-";

                        orders.Add(order);

                    }

                    con.Close();
                }

                    order = new 성분및기계적성질비교();

                    order.HeatNO = Convert.ToString(drOrder[0]);

                    order.검사구분압연NO = Convert.ToString(drOrder[1]);
                    order.강종 = Convert.ToString(drOrder[4]);
                    order.호칭 = Convert.ToString(drOrder[3]);

                    if (drOrder["압연시편성분_C"] != DBNull.Value)
                    {
                        order.화학성분_C = Convert.ToString(Convert.ToInt32(Convert.ToDouble(drOrder["압연시편성분_C"]) * 100));
                    }

                    if (drOrder["압연시편성분_Si"] != DBNull.Value)
                    {
                        order.화학성분_Si = Convert.ToString(Convert.ToInt32(Convert.ToDouble(drOrder["압연시편성분_Si"]) * 100));
                    }

                    if (drOrder["압연시편성분_Mn"] != DBNull.Value)
                    {
                        order.화학성분_Mn = Convert.ToString(Convert.ToInt32(Convert.ToDouble(drOrder["압연시편성분_Mn"]) * 100));
                    }

                    if (drOrder["압연시편성분_P"] != DBNull.Value)
                    {
                        order.화학성분_P = Convert.ToString(Convert.ToInt32(Convert.ToDouble(drOrder["압연시편성분_P"]) * 1000));
                    }

                    if (drOrder["압연시편성분_S"] != DBNull.Value)
                    {
                        order.화학성분_S = Convert.ToString(Convert.ToInt32(Convert.ToDouble(drOrder["압연시편성분_S"]) * 1000));
                    }

                    if (drOrder["압연시편성분_Cu"] != DBNull.Value)
                    {
                        order.화학성분_Cu = Convert.ToString(Convert.ToInt32(Convert.ToDouble(drOrder["압연시편성분_Cu"]) * 100));
                    }

                    if (drOrder["압연시편성분_Cr"] != DBNull.Value)
                    {
                        order.화학성분_Cr = Convert.ToString(Convert.ToInt32(Convert.ToDouble(drOrder["압연시편성분_Cr"]) * 100));
                    }

                    if (drOrder["압연시편성분_Ni"] != DBNull.Value)
                    {
                        order.화학성분_Ni = Convert.ToString(Convert.ToInt32(Convert.ToDouble(drOrder["압연시편성분_Ni"]) * 100));
                    }

                    if (drOrder["압연시편성분_V"] != DBNull.Value)
                    {
                        order.화학성분_V = Convert.ToString(Convert.ToInt32(Convert.ToDouble(drOrder["압연시편성분_V"]) * 1000));
                    }
                if (drOrder["압연시편성분_CEQ"] != DBNull.Value)
                {
                    order.화학성분_CEQ = Convert.ToString(Convert.ToInt32(Convert.ToDouble(drOrder["압연시편성분_CEQ"]) * 100));
                }

                order.철근시험항복값 = Convert.ToString(drOrder["GGJSJYP1"]);
                    order.철근시험인장값 = Convert.ToString(drOrder["GGJSJTS1"]);
                    order.철근시험신율값 = Convert.ToString(drOrder["GGJSJEL1"]);
                    order.철근검사단중 = Convert.ToString(drOrder["DWMGPST1"]);

                    orders.Add(order);
                }
            con.Close();

            return orders;

            }
            

        }

    
}