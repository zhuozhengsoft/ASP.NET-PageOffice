<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word6.aspx.cs" Inherits="InsertSeal_Word_AddSeal6_Word6" %>

<!DOCTYPE html>
<html>
	<head>
		<title>6.无需用户名、密码加盖印章到模板中的指定位置</title>
		<meta http-equiv="pragma" content="no-cache">
		<meta http-equiv="cache-control" content="no-cache">
		<meta http-equiv="expires" content="0">
		<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
		<meta http-equiv="description" content="This is my page">
	</head>
	<body>
		<br />
			<script type="text/javascript">
			    function AddSealByPos() {
			        try {
			            document.getElementById("PageOfficeCtrl1").ZoomSeal.LocateSealPosition("Seal1");
			            /**第一个参数，可选项，签章的用户名，为空字符串时，将弹出用户名密+密码框，如果为指定的签章用户名，则直接弹出印章选择框；
					     * 第二个参数，可选项，标识是否保护文档，为null时保护文档，为空字符串时不保护文档;
				  	     * 第三个参数，可选项，标识盖章指定位置名称，须为英文或数字，不区分大小写。
					     */
			            var bRet = document.getElementById("PageOfficeCtrl1").ZoomSeal.AddSeal("李志", null, "Seal1"); //位置名称不区分大小写
			        } catch (e) { };

			    }
			    function Save() {
			        document.getElementById("PageOfficeCtrl1").WebSave();
			    }
			</script>
	 <form id="form1" runat="server">
       <div style="width:auto; height: 700px;" >
         <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
       </div>
    </form>
	</body>

</html>
