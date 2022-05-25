<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word.aspx.cs" Inherits="WordResWord_Word" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>演示：PageOffice </title>
    <style type="text/css">
        html, body
        {
            height: 100%;
        }
        .main
        {
            height: 100%;
        }
    </style>
</head>
<body>
    <div style="font-size: 12px; line-height: 20px; border-bottom: dotted 1px #ccc; border-top: dotted 1px #ccc;
        padding: 5px;">
        关键代码：<span style="background-color: Yellow;"> <br />PageOffice.WordWriter.DataRegion dataRegion
            = worddoc.OpenDataRegion("PO_开头书签名称");
            <br />
            dataRegion.Value = "[word]doc/1.doc[/word]";</span><br />
    </div>
    <br />
    <form id="form1" runat="server" style="height: 100%;">
    <div class="main">
        <!--**************   PageOffice 客户端代码开始    ************************-->
         <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
        <!--**************   PageOffice 客户端代码结束    ************************-->
    </div>
    </form>
</body>
</html>
