<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word8.aspx.cs" Inherits="InsertSeal_Word_AddSeal8_Word8" %>

<!DOCTYPE html>
<html>
	<head>
		<title>8.特殊需求盖章(盖章后仍可编辑、修改文件内容)</title>
		<meta http-equiv="pragma" content="no-cache">
		<meta http-equiv="cache-control" content="no-cache">
		<meta http-equiv="expires" content="0">
		<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
		<meta http-equiv="description" content="This is my page">
	</head>
	<body>
		<div style="font-size: 12px; line-height: 20px; border-bottom: dotted 1px #ccc; border-top: dotted 1px #ccc; padding: 5px;">
			<span style="color: red;">操作说明：</span>点“加盖印章”按钮即可，插入印章时的用户名为：李志，密码默认为：111111。
			<br /> 关键代码：点右键，选择“查看源文件”，看js函数
			<span style="background-color: Yellow;">InsertSeal()</span>
		
		</div>
		<br />
			<script type="text/javascript">
				function Save() {
					document.getElementById("PageOfficeCtrl1").WebSave();
					document.getElementById("PageOfficeCtrl1").Alert("文件保存成功。");
				}

				function InsertSeal() {
					try {
						document.getElementById("PageOfficeCtrl1").ZoomSeal.AddSeal("","");
					} catch(e) {}
				}

				function VerifySeal() {
					document.getElementById("PageOfficeCtrl1").ZoomSeal.VerifySeal();
				}

				function ChangePsw() {
					document.getElementById("PageOfficeCtrl1").ZoomSeal.ShowSettingsBox();
				}
			</script>
	 <form id="form1" runat="server">
       <div style="width:auto; height: 700px;" >
         <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
       </div>
    </form>
	</body>

</html>
