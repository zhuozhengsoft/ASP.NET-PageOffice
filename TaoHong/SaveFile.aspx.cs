using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SaveFile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string fileName = Request.QueryString["fileName"];
        PageOffice.FileSaver fs = new PageOffice.FileSaver();
        fs.SaveToFile(Server.MapPath("doc/") + fileName);
        fs.Close();
    }
}
