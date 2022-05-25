<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word.aspx.cs" Inherits="SaveFirstPageAsImg_Word" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
<title>保存Word首页为图片</title>
<script type="text/javascript">
    function Save() {
        document.getElementById("PageOfficeCtrl1").WebSave();
        if (document.getElementById("PageOfficeCtrl1").CustomSaveResult == "ok") {
            document.getElementById("PageOfficeCtrl1").Alert("文档保存成功!");
        }
    }
    function SaveFirstAsImg() {
        document.getElementById("PageOfficeCtrl1").WebSaveAsImage();
        if (document.getElementById("PageOfficeCtrl1").CustomSaveResult == "ok") {
            document.getElementById("PageOfficeCtrl1").Alert("图片保存成功!");
            document.getElementById("img1").src = "images/test.jpg";
            document.getElementById("img1").style.width = "200px";
            document.getElementById("img1").style.height = "290px";
        }
    }
</script>
</head>
<body>
   <form id="form1" runat="server">
   <div><img id="img1" /></div>
    <div style=" width:auto; height:700px;">
        <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
    </div>
    </form>
</body>
</html>

