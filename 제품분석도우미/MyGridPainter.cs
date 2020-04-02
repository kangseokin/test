// Developer Express Code Central Example:
// How to merge cells horizontally in GridView
// 
// This example demonstrates how to merge cells located in the same row. The main
// idea is to paint merged cell manually.
// You can find a helper class in this
// example, which can be easily connected to your existing GridView.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2472

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.ViewInfo;

namespace 제품분석도우미
{
    public class MyGridPainter : GridPainter
    {


        public MyGridPainter(GridView view)
            : base(view)
        {

        }

        private bool _IsCustomPainting;
        public bool IsCustomPainting
        {
            get { return _IsCustomPainting; }
            set { _IsCustomPainting = value; }
        }

        public void DrawMergedCell(MyMergedCell cell, PaintEventArgs e)
        {
            int delta = cell.Column1.VisibleIndex - cell.Column2.VisibleIndex;
            if (Math.Abs(delta)>1)
                return;
            GridViewInfo vi = View.GetViewInfo() as GridViewInfo;
            GridCellInfo gridCellInfo1 = vi.GetGridCellInfo(cell.RowHandle, cell.Column1);
            GridCellInfo gridCellInfo2 = vi.GetGridCellInfo(cell.RowHandle, cell.Column2);

            if (gridCellInfo1 != null && gridCellInfo2 == null) gridCellInfo2 = gridCellInfo1;
            if (gridCellInfo1 == null || gridCellInfo2 == null)
                return;
            Rectangle targetRect = Rectangle.Union(gridCellInfo1.Bounds, gridCellInfo2.Bounds);
            gridCellInfo1.Bounds = targetRect;
            gridCellInfo1.CellValueRect = targetRect;
            gridCellInfo2.Bounds = targetRect;
            gridCellInfo2.CellValueRect = targetRect;
            if (delta < 0)
                gridCellInfo1 = gridCellInfo2;
            if (gridCellInfo1.ViewInfo == null)
                return;
            int prevX = gridCellInfo1.Bounds.X;
            Rectangle bounds = gridCellInfo1.ViewInfo.Bounds;
            bounds.Width = targetRect.Width;
            bounds.Height = targetRect.Height;
            gridCellInfo1.ViewInfo.Bounds = bounds;
            gridCellInfo1.ViewInfo.CalcViewInfo(e.Graphics);
            IsCustomPainting = true;
            GraphicsCache cache = new GraphicsCache(e.Graphics);
            int width = gridCellInfo1.Bounds.Width;
            if (gridCellInfo1.Bounds.Right >= vi.View.GridControl.Width)
                width -= gridCellInfo1.Bounds.Right - vi.View.GridControl.Width + 2;

            int cellX = 0;
            int columnIndent = vi.ColumnsInfo[0].Type == GridColumnInfoType.Indicator ? vi.ColumnsInfo[0].Bounds.Right : vi.ColumnsInfo[0].Bounds.X;
            cellX = Math.Max(gridCellInfo1.Bounds.X, columnIndent);
            if (vi.View.OptionsView.ShowIndicator && gridCellInfo1.Bounds.X < vi.ViewRects.IndicatorWidth)
                width += gridCellInfo1.Bounds.X - vi.ViewRects.IndicatorWidth - 1;
            gridCellInfo1.Bounds = new Rectangle(cellX, gridCellInfo1.Bounds.Y, width, gridCellInfo1.Bounds.Height);

            gridCellInfo1.Appearance.FillRectangle(cache, gridCellInfo1.Bounds);
            gridCellInfo1.CellValueRect.Location = new Point(gridCellInfo1.CellValueRect.Location.X + gridCellInfo1.Bounds.X - prevX, gridCellInfo1.CellValueRect.Location.Y);
            DrawRowCell(new GridViewDrawArgs(cache, vi, vi.ViewRects.Bounds), gridCellInfo1);
            IsCustomPainting = false; ;
        }

    }
    
}
