<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FileMakerSingle.aspx.cs"
    Inherits="FileMakerSingle_FileMakerSingle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--**************   卓正 PageOffice 客户端代码开始    ************************-->
            <script type="text/javascript">
                function OnProgressComplete() {
                    var type =<%=Request.QueryString["type"]%> ;
                    window.external.CallParentFunc("myFunc(" + type + ");"); //调用父页面的js函数
                    window.external.close();//关闭POBrwoser窗口
                }
            </script>
            <!--**************   卓正 PageOffice 客户端代码结束    ************************-->
            <%=FileMakerCtrl1.GetHtmlCode("FileMakerCtrl1")%>
        </div>
    </form>
</body>
</html>
