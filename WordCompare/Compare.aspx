<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Compare.aspx.cs" Inherits="WordCompare_Compare" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Word文档比较</title>
    <script language="javascript" type="text/javascript">
// <!CDATA[
        function ShowFile1View() {
            document.getElementById("PageOfficeCtrl1").Document.ActiveWindow.View.ShowRevisionsAndComments = false;
            document.getElementById("PageOfficeCtrl1").Document.ActiveWindow.View.RevisionsView = 1;
        }

        function ShowFile2View() {
            document.getElementById("PageOfficeCtrl1").Document.ActiveWindow.View.ShowRevisionsAndComments = false;
            document.getElementById("PageOfficeCtrl1").Document.ActiveWindow.View.RevisionsView = 0;
        }

        function ShowCompareView() {
            document.getElementById("PageOfficeCtrl1").Document.ActiveWindow.View.ShowRevisionsAndComments = true;
            document.getElementById("PageOfficeCtrl1").Document.ActiveWindow.View.RevisionsView = 0;
        }

        function SetFullScreen() {
            document.getElementById("PageOfficeCtrl1").FullScreen = !document.getElementById("PageOfficeCtrl1").FullScreen;
        }
// ]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style=" width:1000px; height:700px;">
       <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    <div id="mmm">fdf</div>
    </form>
</body>
</html>
