<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Excel2.aspx.cs" Inherits="InsertSeal_Excel_AddSeal2_Excel2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>2.无需输入用户名密码盖章。</title>
</head>
<body>
    <script type="text/javascript">
        function Save() {
            document.getElementById("PageOfficeCtrl1").WebSave();
        }

        function InsertSeal() {
            try {
                document.getElementById("PageOfficeCtrl1").ZoomSeal.AddSeal("李志");
            } catch (e) { }
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
