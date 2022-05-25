<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Excel4.aspx.cs" Inherits="InsertSeal_Excel_AddSeal4_Excel4" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>4.特殊盖章需求实现：盖章后印章不保护文档内容，用户仍可编辑修改，印章不会出现失效字样。</title>
</head>
<body>
    <div style="font-size: 12px; line-height: 20px; border-bottom: dotted 1px #ccc; border-top: dotted 1px #ccc; padding: 5px;">
        <span style="color: red;">操作说明：</span>点“加盖印章”按钮即可，插入印章时的用户名为：李志，密码默认为：111111。
			<br />
        关键代码：点右键，选择“查看源文件”，看js函数
			<span style="background-color: Yellow;">InsertSeal()</span>
    </div>
    <br />
    <script type="text/javascript">
        function Save() {
            document.getElementById("PageOfficeCtrl1").WebSave();
        }

        function InsertSeal() {
            try {
                document.getElementById("PageOfficeCtrl1").ZoomSeal.AddSeal("", "");//第二个参数为空字符串时，盖完章的文档是不受保护的，即盖完章后还可以进行编辑等操作；第二个参数为null时，盖完章的文档是受保护的，即盖完章后不能再进行编辑等操作。 
            } catch (e) { }
        }

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
