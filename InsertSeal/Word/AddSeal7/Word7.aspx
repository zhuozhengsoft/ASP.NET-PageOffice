<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word7.aspx.cs" Inherits="InsertSeal_Word_AddSeal7_Word7" %>

<!DOCTYPE html>
<html>
	<head>
		<title>7.无需用户名、密码，并且无需印章选择框加盖印章到模板中的指定位置</title>
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

			    function AddSealByPos() {
			        try {
			            document.getElementById("PageOfficeCtrl1").ZoomSeal.LocateSealPosition("Seal1");
			            /**
                         *第一个参数，必填项，标识印章名称（当存在重名的印章时，默认选取第一个印章）；
                         *第二个参数，可选项，标识是否保护文档，为null时保护文档，为空字符串时不保护文档；
                         *第三个参数，可选项，标识盖章指定位置名称，须为英文或数字，不区分大小写
                         */	
			            var bRet = document.getElementById("PageOfficeCtrl1").ZoomSeal.AddSealByName("公司公章", null, "Seal1"); //位置名称不区分大小写
			            if(bRet){
			                alert("盖章成功！");
			            }else{
			                alert("盖章失败！");
			            }
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
