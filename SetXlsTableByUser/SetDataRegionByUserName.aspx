﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SetDataRegionByUserName.aspx.cs" Inherits="SetXlsTableByUser_SetDataRegionByUserName" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="images/csstg.css" rel="stylesheet" type="text/css" />
</head>
<body>   
    <br />
    <div id="content">
        <div id="textcontent" style="width: 1000px; height: 800px;">
            <div class="flow4">
                <a href="Default.aspx">返回登录页</a>
                    <span style="width: 100px;"> </span><strong>当前用户：</strong>
					<span style="color: Red;">
                        <asp:Literal ID="Literal1" runat="server"></asp:Literal></span>
            </div>
            <br />
            <script type="text/javascript">
                //保存页面
                function Save() {
                    document.getElementById("PageOfficeCtrl1").WebSave();
                }
            </script>
            <!--**************   卓正 PageOffice组件 ************************-->
             <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
        </div>
    </div>
    <div id="footer">
        <hr width="1000" />
        <div>
            Copyright (c) 2012 北京卓正志远软件有限公司</div>
    </div>
</body>
</html>

