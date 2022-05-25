﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word1.aspx.cs" Inherits="POBrowserTopic_Word1" %>

<!DOCTYPE html>
<html>
  <head>
   <title>PageOfficeLink方式最简单的打开编辑保存文档</title>
</head>
<body>
    <script type="text/javascript">
        function Save() {
            document.getElementById("PageOfficeCtrl1").WebSave();
        }

        function AfterDocumentOpened() {
            document.getElementById("Text1").value = document.getElementById("PageOfficeCtrl1").DataRegionList.GetDataRegionByName("PO_Title").Value;
        }

        function setTitleText() {
            document.getElementById("PageOfficeCtrl1").DataRegionList.GetDataRegionByName("PO_Title").Value = document.getElementById("Text1").value;
        }
    </script>
<p style=" text-indent:10px;" >
        PageOffice 4.0增加了全新的文件打开方式“POBrowser 方式”，此方式提供了更完美的浏览器兼容性解决方案。
        </p>
        <p style=" text-indent:10px;" >
            常规打开文档超链接的代码写法：&lt;a href=&quot;Word.aspx?id=12&quot;&gt;某某公司公文-12&lt;/a&gt;</p>
        <p style=" text-indent:10px;" >
            POBrowser打开文档超链接的代码写法：
       &lt;a href=&quot;<span style=" background-color:#D2E9FF;">javascript:POBrowser.openWindowModeless( &quot;</span>Word.aspx?id=12<span style=" background-color:#D2E9FF;">&quot;,&quot;width=800px;height=800px;&quot;)&gt;</span>
            某某公司公文-12&lt;/a&gt;
            &nbsp;</p>
	文档标题：<input id="Text1" type="text" size="50"      />
	<input type="button" value="修改" onclick="setTitleText();" />
    <form id="form1" runat="server" >
    <div style=" width:auto; height:700px;">
        <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
    </div>
    </form>
</body>
</html>