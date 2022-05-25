﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word10.aspx.cs" Inherits="InsertSeal_Word_AddSeal10_Word10" %>

<!DOCTYPE html>
<html>
	<head>
		<title>	11.加盖骑缝章</title>
		<meta http-equiv="pragma" content="no-cache">
		<meta http-equiv="cache-control" content="no-cache">
		<meta http-equiv="expires" content="0">
		<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
		<meta http-equiv="description" content="This is my page">
	</head>
	<body>
		<div style="font-size: 12px; line-height: 20px; border-bottom: dotted 1px #ccc; border-top: dotted 1px #ccc; padding: 5px;">
			<span style="color: red;">操作说明：</span>点“加盖骑缝章”按钮即可，插入印章时的用户名为：李志，密码默认为：111111。
			<br /> 关键代码：点右键，选择“查看源文件”，看js函数
			<span style="background-color: Yellow;">InsertSeal()</span>			
		</div>
		<br />
			<script type="text/javascript">
			    function Save() {
			        document.getElementById("PageOfficeCtrl1").WebSave();
			    }

			    function InsertSeal() {
			        try {
			            document.getElementById("PageOfficeCtrl1").ZoomSeal.AddSealQFZ();
			        } catch (e) { }
			    }

			    function DeleteAllSeal() {
			        var iCount = document.getElementById("PageOfficeCtrl1").ZoomSeal.Count;//获取加盖的印章数量
			        if (iCount > 0) {
			            for (var i = iCount - 1; i >= 0; i--) {
			                strTempSealName = document.getElementById("PageOfficeCtrl1").ZoomSeal.Item(i).SealName;//获取加盖的印章名称
			                document.getElementById("PageOfficeCtrl1").ZoomSeal.Item(i).DeleteSeal();//删除印章
			            }
			        } else {
			            alert("请先在文档中加盖印章后，再执行当前操作。");
			        }
			    }
			</script>
	 <form id="form1" runat="server">
       <div style="width:auto; height: 700px;" >
           <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
       </div>
    </form>
	</body>
</html>
