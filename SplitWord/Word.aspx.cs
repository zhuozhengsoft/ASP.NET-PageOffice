﻿using System;

public partial class SplitWord_Word : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        // 设置PageOffice组件服务页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        // 设置保存文件页面
        PageOffice.WordWriter.WordDocument wordDoc = new PageOffice.WordWriter.WordDocument();
        PageOfficeCtrl1.AddCustomToolButton("保存", "Save()", 1);
        PageOfficeCtrl1.CustomToolbar = true;
        //打开数据区域，openDataRegion方法的参数代表Word文档中的书签名称
        PageOffice.WordWriter.DataRegion dataRegion1 = wordDoc.OpenDataRegion("PO_test1");
        dataRegion1.SubmitAsFile = true;
        PageOffice.WordWriter.DataRegion dataRegion2 = wordDoc.OpenDataRegion("PO_test2");
        dataRegion2.SubmitAsFile = true;
        dataRegion2.Editing = true;
        PageOffice.WordWriter.DataRegion dataRegion3 = wordDoc.OpenDataRegion("PO_test3");
        dataRegion3.SubmitAsFile = true;

        PageOfficeCtrl1.SetWriter(wordDoc);
        PageOfficeCtrl1.SaveDataPage = "SaveData.aspx";
        // 打开文档
        PageOfficeCtrl1.WebOpen("doc/test.doc", PageOffice.OpenModeType.docSubmitForm, "Tom");
    }
}
