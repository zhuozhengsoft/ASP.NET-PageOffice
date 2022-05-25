<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Convert.aspx.cs" Inherits="FileMakerConvertPDFs_Convert" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script language="javascript" type="text/javascript">
	         function OnProgressComplete() {
		            window.parent.convert(); //调用父页面的js函数
	        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
         <div>
             <%=FileMakerCtrl1.GetHtmlCode("FileMakerCtrl1")%> 
        </div>
    </form>
</body>
</html>
