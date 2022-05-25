﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OpenPDF.aspx.cs" Inherits="SaveAsPDF_OpenPDF" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>打开PDF文件</title>
        <!--**************   卓正 PageOffice 客户端代码开始    ************************-->
	<script language="javascript" type="text/javascript">
	    function Print() {
	        //alert(document.getElementById("PDFCtrl1").Caption);//显示标题
	        document.getElementById("PDFCtrl1").ShowDialog(4);
		}

	    function SwitchFullScreen() {
	        document.getElementById("PDFCtrl1").FullScreen = !document.getElementById("PDFCtrl1").FullScreen;
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

	    function ZoomIn() {
	        document.getElementById("PDFCtrl1").ZoomIn();
		}

	    function ZoomOut() {
	        document.getElementById("PDFCtrl1").ZoomOut();
		}

	    function FirstPage() {
	        document.getElementById("PDFCtrl1").GoToFirstPage();
		}

	    function PreviousPage() {
	        document.getElementById("PDFCtrl1").GoToPreviousPage();
		}

	    function NextPage() {
	        document.getElementById("PDFCtrl1").GoToNextPage();
		}

	    function LastPage() {
	        document.getElementById("PDFCtrl1").GoToLastPage();
		}

	    function RotateRight() {
	        document.getElementById("PDFCtrl1").RotateRight();
		}

	    function RotateLeft() {
	        document.getElementById("PDFCtrl1").RotateLeft();
	    }
	</script>
    <!--**************   卓正 PageOffice 客户端代码结束    ************************-->
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: auto; height: 700px;">
        <%=PDFCtrl1.GetHtmlCode("PDFCtrl1")%>
    </div>
    </form>
</body>
</html>
