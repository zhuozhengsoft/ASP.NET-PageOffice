<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Excel.aspx.cs" Inherits="ImportExcelData_Excel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>导入Excel文件并提交数据</title>
    <script type="text/javascript">
        function importData() {
            document.getElementById("PageOfficeCtrl1").ExcelImportDialog();
        }

        function submitData() {
            document.getElementById("PageOfficeCtrl1").WebSave();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="color:Red">请导入“/Samples4/ImportExcelData”下的ImportExcel.xls文档查看演示效果。</div>
    <div style=" width:auto; height:600px;">
         <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
    </div>
    </form>
</body>
</html>
