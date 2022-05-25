<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word4.aspx.cs" Inherits="InsertSeal_Word_AddSign4_Word4" %>

<!DOCTYPE html>
<html>
	<head>
		<title>4.无需输入用户名、密码(手写)签字到模板中的指定位置（参考一、4示例在模板中添加签字位置）：</title>
		<meta http-equiv="pragma" content="no-cache">
		<meta http-equiv="cache-control" content="no-cache">
		<meta http-equiv="expires" content="0">
		<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
		<meta http-equiv="description" content="This is my page">
	</head>
	<body>
		<br />
		<script type="text/javascript">
			function Save() {
				document.getElementById("PageOfficeCtrl1").WebSave();
			}

			function AddHandSign() {
			    try {
                    //先定位到印章位置
				     document.getElementById("PageOfficeCtrl1").ZoomSeal.LocateSealPosition("Seal1");
				    /**第一个参数，可选项，签字的用户名，为空字符串时，将弹出用户名密+密码框，如果为指定的签章用户名，则直接弹出签字框；
					  * 第二个参数，可选项，标识是否保护文档，为null时保护文档，为空字符串时不保护文档;
					  * 第三个参数，可选项，标识盖章指定位置名称，须为英文或数字，不区分大小写。
					  */
					document.getElementById("PageOfficeCtrl1").ZoomSeal.AddHandSign("李志",null,"Seal1");
					} catch(e) {};
			}		
		</script>
	 <form id="form1" runat="server">
       <div style="width:auto; height: 700px;" >
       <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
       </div>
    </form>
	</body>

</html>
