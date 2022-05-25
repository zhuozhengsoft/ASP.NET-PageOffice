<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Excel3.aspx.cs" Inherits="InsertSeal_Excel_AddSign3_Excel3" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>3.特殊签字需求实现：签批后签字不保护文档内容，用户仍可编辑修改，签字不会出现失效字样。</title>
</head>
<body>
    <div style="font-size: 12px; line-height: 20px; border-bottom: dotted 1px #ccc; border-top: dotted 1px #ccc; padding: 5px;">
        <span style="color: red;">操作说明：</span>点“签字”按钮即可，插入印章时的用户名为：李志，密码默认为：111111。
			<br />
        关键代码：点右键，选择“查看源文件”，看js函数
			<span style="background-color: Yellow;">AddHandSign()</span>
    </div>
    <br />
    <br />
    <script type="text/javascript">
        //保存
        function Save() {
            document.getElementById("PageOfficeCtrl1").WebSave();
        }

        //签字
        function AddHandSign() {
            try {
                document.getElementById("PageOfficeCtrl1").ZoomSeal.AddHandSign("", "");//第二个参数为空字符串时，签完名的文档是不受保护的，即签完名后还可以进行编辑等操作；第二个参数为null时，签完名的文档是受保护的，即签完名后不能再进行编辑等操作。 
            } catch (e) { };
        }
        
        //验证印章
        function VerifySeal() {
            document.getElementById("PageOfficeCtrl1").ZoomSeal.VerifySeal();
        }
    </script>
    <form id="form1" runat="server">
        <div style="width: auto; height: 700px;">
            <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
        </div>
    </form>
</body>
</html>
