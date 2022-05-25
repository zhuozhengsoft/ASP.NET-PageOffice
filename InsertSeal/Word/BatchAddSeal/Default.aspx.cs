using System;

public partial class InsertSeal_Word_BatchAddSeal_Default : System.Web.UI.Page
{
    public String url = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        url = Server.MapPath("doc/");
    }
}