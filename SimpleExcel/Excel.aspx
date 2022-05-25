<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Excel.aspx.cs" Inherits="SimpleExcel_Excel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
  <head>
    <title>最简单的打开保存Excel文件</title>
</head >
<body style="overflow:hidden" >
       <script type="text/javascript">
          function Save() {
              document.getElementById("PageOfficeCtrl1").WebSave();
           }

           function Close() {
               window.external.close();
           }
	</script>
<div  style="height:750px;width:auto;">
         <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
</div>
</body>
</html>
