﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Excel.aspx.cs" Inherits="ExcelAdjustRC_Excel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Excel只读模式下调整行高和列宽</title>
</head>
<body>
    <script type="text/javascript">
            function Save() {
                document.getElementById("PageOfficeCtrl1").WebSave();
            }
    </script>
    <form id="form1" runat="server">
    <div>
      设置当工作表只读时，允许用户手动调整行列。</br>
      <div style="color:Red;">sheet1.AllowAdjustRC=true; </div>
    </div>
    <div style=" width:auto; height:700px;">
      <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </form>
</body>
</html>
