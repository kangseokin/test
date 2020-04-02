namespace 제품분석도우미
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barEditItem4 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barEditItem5 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barEditItem6 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox5 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox6 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.성분및기계적성질비교BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHeatNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col강종 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col호칭 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col검사구분압연NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col화학성분_C = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col화학성분_Si = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col화학성분_Mn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col화학성분_P = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col화학성분_S = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col화학성분_Cu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col화학성분_Cr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col화학성분_Ni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col화학성분_V = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col화학성분_CEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col철근시험항복값 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col철근시험인장값 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col철근시험신율값 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col철근검사단중 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.성분및기계적성질비교BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AutoSizeItems = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barEditItem1,
            this.barEditItem2,
            this.barEditItem3,
            this.barEditItem4,
            this.barEditItem5,
            this.barEditItem6,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemComboBox3,
            this.repositoryItemComboBox4,
            this.repositoryItemComboBox5,
            this.repositoryItemComboBox6});
            this.ribbonControl1.Size = new System.Drawing.Size(1010, 144);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "날짜";
            this.barEditItem1.Edit = this.repositoryItemDateEdit1;
            this.barEditItem1.Id = 1;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.Width = 120;
            this.barEditItem1.EditValueChanged += new System.EventHandler(this.barEditItem1_EditValueChanged);
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemDateEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "yyyy/MM/dd";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemDateEdit1.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText;
            this.repositoryItemDateEdit1.Mask.EditMask = "yyyy/MM/dd";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "시편유형";
            this.barEditItem2.Edit = this.repositoryItemComboBox1;
            this.barEditItem2.Id = 2;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.Width = 120;
            this.barEditItem2.EditValueChanged += new System.EventHandler(this.barEditItem2_EditValueChanged);
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemComboBox1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemComboBox1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "압연공장";
            this.barEditItem3.Edit = this.repositoryItemComboBox2;
            this.barEditItem3.Id = 3;
            this.barEditItem3.Name = "barEditItem3";
            this.barEditItem3.Width = 120;
            this.barEditItem3.EditValueChanged += new System.EventHandler(this.barEditItem3_EditValueChanged);
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.Appearance.Options.UseTextOptions = true;
            this.repositoryItemComboBox2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemComboBox2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // barEditItem4
            // 
            this.barEditItem4.Caption = "검사원";
            this.barEditItem4.Edit = this.repositoryItemComboBox3;
            this.barEditItem4.Id = 4;
            this.barEditItem4.Name = "barEditItem4";
            this.barEditItem4.Width = 120;
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.Appearance.Options.UseTextOptions = true;
            this.repositoryItemComboBox3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemComboBox3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // barEditItem5
            // 
            this.barEditItem5.Caption = "검사원";
            this.barEditItem5.Edit = this.repositoryItemComboBox4;
            this.barEditItem5.Id = 5;
            this.barEditItem5.Name = "barEditItem5";
            this.barEditItem5.Width = 120;
            // 
            // repositoryItemComboBox4
            // 
            this.repositoryItemComboBox4.Appearance.Options.UseTextOptions = true;
            this.repositoryItemComboBox4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemComboBox4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemComboBox4.AutoHeight = false;
            this.repositoryItemComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox4.Name = "repositoryItemComboBox4";
            // 
            // barEditItem6
            // 
            this.barEditItem6.Caption = "근무형태(반)";
            this.barEditItem6.Edit = this.repositoryItemComboBox5;
            this.barEditItem6.Id = 6;
            this.barEditItem6.Name = "barEditItem6";
            this.barEditItem6.Width = 120;
            // 
            // repositoryItemComboBox5
            // 
            this.repositoryItemComboBox5.Appearance.Options.UseTextOptions = true;
            this.repositoryItemComboBox5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemComboBox5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemComboBox5.AutoHeight = false;
            this.repositoryItemComboBox5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox5.Name = "repositoryItemComboBox5";
            this.repositoryItemComboBox5.EditValueChanged += new System.EventHandler(this.repositoryItemComboBox5_EditValueChanged);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "새로고침";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.LargeWidth = 100;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "제품 분석 도우미";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "압연 시편 정보";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barEditItem6);
            this.ribbonPageGroup2.ItemLinks.Add(this.barEditItem4);
            this.ribbonPageGroup2.ItemLinks.Add(this.barEditItem5);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "분석 정보";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "새로고침";
            // 
            // repositoryItemComboBox6
            // 
            this.repositoryItemComboBox6.AutoHeight = false;
            this.repositoryItemComboBox6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox6.Name = "repositoryItemComboBox6";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 751);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1010, 25);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Caramel";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.성분및기계적성질비교BindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridControl1.Location = new System.Drawing.Point(0, 144);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1010, 607);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // 성분및기계적성질비교BindingSource
            // 
            this.성분및기계적성질비교BindingSource.DataSource = typeof(제품분석도우미.성분및기계적성질비교);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridView1.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHeatNO,
            this.col강종,
            this.col호칭,
            this.col검사구분압연NO,
            this.col화학성분_C,
            this.col화학성분_Si,
            this.col화학성분_Mn,
            this.col화학성분_P,
            this.col화학성분_S,
            this.col화학성분_Cu,
            this.col화학성분_Cr,
            this.col화학성분_Ni,
            this.col화학성분_V,
            this.col화학성분_CEQ,
            this.col철근시험항복값,
            this.col철근시험인장값,
            this.col철근시험신율값,
            this.col철근검사단중});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.RowHeight = 25;
            this.gridView1.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.gridView1_CellMerge);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            // 
            // colHeatNO
            // 
            this.colHeatNO.AppearanceCell.Options.UseTextOptions = true;
            this.colHeatNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHeatNO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHeatNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colHeatNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHeatNO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colHeatNO.FieldName = "HeatNO";
            this.colHeatNO.Name = "colHeatNO";
            this.colHeatNO.OptionsColumn.AllowEdit = false;
            this.colHeatNO.OptionsColumn.AllowFocus = false;
            this.colHeatNO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colHeatNO.OptionsColumn.ReadOnly = true;
            this.colHeatNO.Visible = true;
            this.colHeatNO.VisibleIndex = 0;
            this.colHeatNO.Width = 80;
            // 
            // col강종
            // 
            this.col강종.AppearanceCell.Options.UseTextOptions = true;
            this.col강종.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col강종.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col강종.AppearanceHeader.Options.UseTextOptions = true;
            this.col강종.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col강종.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col강종.FieldName = "강종";
            this.col강종.Name = "col강종";
            this.col강종.OptionsColumn.AllowEdit = false;
            this.col강종.OptionsColumn.AllowFocus = false;
            this.col강종.OptionsColumn.ReadOnly = true;
            // 
            // col호칭
            // 
            this.col호칭.AppearanceCell.Options.UseTextOptions = true;
            this.col호칭.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col호칭.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col호칭.AppearanceHeader.Options.UseTextOptions = true;
            this.col호칭.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col호칭.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col호칭.FieldName = "호칭";
            this.col호칭.Name = "col호칭";
            this.col호칭.OptionsColumn.AllowEdit = false;
            this.col호칭.OptionsColumn.AllowFocus = false;
            this.col호칭.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col호칭.OptionsColumn.ReadOnly = true;
            this.col호칭.Visible = true;
            this.col호칭.VisibleIndex = 1;
            this.col호칭.Width = 58;
            // 
            // col검사구분압연NO
            // 
            this.col검사구분압연NO.AppearanceCell.Options.UseTextOptions = true;
            this.col검사구분압연NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col검사구분압연NO.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col검사구분압연NO.AppearanceHeader.Options.UseTextOptions = true;
            this.col검사구분압연NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col검사구분압연NO.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col검사구분압연NO.Caption = "압연NO";
            this.col검사구분압연NO.FieldName = "검사구분압연NO";
            this.col검사구분압연NO.Name = "col검사구분압연NO";
            this.col검사구분압연NO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col검사구분압연NO.OptionsColumn.ReadOnly = true;
            this.col검사구분압연NO.OptionsColumn.ShowInCustomizationForm = false;
            this.col검사구분압연NO.Visible = true;
            this.col검사구분압연NO.VisibleIndex = 2;
            this.col검사구분압연NO.Width = 70;
            // 
            // col화학성분_C
            // 
            this.col화학성분_C.AppearanceCell.Options.UseTextOptions = true;
            this.col화학성분_C.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_C.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_C.AppearanceHeader.Options.UseTextOptions = true;
            this.col화학성분_C.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_C.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_C.Caption = "C";
            this.col화학성분_C.FieldName = "화학성분_C";
            this.col화학성분_C.Name = "col화학성분_C";
            this.col화학성분_C.OptionsColumn.AllowEdit = false;
            this.col화학성분_C.OptionsColumn.AllowFocus = false;
            this.col화학성분_C.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col화학성분_C.OptionsColumn.ReadOnly = true;
            this.col화학성분_C.Visible = true;
            this.col화학성분_C.VisibleIndex = 3;
            this.col화학성분_C.Width = 45;
            // 
            // col화학성분_Si
            // 
            this.col화학성분_Si.AppearanceCell.Options.UseTextOptions = true;
            this.col화학성분_Si.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_Si.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_Si.AppearanceHeader.Options.UseTextOptions = true;
            this.col화학성분_Si.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_Si.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_Si.Caption = "Si";
            this.col화학성분_Si.FieldName = "화학성분_Si";
            this.col화학성분_Si.Name = "col화학성분_Si";
            this.col화학성분_Si.OptionsColumn.AllowEdit = false;
            this.col화학성분_Si.OptionsColumn.AllowFocus = false;
            this.col화학성분_Si.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col화학성분_Si.OptionsColumn.ReadOnly = true;
            this.col화학성분_Si.Visible = true;
            this.col화학성분_Si.VisibleIndex = 4;
            this.col화학성분_Si.Width = 45;
            // 
            // col화학성분_Mn
            // 
            this.col화학성분_Mn.AppearanceCell.Options.UseTextOptions = true;
            this.col화학성분_Mn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_Mn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_Mn.AppearanceHeader.Options.UseTextOptions = true;
            this.col화학성분_Mn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_Mn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_Mn.Caption = "Mn";
            this.col화학성분_Mn.FieldName = "화학성분_Mn";
            this.col화학성분_Mn.Name = "col화학성분_Mn";
            this.col화학성분_Mn.OptionsColumn.AllowEdit = false;
            this.col화학성분_Mn.OptionsColumn.AllowFocus = false;
            this.col화학성분_Mn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col화학성분_Mn.OptionsColumn.ReadOnly = true;
            this.col화학성분_Mn.Visible = true;
            this.col화학성분_Mn.VisibleIndex = 5;
            this.col화학성분_Mn.Width = 53;
            // 
            // col화학성분_P
            // 
            this.col화학성분_P.AppearanceCell.Options.UseTextOptions = true;
            this.col화학성분_P.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_P.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_P.AppearanceHeader.Options.UseTextOptions = true;
            this.col화학성분_P.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_P.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_P.Caption = "P";
            this.col화학성분_P.FieldName = "화학성분_P";
            this.col화학성분_P.Name = "col화학성분_P";
            this.col화학성분_P.OptionsColumn.AllowEdit = false;
            this.col화학성분_P.OptionsColumn.AllowFocus = false;
            this.col화학성분_P.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col화학성분_P.OptionsColumn.ReadOnly = true;
            this.col화학성분_P.Visible = true;
            this.col화학성분_P.VisibleIndex = 6;
            this.col화학성분_P.Width = 45;
            // 
            // col화학성분_S
            // 
            this.col화학성분_S.AppearanceCell.Options.UseTextOptions = true;
            this.col화학성분_S.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_S.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_S.AppearanceHeader.Options.UseTextOptions = true;
            this.col화학성분_S.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_S.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_S.Caption = "S";
            this.col화학성분_S.FieldName = "화학성분_S";
            this.col화학성분_S.Name = "col화학성분_S";
            this.col화학성분_S.OptionsColumn.AllowEdit = false;
            this.col화학성분_S.OptionsColumn.AllowFocus = false;
            this.col화학성분_S.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col화학성분_S.OptionsColumn.ReadOnly = true;
            this.col화학성분_S.Visible = true;
            this.col화학성분_S.VisibleIndex = 7;
            this.col화학성분_S.Width = 45;
            // 
            // col화학성분_Cu
            // 
            this.col화학성분_Cu.AppearanceCell.Options.UseTextOptions = true;
            this.col화학성분_Cu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_Cu.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_Cu.AppearanceHeader.Options.UseTextOptions = true;
            this.col화학성분_Cu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_Cu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_Cu.Caption = "Cu";
            this.col화학성분_Cu.FieldName = "화학성분_Cu";
            this.col화학성분_Cu.Name = "col화학성분_Cu";
            this.col화학성분_Cu.OptionsColumn.AllowEdit = false;
            this.col화학성분_Cu.OptionsColumn.AllowFocus = false;
            this.col화학성분_Cu.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col화학성분_Cu.OptionsColumn.ReadOnly = true;
            this.col화학성분_Cu.Visible = true;
            this.col화학성분_Cu.VisibleIndex = 8;
            this.col화학성분_Cu.Width = 45;
            // 
            // col화학성분_Cr
            // 
            this.col화학성분_Cr.AppearanceCell.Options.UseTextOptions = true;
            this.col화학성분_Cr.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_Cr.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_Cr.AppearanceHeader.Options.UseTextOptions = true;
            this.col화학성분_Cr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_Cr.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_Cr.Caption = "Cr";
            this.col화학성분_Cr.FieldName = "화학성분_Cr";
            this.col화학성분_Cr.Name = "col화학성분_Cr";
            this.col화학성분_Cr.OptionsColumn.AllowEdit = false;
            this.col화학성분_Cr.OptionsColumn.AllowFocus = false;
            this.col화학성분_Cr.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col화학성분_Cr.OptionsColumn.ReadOnly = true;
            this.col화학성분_Cr.Visible = true;
            this.col화학성분_Cr.VisibleIndex = 9;
            this.col화학성분_Cr.Width = 45;
            // 
            // col화학성분_Ni
            // 
            this.col화학성분_Ni.AppearanceCell.Options.UseTextOptions = true;
            this.col화학성분_Ni.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_Ni.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_Ni.AppearanceHeader.Options.UseTextOptions = true;
            this.col화학성분_Ni.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_Ni.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_Ni.Caption = "Ni";
            this.col화학성분_Ni.FieldName = "화학성분_Ni";
            this.col화학성분_Ni.Name = "col화학성분_Ni";
            this.col화학성분_Ni.OptionsColumn.AllowEdit = false;
            this.col화학성분_Ni.OptionsColumn.AllowFocus = false;
            this.col화학성분_Ni.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col화학성분_Ni.OptionsColumn.ReadOnly = true;
            this.col화학성분_Ni.Visible = true;
            this.col화학성분_Ni.VisibleIndex = 10;
            this.col화학성분_Ni.Width = 45;
            // 
            // col화학성분_V
            // 
            this.col화학성분_V.AppearanceCell.Options.UseTextOptions = true;
            this.col화학성분_V.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_V.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_V.AppearanceHeader.Options.UseTextOptions = true;
            this.col화학성분_V.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_V.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_V.Caption = "V";
            this.col화학성분_V.FieldName = "화학성분_V";
            this.col화학성분_V.Name = "col화학성분_V";
            this.col화학성분_V.OptionsColumn.AllowEdit = false;
            this.col화학성분_V.OptionsColumn.AllowFocus = false;
            this.col화학성분_V.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col화학성분_V.OptionsColumn.ReadOnly = true;
            this.col화학성분_V.Visible = true;
            this.col화학성분_V.VisibleIndex = 11;
            this.col화학성분_V.Width = 47;
            // 
            // col화학성분_CEQ
            // 
            this.col화학성분_CEQ.AppearanceCell.Options.UseTextOptions = true;
            this.col화학성분_CEQ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_CEQ.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_CEQ.AppearanceHeader.Options.UseTextOptions = true;
            this.col화학성분_CEQ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col화학성분_CEQ.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col화학성분_CEQ.Caption = "CEQ";
            this.col화학성분_CEQ.FieldName = "화학성분_CEQ";
            this.col화학성분_CEQ.Name = "col화학성분_CEQ";
            this.col화학성분_CEQ.OptionsColumn.AllowEdit = false;
            this.col화학성분_CEQ.OptionsColumn.AllowFocus = false;
            this.col화학성분_CEQ.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col화학성분_CEQ.OptionsColumn.ReadOnly = true;
            this.col화학성분_CEQ.Visible = true;
            this.col화학성분_CEQ.VisibleIndex = 12;
            this.col화학성분_CEQ.Width = 45;
            // 
            // col철근시험항복값
            // 
            this.col철근시험항복값.AppearanceCell.Options.UseTextOptions = true;
            this.col철근시험항복값.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col철근시험항복값.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col철근시험항복값.AppearanceHeader.Options.UseTextOptions = true;
            this.col철근시험항복값.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col철근시험항복값.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col철근시험항복값.Caption = "항복값";
            this.col철근시험항복값.FieldName = "철근시험항복값";
            this.col철근시험항복값.Name = "col철근시험항복값";
            this.col철근시험항복값.OptionsColumn.AllowEdit = false;
            this.col철근시험항복값.OptionsColumn.AllowFocus = false;
            this.col철근시험항복값.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col철근시험항복값.OptionsColumn.ReadOnly = true;
            this.col철근시험항복값.Visible = true;
            this.col철근시험항복값.VisibleIndex = 13;
            this.col철근시험항복값.Width = 70;
            // 
            // col철근시험인장값
            // 
            this.col철근시험인장값.AppearanceCell.Options.UseTextOptions = true;
            this.col철근시험인장값.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col철근시험인장값.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col철근시험인장값.AppearanceHeader.Options.UseTextOptions = true;
            this.col철근시험인장값.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col철근시험인장값.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col철근시험인장값.Caption = "인장값";
            this.col철근시험인장값.FieldName = "철근시험인장값";
            this.col철근시험인장값.Name = "col철근시험인장값";
            this.col철근시험인장값.OptionsColumn.AllowEdit = false;
            this.col철근시험인장값.OptionsColumn.AllowFocus = false;
            this.col철근시험인장값.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col철근시험인장값.OptionsColumn.ReadOnly = true;
            this.col철근시험인장값.Visible = true;
            this.col철근시험인장값.VisibleIndex = 14;
            this.col철근시험인장값.Width = 70;
            // 
            // col철근시험신율값
            // 
            this.col철근시험신율값.AppearanceCell.Options.UseTextOptions = true;
            this.col철근시험신율값.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col철근시험신율값.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col철근시험신율값.AppearanceHeader.Options.UseTextOptions = true;
            this.col철근시험신율값.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col철근시험신율값.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col철근시험신율값.Caption = "신율값";
            this.col철근시험신율값.FieldName = "철근시험신율값";
            this.col철근시험신율값.Name = "col철근시험신율값";
            this.col철근시험신율값.OptionsColumn.AllowEdit = false;
            this.col철근시험신율값.OptionsColumn.AllowFocus = false;
            this.col철근시험신율값.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col철근시험신율값.OptionsColumn.ReadOnly = true;
            this.col철근시험신율값.Visible = true;
            this.col철근시험신율값.VisibleIndex = 15;
            this.col철근시험신율값.Width = 70;
            // 
            // col철근검사단중
            // 
            this.col철근검사단중.AppearanceCell.Options.UseTextOptions = true;
            this.col철근검사단중.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col철근검사단중.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col철근검사단중.AppearanceHeader.Options.UseTextOptions = true;
            this.col철근검사단중.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col철근검사단중.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.col철근검사단중.Caption = "단중";
            this.col철근검사단중.FieldName = "철근검사단중";
            this.col철근검사단중.Name = "col철근검사단중";
            this.col철근검사단중.OptionsColumn.AllowEdit = false;
            this.col철근검사단중.OptionsColumn.AllowFocus = false;
            this.col철근검사단중.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.col철근검사단중.OptionsColumn.ReadOnly = true;
            this.col철근검사단중.Visible = true;
            this.col철근검사단중.VisibleIndex = 16;
            this.col철근검사단중.Width = 70;
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 776);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "제품 분석 도우미  -  Ver 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.성분및기계적성질비교BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraBars.BarEditItem barEditItem4;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraBars.BarEditItem barEditItem5;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox4;
        private DevExpress.XtraBars.BarEditItem barEditItem6;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox6;
        private System.Windows.Forms.BindingSource 성분및기계적성질비교BindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colHeatNO;
        private DevExpress.XtraGrid.Columns.GridColumn col강종;
        private DevExpress.XtraGrid.Columns.GridColumn col호칭;
        private DevExpress.XtraGrid.Columns.GridColumn col검사구분압연NO;
        private DevExpress.XtraGrid.Columns.GridColumn col화학성분_C;
        private DevExpress.XtraGrid.Columns.GridColumn col화학성분_Si;
        private DevExpress.XtraGrid.Columns.GridColumn col화학성분_Mn;
        private DevExpress.XtraGrid.Columns.GridColumn col화학성분_P;
        private DevExpress.XtraGrid.Columns.GridColumn col화학성분_S;
        private DevExpress.XtraGrid.Columns.GridColumn col화학성분_Cu;
        private DevExpress.XtraGrid.Columns.GridColumn col화학성분_Cr;
        private DevExpress.XtraGrid.Columns.GridColumn col화학성분_Ni;
        private DevExpress.XtraGrid.Columns.GridColumn col화학성분_V;
        private DevExpress.XtraGrid.Columns.GridColumn col화학성분_CEQ;
        private DevExpress.XtraGrid.Columns.GridColumn col철근시험항복값;
        private DevExpress.XtraGrid.Columns.GridColumn col철근시험인장값;
        private DevExpress.XtraGrid.Columns.GridColumn col철근시험신율값;
        private DevExpress.XtraGrid.Columns.GridColumn col철근검사단중;
    }
}

