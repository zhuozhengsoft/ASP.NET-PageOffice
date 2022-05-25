using System;

public partial class CreateWord_SaveFile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOffice.FileSaver fs = new PageOffice.FileSaver();
        fs.SaveToFile(Server.MapPath("doc/") + fs.FileName);
        fs.Close();
    }
}
