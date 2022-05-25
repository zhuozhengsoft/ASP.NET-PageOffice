﻿using System;
using System.Drawing;
public partial class WordTableBorder_WordTableBorder : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOffice.WordWriter.WordDocument doc = new PageOffice.WordWriter.WordDocument();
        //获取Table所在的数据区域对象
        PageOffice.WordWriter.DataRegion dataRegion = doc.OpenDataRegion("PO_regTable");
        //打开table，OpenTable(index)方法中的index代表Word文档中table位置的索引，从1开始
        PageOffice.WordWriter.Table table = dataRegion.OpenTable(1);
        //给table中的单元格赋值， OpenCellRC(行, 列)
        table.OpenCellRC(3, 1).Value = "A公司";
        table.OpenCellRC(3, 2).Value = "开发部";
        table.OpenCellRC(3, 3).Value = "李清";
        //插入一空行，InsertRowAfter方法中的参数表示在哪个单元格下面插入一行
        table.InsertRowAfter(table.OpenCellRC(3, 3));

        table.OpenCellRC(4, 1).Value = "B公司";
        table.OpenCellRC(4, 2).Value = "销售部";
        table.OpenCellRC(4, 3).Value = "张三";

        //设置表格行的高度
        table.SetRowsHeight(30.5f);

        //设置表格的边框样式
        PageOffice.WordWriter.Border border = table.Border;
        // 设置边框的类型
        border.BorderType = PageOffice.WordWriter.WdBorderType.wdFullGrid;//包含内边框
        //设置边框的颜色
        border.LineColor = Color.Red;
        //设置边框的线条样式
        border.LineStyle = PageOffice.WordWriter.WdLineStyle.wdLineStyleDot;
        //设置边框的粗细
        border.LineWidth=PageOffice.WordWriter.WdLineWidth.wdLineWidth150pt;

        //设置表格字体样式
        PageOffice.WordWriter.Font font = dataRegion.Font;
        //设置字体的是否加粗
        font.Bold = true;
        //设置字体的颜色
        font.Color=Color.Blue;
        //设置字体是否为斜体
        font.Italic=true;
        //设置字体名称
        font.Name="宋体";
        //设置字体大小
        font.Size=15.5f;

        PageOfficeCtrl1.SetWriter(doc);
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PageOfficeCtrl1.WebOpen("doc/test.doc",PageOffice.OpenModeType.docNormalEdit,"张佚名");
    }
}
