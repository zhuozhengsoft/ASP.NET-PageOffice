<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PDF.aspx.cs" Inherits="POPDF_PDF" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>在线打开PDF文件</title>
</head>
<body style="overflow:hidden;">
    <!--**************   卓正 PageOffice 客户端代码开始    ************************-->
	<script type="text/javascript">	   
	    function PrintFile() {
            document.getElementById("PDFCtrl1").ShowDialog(4);
		}

	    function SwitchFullScreen() {
	        document.getElementById("PDFCtrl1").FullScreen = !document.getElementById("PDFCtrl1").FullScreen;
		}

	    function SwitchBKMK() {
	        document.getElementById("PDFCtrl1").BookmarksVisible = !document.getElementById("PDFCtrl1").BookmarksVisible;
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

	    function SetRotateRight() {
	        document.getElementById("PDFCtrl1").RotateRight();
		}

	    function SetRotateLeft() {
	        document.getElementById("PDFCtrl1").RotateLeft();
		}

	    function Close() {
	        window.external.close();
	    }
    </script>
    <!--**************   卓正 PageOffice 客户端代码结束    ************************-->
 <form id="form1" runat="server">
    <div id="content"  style="height:850px;width:1028px;overflow:hidden;">
       <%=PDFCtrl1.GetHtmlCode("PDFCtrl1")%>
    </div>
 </form>
</body>
</html>
