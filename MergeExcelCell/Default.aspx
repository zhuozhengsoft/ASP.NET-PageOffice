<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="MergeExcelCell_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <title></title>
    <link href="images/csstg.css" rel="stylesheet" type="text/css" />
</head>
<body>  
    <br />   
    <br /><br />
    <div id="content">
        <div id="textcontent" style="width: 1000px; height: 800px;">
            <!--**************   ׿�� PageOffice��� ************************-->
             <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
        </div>
    </div>
    <div id="footer">
        <hr width="1000" />
        <div>
            Copyright (c) 2012 ����׿��־Զ������޹�˾</div>
    </div>
</body>
</html>
