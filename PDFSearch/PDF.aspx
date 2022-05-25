﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PDF.aspx.cs" Inherits="PDFSearch_PDF" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PDF文档中的关键字搜索</title>
</head>
<body>
    <form id="form1" runat="server">
    <!--**************   卓正 PageOffice 客户端代码开始    ************************-->
	<script type="text/javascript">
	    function SearchText() {
	        document.getElementById("PDFCtrl1").SearchText();
		}

	    function SearchTextNext() {
	        document.getElementById("PDFCtrl1").SearchTextNext();
		}

	    function SearchTextPrev() {
	        document.getElementById("PDFCtrl1").SearchTextPrev();
	    }
	    
	    function SetPageReal() {
	        document.getElementById("PDFCtrl1").SetPageFit(1);
		}

	    function SetPageFit() {
	        document.getElementById("PDFCtrl1").SetPageFit(2);
		}

	    function SetPageWidth() {
	        document.getElementById("PDFCtrl1").SetPageFit(3);
	    }
	</script>
    <!--**************   卓正 PageOffice 客户端代码结束    ************************-->
    <div style="width:1000px; height:800px;">
         <%=PDFCtrl1.GetHtmlCode("PDFCtrl1")%>
    </div>
    </form>
</body>
</html>
