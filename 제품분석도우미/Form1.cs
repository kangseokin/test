using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.LookAndFeel;
using System.Xml;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace 제품분석도우미
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public delegate void SendMsgDelegate(string Msg);
        public event SendMsgDelegate SendMsg;

        private MyCellMergeHelper _Helper;

        int ViewTopRowIndex = 0;
        //MyCellMergeHelper _Helper;

        bool showcheck = false;
        Font gridViewFont = new Font("나눔바른고딕", 12);

        public Form1()
        {
            InitializeComponent();

            defaultLookAndFeel1.LookAndFeel.SetSkinStyle("Caramel");
        }

        //환경 설정 데이터 로드.
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument 환경설정xml = new XmlDocument();
            환경설정xml.Load(@"제품분석도우미.xml");

            XmlNodeList 시편유형xmlNodes = 환경설정xml.SelectNodes("/제품분석도우미/시편유형/시편유형");

            //repositoryItemComboBox1.Items.BeginUpdate();
            foreach (XmlNode xmlNode in 시편유형xmlNodes)
            {
                repositoryItemComboBox1.Items.Add(xmlNode.InnerText);
            }
            //repositoryItemComboBox1.Items.EndUpdate();

            XmlNodeList 압연공장xmlNodes = 환경설정xml.SelectNodes("/제품분석도우미/압연공장/압연공장");

            foreach (XmlNode xmlNode in 압연공장xmlNodes)
            {
                repositoryItemComboBox2.Items.Add(xmlNode.InnerText);
            }

            XmlNodeList 근무형태xmlNodes = 환경설정xml.SelectNodes("/제품분석도우미/근무형태/근무형태");

            foreach (XmlNode xmlNode in 근무형태xmlNodes)
            {
                repositoryItemComboBox5.Items.Add(xmlNode.InnerText);
            }

            XmlNodeList 검사원xmlNodes = 환경설정xml.SelectNodes("/제품분석도우미/검사원/검사원");

            foreach (XmlNode xmlNode in 검사원xmlNodes)
            {
                repositoryItemComboBox3.Items.Add(xmlNode.InnerText);
                repositoryItemComboBox4.Items.Add(xmlNode.InnerText);
            }

            //Font gridViewFont = new Font("나눔바른고딕", 13);

            SetGridFont(gridView1, gridViewFont);
        }

        private void SetGridFont(GridView view, Font font)
        {
            foreach (AppearanceObject ap in view.Appearance)
            {
                ap.Font = font;
            }
            view.Appearance.HeaderPanel.Font = new Font("나눔바른고딕", 11);
        }

        private void 시간대로시편유형설정()
        {
            //날짜 설정
            barEditItem1.EditValue = DateTime.Today;
           
            // 오전 7시부터 오후 16시(오후3시)이면 아침반 데이터 표시
            if ((DateTime.Now.TimeOfDay.Hours > 7) && (DateTime.Now.TimeOfDay.Hours < 16))
            {
                barEditItem2.EditValue = "오전반";
            }
            else
            {
                // 오후 3시(15시)부터 오후 23시(오후11시)이면 오후반 데이터 표시
                if ((DateTime.Now.TimeOfDay.Hours > 15) && (DateTime.Now.TimeOfDay.Hours < 23))
                {
                    barEditItem2.EditValue = "오후반";
                }
                else
                {
                    barEditItem1.EditValue = DateTime.Now.Subtract(TimeSpan.FromDays(1));
                    barEditItem2.EditValue = "야간반";
                }
            }
        }

        private void 근무형태별검사원(String 근무형태)
        {
            XmlDocument 환경설정xml = new XmlDocument();
            환경설정xml.Load(@"제품분석도우미.xml");

            XmlNodeList 근무형태별검사원xmlNodes = 환경설정xml.SelectNodes(string.Format("/제품분석도우미/{0}/{0}", 근무형태));

            barEditItem4.EditValue = 근무형태별검사원xmlNodes[0].InnerText;
            barEditItem5.EditValue = 근무형태별검사원xmlNodes[1].InnerText;
        }
        
        //근무형태(반)
        private void repositoryItemComboBox5_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var cbx = sender as ComboBoxEdit;

                근무형태별검사원(cbx.EditValue.ToString());
            }
            catch (NullReferenceException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //ExceptionManager.Manage(ex, true, string.Empty, sender);
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            시간대로시편유형설정();

            barEditItem3.EditValue = "1압연";

            if (gridView1.GetFocusedRowCellValue("HeatNO") != null)
            {
                gridView1.GroupPanelText = "   ";
            }

            showcheck = true;

            _Helper = new MyCellMergeHelper(gridView1);

            표시데이터새로고침();
        }

        public void 화면마진구성해제()
        {
            if (showcheck)
            {
                _Helper.MyMergedCellfree();// = null;
            }
        }
        private void 화면마진구성()
        {
            if (showcheck)
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    string 검사구분 = (string)gridView1.Columns.View.GetRowCellValue(i, "검사구분압연NO");

                    switch (검사구분)
                    {
                        case "L/D":
                        case "T/D":
                            string valuestring = (string)gridView1.Columns.View.GetRowCellValue(i, "철근시험항복값");
                            _Helper.AddMergedCell(i, 15, 14, valuestring);
                            _Helper.AddMergedCell(i, 16, 15, valuestring);
                            _Helper.AddMergedCell(i, 17, 16, valuestring);
                            break;
                        //default:
                        //    break;
                    }
                }
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //MessageBox.Show(e.RowHandle.ToString());
            //e.Column.View.
            string 검사구분 = (string)e.Column.View.GetRowCellValue(e.RowHandle, "검사구분압연NO");
            
            // T/D 부분의 색을 입히는 부분
            switch (검사구분)
            {
                case "L/D":
                case "T/D":
                    if (e.Column.Name.Equals("col검사구분압연NO"))
                    {
                        e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                        e.Appearance.ForeColor = Color.Blue;

                        e.Appearance.Font = new Font(gridViewFont, FontStyle.Bold);
                        //e.Appearance.Font = AppearanceObject.DefaultFont;
                        

                    }

                    if (e.Column.Name.Equals("col화학성분_C"))
                    {
                        e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                        e.Appearance.ForeColor = Color.Blue;

                        e.Appearance.Font = new Font(gridViewFont, FontStyle.Bold);
                        //e.Appearance.Font = AppearanceObject.DefaultFont;
                    }

                    if (e.Column.Name.Equals("col화학성분_Si"))
                    {
                        e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                        e.Appearance.ForeColor = Color.Blue;

                        e.Appearance.Font = new Font(gridViewFont, FontStyle.Bold);
                        //e.Appearance.Font = AppearanceObject.DefaultFont;
                    }

                    if (e.Column.Name.Equals("col화학성분_Mn"))
                    {
                        e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                        e.Appearance.ForeColor = Color.Blue;

                        e.Appearance.Font = new Font(gridViewFont, FontStyle.Bold);
                        //e.Appearance.Font = AppearanceObject.DefaultFont;
                    }

                    if (e.Column.Name.Equals("col화학성분_P"))
                    {
                        e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                        e.Appearance.ForeColor = Color.Blue;

                        e.Appearance.Font = new Font(gridViewFont, FontStyle.Bold);
                        //e.Appearance.Font = AppearanceObject.DefaultFont;
                    }

                    if (e.Column.Name.Equals("col화학성분_S"))
                    {
                        e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                        e.Appearance.ForeColor = Color.Blue;

                        e.Appearance.Font = new Font(gridViewFont, FontStyle.Bold);
                        //e.Appearance.Font = AppearanceObject.DefaultFont;
                    }

                    if (e.Column.Name.Equals("col화학성분_Cu"))
                    {
                        e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                        e.Appearance.ForeColor = Color.Blue;

                        e.Appearance.Font = new Font(gridViewFont, FontStyle.Bold);
                        //e.Appearance.Font = AppearanceObject.DefaultFont;
                    }

                    if (e.Column.Name.Equals("col화학성분_Cr"))
                    {
                        e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                        e.Appearance.ForeColor = Color.Blue;

                        e.Appearance.Font = new Font(gridViewFont, FontStyle.Bold);
                        //e.Appearance.Font = AppearanceObject.DefaultFont;
                    }

                    if (e.Column.Name.Equals("col화학성분_Ni"))
                    {
                        e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                        e.Appearance.ForeColor = Color.Blue;

                        e.Appearance.Font = new Font(gridViewFont, FontStyle.Bold);
                        //e.Appearance.Font = AppearanceObject.DefaultFont;
                    }

                    if (e.Column.Name.Equals("col화학성분_V"))
                    {
                        e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                        e.Appearance.ForeColor = Color.Blue;

                        e.Appearance.Font = new Font(gridViewFont, FontStyle.Bold);
                        //e.Appearance.Font = AppearanceObject.DefaultFont;
                    }
                    if (e.Column.Name.Equals("col화학성분_CEQ"))
                    {
                        e.Appearance.BackColor = Color.SandyBrown;// Color.FromArgb(186, 222, 254);
                        e.Appearance.ForeColor = Color.Blue;

                        e.Appearance.Font = new Font(gridViewFont, FontStyle.Bold);
                        //e.Appearance.Font = AppearanceObject.DefaultFont;
                    }

                    break;
                default:
                    if (e.Column.Name.Equals("col검사구분압연NO"))
                    {
                        e.Appearance.BackColor = Color.Gray;// Color.FromArgb(186, 222, 254);
                        e.Appearance.ForeColor = Color.Blue;

                        e.Appearance.Font = new Font(gridViewFont, FontStyle.Bold);
                        //e.Appearance.Font = AppearanceObject.DefaultFont;
                    }
                    break;
            }

            /*
            if ((string)e.Column.View.GetRowCellValue(e.RowHandle, "검사구분압연NO") == "L/D")
            {
                if (e.Column.Name.Equals("col검사구분압연NO"))
                {
                    e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                    e.Appearance.ForeColor = Color.Blue;

                    e.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
                    //e.Appearance.Font = AppearanceObject.DefaultFont;

                }

                if (e.Column.Name.Equals("col화학성분_C"))
                {
                    e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                    e.Appearance.ForeColor = Color.Blue;

                    e.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
                    //e.Appearance.Font = AppearanceObject.DefaultFont;
                }

                if (e.Column.Name.Equals("col화학성분_Si"))
                {
                    e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                    e.Appearance.ForeColor = Color.Blue;

                    e.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
                    //e.Appearance.Font = AppearanceObject.DefaultFont;
                }

                if (e.Column.Name.Equals("col화학성분_Mn"))
                {
                    e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                    e.Appearance.ForeColor = Color.Blue;

                    e.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
                    //e.Appearance.Font = AppearanceObject.DefaultFont;
                }

                if (e.Column.Name.Equals("col화학성분_P"))
                {
                    e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                    e.Appearance.ForeColor = Color.Blue;

                    e.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
                    //e.Appearance.Font = AppearanceObject.DefaultFont;
                }

                if (e.Column.Name.Equals("col화학성분_S"))
                {
                    e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                    e.Appearance.ForeColor = Color.Blue;

                    e.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
                    //e.Appearance.Font = AppearanceObject.DefaultFont;
                }

                if (e.Column.Name.Equals("col화학성분_Cu"))
                {
                    e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                    e.Appearance.ForeColor = Color.Blue;

                    e.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
                    //e.Appearance.Font = AppearanceObject.DefaultFont;
                }

                if (e.Column.Name.Equals("col화학성분_Cr"))
                {
                    e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                    e.Appearance.ForeColor = Color.Blue;

                    e.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
                    //e.Appearance.Font = AppearanceObject.DefaultFont;
                }

                if (e.Column.Name.Equals("col화학성분_Ni"))
                {
                    e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                    e.Appearance.ForeColor = Color.Blue;

                    e.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
                    //e.Appearance.Font = AppearanceObject.DefaultFont;
                }

                if (e.Column.Name.Equals("col화학성분_V"))
                {
                    e.Appearance.BackColor = Color.Yellow;// Color.FromArgb(186, 222, 254);
                    e.Appearance.ForeColor = Color.Blue;

                    e.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
                    //e.Appearance.Font = AppearanceObject.DefaultFont;
                }
            }
            else
            {
                if (e.Column.Name.Equals("col검사구분압연NO"))
                {
                    e.Appearance.BackColor = Color.Gray;// Color.FromArgb(186, 222, 254);
                    e.Appearance.ForeColor = Color.Blue;

                    e.Appearance.Font = new Font(AppearanceObject.DefaultFont, FontStyle.Bold);
                    //e.Appearance.Font = AppearanceObject.DefaultFont;
                }
            }
            */
        }

        //[ 새로고침 버튼 클릭 ]-------------------------------------------------------------------------------------------------
        private void 표시데이터새로고침()
        {
            gridControl1.DataSource = 성분및기계적성질비교.GetOrders(repositoryItemDateEdit1.GetDisplayText(barEditItem1.EditValue), repositoryItemComboBox1.Items.IndexOf(barEditItem2.EditValue), repositoryItemComboBox2.Items.IndexOf(barEditItem3.EditValue));

            gridView1.TopRowIndex = ViewTopRowIndex;

            gridView1.Focus();

            화면마진구성해제();

            화면마진구성();

            gridControl1.Update();
        }

        //새로고침 버튼.
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            표시데이터새로고침();
        }

        //날짜 변경시.
        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            표시데이터새로고침();
        }

        //시편유형 변경시.
        private void barEditItem2_EditValueChanged(object sender, EventArgs e)
        {
            표시데이터새로고침();
        }

        //압연공장 변경시.
        private void barEditItem3_EditValueChanged(object sender, EventArgs e)
        {
            표시데이터새로고침();
        }

        //-----------------------------------------------------------------------------------------------------------------------


        /*

        private void repositoryItemButtonEdit1_EditValueChanged(object sender, System.EventArgs e) {
         DateTime dateTime = (sender as DevExpress.XtraEditors.DateEdit).DateTime;
         //.....
     }
*/

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            DateTime dateTime = (DateTime)barEditItem1.EditValue;

            if (gridView1.GetFocusedRowCellDisplayText("검사구분압연NO").ToString() != "T/D")
            {
                //gridView1.GroupPanelText = gridView1.GetFocusedRowCellValue("HeatNO").ToString() + "C" + "-" + gridView1.GetFocusedRowCellValue("호칭").ToString() + "-" + dateEdit1.DateTime.Month.ToString("00") + dateEdit1.DateTime.Day.ToString("00") + "-" + gridView1.GetFocusedRowCellDisplayText("검사구분압연NO").Replace('-', '*').ToString();

                //MessageBox.Show(comboBoxEdit3.SelectedIndex.ToString());
                if (gridView1.GetFocusedRowCellValue("화학성분_C") == null) // c의 성분이 없으면 아직 db에 저장하지 않은 것으로 본다.
                {
                    //repositoryItemComboBox3.Items.IndexOf(barEditItem4.EditValue)
                    if ((repositoryItemComboBox3.Items.IndexOf(barEditItem4.EditValue) != -1) && (repositoryItemComboBox4.Items.IndexOf(barEditItem5.EditValue) != -1) && (repositoryItemComboBox5.Items.IndexOf(barEditItem6.EditValue) != -1) && ((repositoryItemComboBox3.Items.IndexOf(barEditItem4.EditValue) != (repositoryItemComboBox4.Items.IndexOf(barEditItem5.EditValue)))))
                    {
                        
                        List<압연시편분석> orders2 = 압연시편분석.분석프로그램저장성분불려오기(gridView1.GetFocusedRowCellValue("HeatNO").ToString() + "C" + "-" + gridView1.GetFocusedRowCellValue("호칭").ToString() + "-" + dateTime.Month.ToString("00") + dateTime.Day.ToString("00") + "-" + gridView1.GetFocusedRowCellDisplayText("검사구분압연NO").Replace('-', '*').ToString());
                        if (orders2.Count != 0)
                        {
                            //MessageBox.Show(orders2.Count.ToString());
                            //barEditItem1.Edit.
                            
                            //MessageBox.Show(orders2[0].화학성분_C);


                            if (압연시편분석.압연시편검사순번알아보기(gridView1.GetFocusedRowCellValue("HeatNO").ToString()) > 0)
                            {// SEQ 증가하여 저장.
                                //MessageBox.Show(압연시편분석.압연시편검사순번알아보기(gridView1.GetFocusedRowCellValue("HeatNO").ToString()).ToString());
                                string aaa = "";

                                switch (barEditItem6.EditValue.ToString())
                                {
                                    case "A반":
                                        {
                                            aaa = "1";
                                            break;
                                        }
                                    case "B반":
                                        {
                                            aaa = "2";
                                            break;
                                        }
                                    case "C반":
                                        {
                                            aaa = "3";
                                            break;
                                        }
                                    case "D반":
                                        {
                                            aaa = "4";
                                            break;
                                        }
                                }
                                압연시편분석.압연시편DB에저장(repositoryItemDateEdit1.GetDisplayText(barEditItem1.EditValue), aaa, barEditItem4.EditValue.ToString(), barEditItem5.EditValue.ToString(), gridView1.GetFocusedRowCellValue("HeatNO").ToString()
                                    , "C", (압연시편분석.압연시편검사순번알아보기(gridView1.GetFocusedRowCellValue("HeatNO").ToString()) + 1).ToString(), orders2, gridView1.GetFocusedRowCellValue("강종").ToString(), gridView1.GetFocusedRowCellValue("호칭").ToString(), gridView1.GetFocusedRowCellDisplayText("검사구분압연NO").ToString(), "Y", DateTime.Now.ToString("yyyyMMdd HH:mm:ss"), DateTime.Now.ToString("yyyyMMdd HH:mm:ss"));

                                ViewTopRowIndex = gridView1.TopRowIndex;
                                // 새로고침

                                표시데이터새로고침();
                            }
                            else // 신규
                            {
                                string aaa = "";

                                switch (barEditItem6.EditValue.ToString())
                                {
                                    case "A반":
                                        {
                                            aaa = "1";
                                            break;
                                        }
                                    case "B반":
                                        {
                                            aaa = "2";
                                            break;
                                        }
                                    case "C반":
                                        {
                                            aaa = "3";
                                            break;
                                        }
                                    case "D반":
                                        {
                                            aaa = "4";
                                            break;
                                        }
                                }
                                압연시편분석.압연시편DB에저장(repositoryItemDateEdit1.GetDisplayText(barEditItem1.EditValue), aaa, barEditItem4.EditValue.ToString(), barEditItem5.EditValue.ToString(), gridView1.GetFocusedRowCellValue("HeatNO").ToString()
                                    , "C", "1", orders2, gridView1.GetFocusedRowCellValue("강종").ToString(), gridView1.GetFocusedRowCellValue("호칭").ToString(), gridView1.GetFocusedRowCellDisplayText("검사구분압연NO").ToString(), "Y", DateTime.Now.ToString("yyyyMMdd HH:mm:ss"), DateTime.Now.ToString("yyyyMMdd HH:mm:ss"));

                                gridView1.GroupPanelText = gridView1.GetFocusedRowCellValue("HeatNO").ToString() + "C" + "-" + gridView1.GetFocusedRowCellValue("호칭").ToString() + "-" + dateTime.Month.ToString("00") + dateTime.Day.ToString("00") + "-" + gridView1.GetFocusedRowCellDisplayText("검사구분압연NO").Replace('-', '*').ToString() + " 데이터가 저장 되어있습니다.";

                                ViewTopRowIndex = gridView1.TopRowIndex;

                                // 새로고침
                                표시데이터새로고침();


                            }

                            //orders2[1].

                        }
                        else // HeatNO에 해당하는 분석기 프로그램에 저장이 안되어있음...
                        {
                            //gridView1.
                            gridView1.GroupPanelText = "분석기 프로그램 데이터에 " + gridView1.GetFocusedRowCellValue("HeatNO").ToString() + "C" + "-" + gridView1.GetFocusedRowCellValue("호칭").ToString() + "-" + dateTime.Month.ToString("00") + dateTime.Day.ToString("00") + "-" + gridView1.GetFocusedRowCellDisplayText("검사구분압연NO").Replace('-', '*').ToString() + " 데이터가 저장 되어있지 않습니다.";
                        }
                    }
                    else
                    {
                        gridView1.GroupPanelText = "분석 정보란의 입력이 제대로 되어 있지 않습니다...";
                    }
                }
                else
                {
                    gridView1.GroupPanelText = gridView1.GetFocusedRowCellValue("HeatNO").ToString() + "C" + "-" + gridView1.GetFocusedRowCellValue("호칭").ToString() + "-" + dateTime.Month.ToString("00") + dateTime.Day.ToString("00") + "-" + gridView1.GetFocusedRowCellDisplayText("검사구분압연NO").Replace('-', '*').ToString() + " 데이터가 이미 저장 되어있습니다.";

                }
            }
            //else
            //{
            //    e.Cancel = true;
            //}

            e.Cancel = true;
            
        }

        private void gridView1_CellMerge(object sender, CellMergeEventArgs e)
        {
            //gridView1.
            //e.Column.View.
        }
    }
}
