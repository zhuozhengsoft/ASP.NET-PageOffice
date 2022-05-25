using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InsertSeal_Excel_AddSign2_SaveFile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOffice.FileSaver fs = new PageOffice.FileSaver();
        fs.SaveToFile(Server.MapPath("./") + fs.FileName);
        fs.Close();
    }
}