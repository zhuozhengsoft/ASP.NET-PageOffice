<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Excel1.aspx.cs" Inherits="InsertSeal_Excel_AddSeal1_Excel1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>1.常规盖章。</title>
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
            document.getElementById("PageOfficeCtrl1").Alert("文件保存成功。");
        }

        function InsertSeal() {
            try {
                document.getElementById("PageOfficeCtrl1").ZoomSeal.AddSeal();
            } catch (e) { }
        }

        function DeleteSeal() {
            var iCount = document.getElementById("PageOfficeCtrl1").ZoomSeal.Count;//获取当前文档中加盖的印章数量
            alert(iCount);
            if (iCount > 0) {
                document.getElementById("PageOfficeCtrl1").ZoomSeal.Item(iCount - 1).DeleteSeal();//删除最后一个印章，Item 参数下标从 0 开始
                alert("成功删除了最新加盖的印章。");
            } else {
                alert("请先在文档中加盖印章后，再执行删除操作。");
            }
        }

        function VerifySeal() {
            document.getElementById("PageOfficeCtrl1").ZoomSeal.VerifySeal();
        }

        function ChangePsw() {
            document.getElementById("PageOfficeCtrl1").ZoomSeal.ShowSettingsBox();
        }
    </script>
    <form id="form1" runat="server">
        <div style="width: auto; height: 700px;">
           <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
        </div>
    </form>
</body>
</html>
