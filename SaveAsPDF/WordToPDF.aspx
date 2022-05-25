﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WordToPDF.aspx.cs" Inherits="SaveAsPDF_WordToPDF" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Word文件转换成PDF格式</title>
    <script type="text/javascript">
        //保存
        function Save() {
            document.getElementById("PageOfficeCtrl1").WebSave();
        }

        //另存为PDF文件
        function SaveAsPDF() {
            document.getElementById("PageOfficeCtrl1").WebSaveAsPDF();          
            location.href="OpenPDF.aspx?fileName=<%=pdfName %>";
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style=" width:auto;height:700px;">
         <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
    </div>
    </form>
</body>
</html>
