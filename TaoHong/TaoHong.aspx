<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TaoHong.aspx.cs" Inherits="TaoHong_TaoHong" %>

<!DOCTYPE html">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="images/csstg.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        //初始加载模板列表
        function MyLoad() {
            if ("<%=mb %>" != "")
                document.getElementById("templateName").value = "<%=mb %>";
        }
        //套红
        function taoHong() {
            //先保存正文，再合并文件
            document.getElementById("PageOfficeCtrl1").SaveFilePage = "SaveFile.aspx?fileName=test.doc";
            document.getElementById("PageOfficeCtrl1").WebSave();

            var mb = document.getElementById("templateName").value;
            document.getElementById("form1").action = "TaoHong.aspx?mb=" + mb;

            document.forms[0].submit();
        }

        //保存并关闭
        function saveAndClose() {
            document.getElementById("PageOfficeCtrl1").WebSave();
            window.external.close();
        }

        //全屏/还原
        function IsFullScreen() {
            document.getElementById("PageOfficeCtrl1").FullScreen = !document.getElementById("PageOfficeCtrl1").FullScreen;
        }
    </script>
</head>
<body onload="MyLoad()">
    <div id="header">
        <div style="float: left; margin-left: 20px;">
            <img src="images/logo.jpg" height="30" alt="" />
        </div>
        <ul>
            <li><a target="_blank" href="http://www.zhuozhengsoft.com">卓正网站</a> </li>
            <li><a target="_blank" href="http://www.zhuozhengsoft.com/poask/index.asp">客户问吧</a>
            </li>
            <li><a href="#">在线帮助</a> </li>
            <li><a target="_blank" href="http://www.zhuozhengsoft.com/contact-us.html">联系我们</a>
            </li>
        </ul>
    </div>
    <div id="content">
        <div id="textcontent" style="width: 1000px; height: 800px;">
            <div class="flow4">
                <form method="post" id="form1">
                <a href="#" onclick="window.external.close();">
                    <img alt="返回" src="images/return.gif" border="0" />文件列表</a> <span style="width: 100px;">
                          
                    </span><strong>文档主题：</strong> <span style="color: Red;">测试文件</span> <strong>模板列表：</strong>
                <span style="color: Red;">
                    <select name="templateName" id="templateName" style='width: 240px;'>
                        <option value='temp2008.doc' selected="selected">模板一 </option>
                        <option value='temp2009.doc'>模板二 </option>
                        <option value='temp2010.doc'>模板三 </option>
                    </select>
                </span>
                <span style="color: Red;"><input type="button" value="一键套红"onclick="taoHong()"/> </span>
                <span style="color: Red;">
                    <input type="button" value="保存关闭" onclick="saveAndClose()" />
                </span>
              </form>
            </div>
            <!--**************   卓正 PageOffice组件 ************************-->
            <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
        </div>
    </div>
    <div id="footer">
        <div>
            Copyright (c) 2012 北京卓正志远软件有限公司
        </div>
    </div>
</body>
</html>
