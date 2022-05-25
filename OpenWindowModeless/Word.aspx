<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word.aspx.cs" Inherits="OpenWindowModeless_Word" %>

<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>XX文档系统</title>
    <script type="text/javascript">
        function Save() {
             document.getElementById("PageOfficeCtrl1").WebSave();
             
        }

        function PrintFile(){
             document.getElementById("PageOfficeCtrl1").ShowDialog(4); 
             
        }

        function IsFullScreen(){
             document.getElementById("PageOfficeCtrl1").FullScreen = !document.getElementById("PageOfficeCtrl1").FullScreen;
             
        }

        function CloseFile(){
             window.external.close(); 
             
        }
    </script>
</head>
<body>
   <form id="form1" runat="server">
    <div style=" width:auto; height:700px;">
        <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
    </div>
    </form>
</body>
</html>

