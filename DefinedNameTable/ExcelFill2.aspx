<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExcelFill2.aspx.cs" Inherits="DefinedNameTable_ExcelFill2" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
	<head>
		<title>给Excel文档中定义名称的区域赋值</title>
		<meta http-equiv="pragma" content="no-cache">
		<meta http-equiv="cache-control" content="no-cache">
		<meta http-equiv="expires" content="0">
		<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
		<meta http-equiv="description" content="This is my page">
		<!--
	<link rel="stylesheet" type="text/css" href="styles.css">
	-->
	<script type="text/javascript">
        function Save() {
            document.getElementById("PageOfficeCtrl1").WebSave();
        }
    </script>
	</head>
	<body>
		<a href="Default.aspx">返回首页</a><br/>
		模板一填充数据后显示的效果
		<div style="width: 1000px; height: 800px;">
			       <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
		</div>
	</body>
</html>