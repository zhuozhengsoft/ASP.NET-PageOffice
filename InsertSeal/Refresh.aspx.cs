using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InsertSeal_refresh : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)

    {
        //复制模板
        String filePath = Server.MapPath("./");
        System.IO.File.Copy(filePath +"Word/AddSeal1/word1_bak.doc ", filePath + "Word/AddSeal1/word1.doc ", true);
        System.IO.File.Copy(filePath + "Word/AddSeal2/word2_bak.doc ", filePath + "Word/AddSeal2/word2.doc ", true);
        System.IO.File.Copy(filePath + "Word/AddSeal3/word3_bak.doc ", filePath + "Word/AddSeal3/word3.doc ", true);
        System.IO.File.Copy(filePath + "Word/AddSeal4/word4_bak.doc ", filePath + "Word/AddSeal4/word4.doc ", true);
        System.IO.File.Copy(filePath + "Word/AddSeal5/test_bak.doc ", filePath + "Word/AddSeal5/test.doc ", true);
        System.IO.File.Copy(filePath + "Word/AddSeal6/test_bak.doc ", filePath + "Word/AddSeal6/test.doc ", true);
        System.IO.File.Copy(filePath + "Word/AddSeal7/test_bak.doc ", filePath + "Word/AddSeal7/test.doc ", true);
        System.IO.File.Copy(filePath + "Word/AddSeal8/word8_bak.doc ", filePath + "Word/AddSeal8/word8.doc ", true);
        System.IO.File.Copy(filePath + "Word/AddSeal9/word9_bak.doc ", filePath + "Word/AddSeal9/word9.doc ", true);

        System.IO.File.Copy(filePath + "Word/AddSign1/word1_bak.doc ", filePath + "Word/AddSign1/word1.doc ", true);
        System.IO.File.Copy(filePath + "Word/AddSign2/test_bak.doc ", filePath + "Word/AddSign2/test.doc ", true);
        System.IO.File.Copy(filePath + "Word/AddSign3/test_bak.doc ", filePath + "Word/AddSign3/test.doc ", true);
        System.IO.File.Copy(filePath + "Word/AddSign4/test_bak.doc ", filePath + "Word/AddSign4/test.doc ", true);
        System.IO.File.Copy(filePath + "Word/AddSign5/word2_bak.doc ", filePath + "Word/AddSign5/word2.doc ", true);

        System.IO.File.Copy(filePath + "PDF/AddSign1/test_bak.pdf ", filePath + "PDF/AddSeal1/test.pdf ", true);
        System.IO.File.Copy(filePath + "PDF/AddSign1/test_bak.pdf ", filePath + "PDF/AddSign1/test.pdf ", true);

        System.IO.File.Copy(filePath + "Word/BatchAddSeal/doc/bak/test1.doc ", filePath + "Word/BatchAddSeal/doc/test1.doc ", true);
        System.IO.File.Copy(filePath + "Word/BatchAddSeal/doc/bak/test2.doc ", filePath + "Word/BatchAddSeal/doc/test2.doc ", true);
        System.IO.File.Copy(filePath + "Word/BatchAddSeal/doc/bak/test3.doc", filePath + "Word/BatchAddSeal/doc/test3.doc ", true);
        System.IO.File.Copy(filePath + "Word/BatchAddSeal/doc/bak/test4.doc", filePath + "Word/BatchAddSeal/doc/test4.doc ", true);


        System.IO.File.Copy(filePath + "Excel/AddSeal1/test_bak.xls ", filePath + "Excel/AddSeal1/test.xls ", true);
        System.IO.File.Copy(filePath + "Excel/AddSeal2/test_bak.xls ", filePath + "Excel/AddSeal2/test.xls ", true);
        System.IO.File.Copy(filePath + "Excel/AddSeal3/test_bak.xls ", filePath + "Excel/AddSeal3/test.xls ", true);
        System.IO.File.Copy(filePath + "Excel/AddSeal4/test_bak.xls ", filePath + "Excel/AddSeal4/test.xls ", true);
        System.IO.File.Copy(filePath + "Excel/AddSeal5/test_bak.xls ", filePath + "Excel/AddSeal5/test.xls ", true);

        System.IO.File.Copy(filePath + "Excel/AddSign1/test_bak.xls ", filePath + "Excel/AddSign1/test.xls ", true);
        System.IO.File.Copy(filePath + "Excel/AddSign2/test_bak.xls ", filePath + "Excel/AddSign2/test.xls ", true);
        System.IO.File.Copy(filePath + "Excel/AddSign3/test_bak.xls ", filePath + "Excel/AddSign3/test.xls ", true);


    }
}