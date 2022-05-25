<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PPT.aspx.cs" Inherits="SimplePPT_PPT" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
 <head>
</head >
<body style="margin:0; padding:0;border:0px; overflow:hidden" scroll="no">
       <script type="text/javascript">
           function SaveFile() {
              document.getElementById("PageOfficeCtrl1").WebSave();
           }

           function Close() {
               window.external.close();
           }
	    </script>
  <form id="form1" runat="server">
    <div style=" width:auto; height:700px;">
                <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </form>
    </div>
</body>
</html>
