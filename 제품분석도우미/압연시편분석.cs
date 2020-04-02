using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace 제품분석도우미
{
    class 압연시편분석
    {
        private string _Index;

        private string _화학성분_Fe;
        private string _화학성분_C;
        private string _화학성분_Si;
        private string _화학성분_Mn;
        private string _화학성분_P;
        private string _화학성분_S;
        private string _화학성분_Cu;
        private string _화학성분_Cr;
        private string _화학성분_Ni;
        private string _화학성분_V;
        private string _화학성분_Mo;
        private string _화학성분_Ti;
        private string _화학성분_Al;
        private string _화학성분_Nb;
        private string _화학성분_Sn;
        private string _화학성분_W;
        private string _화학성분_As;
        private string _화학성분_Sb;
        private string _화학성분_Pb;
        private string _화학성분_N = "0.00000";
        private string _화학성분_Zn;
        private string _화학성분_Ca;
        private string _화학성분_INT;
        private string _화학성분_CE;



        public string Index
        {
            get { return _Index; }
            set { _Index = value; }
        }

        public string 화학성분_Fe
        {
            get { return _화학성분_Fe; }
            set { _화학성분_Fe = value; }
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

        public string 화학성분_Mo
        {
            get { return _화학성분_Mo; }
            set { _화학성분_Mo = value; }
        }

        public string 화학성분_Ti
        {
            get { return _화학성분_Ti; }
            set { _화학성분_Ti = value; }
        }

        public string 화학성분_Al
        {
            get { return _화학성분_Al; }
            set { _화학성분_Al = value; }
        }

        public string 화학성분_Nb
        {
            get { return _화학성분_Nb; }
            set { _화학성분_Nb = value; }
        }

        public string 화학성분_Sn
        {
            get { return _화학성분_Sn; }
            set { _화학성분_Sn = value; }
        }

        public string 화학성분_W
        {
            get { return _화학성분_W; }
            set { _화학성분_W = value; }
        }

        public string 화학성분_As
        {
            get { return _화학성분_As; }
            set { _화학성분_As = value; }
        }

        public string 화학성분_Sb
        {
            get { return _화학성분_Sb; }
            set { _화학성분_Sb = value; }
        }

        public string 화학성분_Pb
        {
            get { return _화학성분_Pb; }
            set { _화학성분_Pb = value; }
        }
        public string 화학성분_N
        {
            get { return _화학성분_N; }
            set { _화학성분_N = value; }
        }

        public string 화학성분_Zn
        {
            get { return _화학성분_Zn; }
            set { _화학성분_Zn = value; }
        }

        public string 화학성분_Ca
        {
            get { return _화학성분_Ca; }
            set { _화학성분_Ca = value; }
        }

        public string 화학성분_INT
        {
            get { return _화학성분_INT; }
            set { _화학성분_INT = value; }
        }

        public string 화학성분_CE
        {
            get { return _화학성분_CE; }
            set { _화학성분_CE = value; }
        }



        public static List<압연시편분석> 분석프로그램저장성분불려오기(string Index)
        {

            List<압연시편분석> orders;

            orders = new List<압연시편분석>();


            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= C:\\PDAWin\\Qrt\\QResult.mdb; Persist Security Info=False";
                
            OleDbConnection myConn = new OleDbConnection(strConn);

            string strRec = " SELECT  QRLIST.SeqNo, QRDATA.DispEle, QRDATA.Content" +
                            " FROM     (QRLIST INNER JOIN QRDATA ON QRLIST.SeqNo = QRDATA.SeqNo) " +
                            " WHERE  (QRLIST.SampIndex LIKE '%" + Index + "%') AND (QRLIST.Kind = 'AV') " +
                            " ORDER BY QRLIST.AnaDate DESC, QRLIST.AnaTime DESC ";

            OleDbCommand myCmd = new OleDbCommand(strRec, myConn);

            OleDbDataReader outData = null;

            myConn.Open();

            outData = myCmd.ExecuteReader(CommandBehavior.CloseConnection);

            압연시편분석 order;

            order = new 압연시편분석();
            //MessageBox.Show(outData.HasRows.ToString());
            if (outData.HasRows)
            {
                while (outData.Read())
                {

                    switch (outData["DispEle"].ToString().Trim())
                    {
                        case "Fe":
                            {
                                order.화학성분_Fe = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "C":
                            {
                                order.화학성분_C = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "Si":
                            {
                                order.화학성분_Si = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "Mn":
                            {
                                order.화학성분_Mn = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "P":
                            {
                                order.화학성분_P = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "S":
                            {
                                order.화학성분_S = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "Cu":
                            {
                                order.화학성분_Cu = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "Cr":
                            {
                                order.화학성분_Cr = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "Ni":
                            {
                                order.화학성분_Ni = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "V":
                            {
                                order.화학성분_V = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "Mo":
                            {
                                order.화학성분_Mo = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "Ti":
                            {
                                order.화학성분_Ti = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "Al":
                            {
                                order.화학성분_Al = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "Nb":
                            {
                                order.화학성분_Nb = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "Sn":
                            {
                                order.화학성분_Sn = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "W":
                            {
                                order.화학성분_W = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "As":
                            {
                                order.화학성분_As = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "Sb":
                            {
                                order.화학성분_Sb = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "Pb":
                            {
                                order.화학성분_Pb = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "N":
                            {
                                order.화학성분_N = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "Zn":
                            {
                                order.화학성분_Zn = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "Ca":
                            {
                                order.화학성분_Ca = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "INT":
                            {
                                order.화학성분_INT = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                        case "CE":
                            {
                                order.화학성분_CE = outData["Content"].ToString();
                                //MessageBox.Show(outData["Content"].ToString());
                                break;
                            }
                    }
                }

                orders.Add(order);
            }  
            



            myConn.Close();

            outData = null;


            //---------

            return orders;

        }

        public static int 압연시편검사순번알아보기(string HeatNO)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=HK;Initial Catalog=hkqcdb;User ID=sa;Password=samanager";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select isnull(Max(a.GSSEQ),0) MaxSEQ from TQCQ1100 a WHERE a.HeatNo = '" + HeatNO + "' and a.GSGB   = 'C' ";
            cmd.CommandType = CommandType.Text;

            con.Open();

            //SqlDataReader 는 결과셋을 탐색 할 수 있는 판독기 이다.
            //select 의 결과를 레코드단위(☆☆☆)로 접근 할 수 있는 도구
            //reader 자체가 결과셋이 아니다.
            //즉 reader는 테이블이 아니다.
            //reader는 한번에 하나의 레코드에만 접근 가능
            SqlDataReader reader = cmd.ExecuteReader(); //반환값이 있을때 사용되는 Execute 실행문.

            reader.Read();

            int MaxSEQ = (int)reader[0];

            reader.Close();
            con.Close();

            return MaxSEQ;
        }
        
        public static void 압연시편DB에저장(string 검사일자, string 반, string 검사원, string 검사원1, string HeatNO
            , string 검사구분, string 검사순번, List<압연시편분석> 분석데이터, string 강종, string 호칭, string 압연NO, string 합격판정, string 등록일자, string 수정일자 )
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=HK;Initial Catalog=hkqcdb;User ID=sa;Password=samanager";

            float CEQ = (float)(Convert.ToDecimal(분석데이터[0].화학성분_C) + (Convert.ToDecimal(분석데이터[0].화학성분_Mn) / 6) + ((Convert.ToDecimal(분석데이터[0].화학성분_Cr) + Convert.ToDecimal(분석데이터[0].화학성분_V) + Convert.ToDecimal(분석데이터[0].화학성분_Mo)) / 5) + (( Convert.ToDecimal(분석데이터[0].화학성분_Cu) +Convert.ToDecimal(분석데이터[0].화학성분_Ni) )/15)   );

            //MessageBox.Show(CEQ.ToString("0.00000"));

            //MessageBox.Show("-"+반+"-");

            string 압연시편DB저장쿼리_BEGINTRAN = " BEGIN TRAN ";
            string 압연시편DB저장쿼리 = " INSERT INTO TQCQ1100 ( GSIL, BAN, GSW, GSW1, HeatNo ,GSGB   ,GSSEQ  , " +
                                        "                        HHFe   ,HHC    ,HHSi   ,HHMn   ,HHP    ,HHS  , " +
                                        "                        HHCu   ,HHCr   ,HHNi   ,HHV    ,HHMo   ,HHTi , " +
                                        "                        HHAl   ,HHNb   ,HHSn   ,HHW    ,HHAs   ,HHSb , " +
                                        "                        HHPb   ,HHN    ,HHZn   ,CEQ    ,HHInt  ,       " +
                                        "                        GJGB   ,HCNM   ,AYNO   ,OKGB   ,DRIL   ,SJIL, BONQTYC ) " +
                                        " VALUES ('" + 검사일자 + "' ," +
                                                 "'" + 반 + "' ," +
                                                 "'" + 검사원 + "' ," +
                                                 "'" + 검사원1 + "' ," +
                                                 "'" + HeatNO + "' ," +
                                                 "'" + 검사구분 + "' ," +
                                                 " " + 검사순번 + "  ," +
                                                 " " + 분석데이터[0].화학성분_Fe + "  ," +
                                                 " " + 분석데이터[0].화학성분_C + "  ," +
                                                 " " + 분석데이터[0].화학성분_Si + "  ," +
                                                 " " + 분석데이터[0].화학성분_Mn + "  ," +
                                                 " " + 분석데이터[0].화학성분_P + "  ," +
                                                 " " + 분석데이터[0].화학성분_S + "  ," +
                                                 " " + 분석데이터[0].화학성분_Cu + "  ," +
                                                 " " + 분석데이터[0].화학성분_Cr + "  ," +
                                                 " " + 분석데이터[0].화학성분_Ni + "  ," +
                                                 " " + 분석데이터[0].화학성분_V + "  ," +
                                                 " " + 분석데이터[0].화학성분_Mo + "  ," +
                                                 " " + 분석데이터[0].화학성분_Ti + "  ," +
                                                 " " + 분석데이터[0].화학성분_Al + "  ," +
                                                 " " + 분석데이터[0].화학성분_Nb + "  ," +
                                                 " " + 분석데이터[0].화학성분_Sn + "  ," +
                                                 " " + 분석데이터[0].화학성분_W + "  ," +
                                                 " " + 분석데이터[0].화학성분_As + "  ," +
                                                 " " + 분석데이터[0].화학성분_Sb + "  ," +
                                                 " " + 분석데이터[0].화학성분_Pb + "  ," +
                                                 " " + 분석데이터[0].화학성분_N + "  ," +
                                                 " " + 분석데이터[0].화학성분_Zn + "  ," +
                                                 " " + CEQ.ToString("0.00000") + "  ," +
                                                 //" " + 분석데이터[0].화학성분_CE + "  ," +
                                                 " " + 분석데이터[0].화학성분_INT + "  ," +
                                                 "'" + 강종 + "' ," +
                                                 "'" + 호칭 + "' ," +
                                                 "'" + 압연NO + "' ," +
                                                 "'" + 합격판정 + "' ," +
                                                 "'" + 등록일자 + "' ," +
                                                 "'" + 수정일자 + "','0' )";                                                 
                                        
                                        
                                        
                                        //" VALUES ('103463' ,'J'   ,1  ,'2010-05-16'   ,'2'    ,'......'    ,           0.0   ,0.0    ,0.0   ,0.0   ,0.0    ,0.0    ,           0.0   ,0.0   ,0.0   ,0.0    ,0.0   ,0.0   ,           0.0   ,0.0   ,0.0   ,0.0    ,0.0   ,0.0   ,           0.0   ,0.0    ,0.0  ,''   ,''   ,                    0.0   ,0.0   ,0.0  ,0.0  ,0.0    ,0.0  ,           0.0  ,0.0  ,0.0  ,0.0  ,0.0  ,''   ,           0.0   ,0.0   ,0.0,0.0   ,0.0 ,0.0   ,           'Y'   ,'20100516 19:07:51.950'   ,'20100516 19:07:51.950'   )



            string 압연시편DB저장쿼리_COMMITTRAN = "COMMIT TRAN";

            con.Open();

            //MessageBox.Show(압연시편DB저장쿼리);
            

            SqlCommand cmd1 = new SqlCommand(압연시편DB저장쿼리_BEGINTRAN, con);
            SqlCommand cmd2 = new SqlCommand(압연시편DB저장쿼리, con);
            SqlCommand cmd3 = new SqlCommand(압연시편DB저장쿼리_COMMITTRAN, con);

            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            
            con.Close();
            
        }
        

    }
}
