﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stream.aspx.cs" Inherits="Stream" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>打开保存数据库中的文件</title>

    <script type="text/javascript">
        function Save() {
            document.getElementById("PageOfficeCtrl1").WebSave();
            if (document.getElementById("PageOfficeCtrl1").CustomSaveResult != "error") {
                document.getElementById("PageOfficeCtrl1").Alert('保存成功！');
            }
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div style="width: auto; height: 700px;">
          <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </form>
</body>
</html>
