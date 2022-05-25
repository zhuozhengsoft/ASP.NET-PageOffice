<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word1.aspx.cs" Inherits="Simple_Word1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<script type="text/javascript">
           function SaveDocument() {
               document.getElementById("PageOfficeCtrl1").WebSave();
           }          
	</script>
	
</head>
<body>
    <div>打开服务器上指定磁盘路径下的文件</div>
    <form id="form1" runat="server">
    <asp:Literal ID="Literal_Info" runat="server"></asp:Literal>
    <div style=" width:auto; height:700px;" >
           <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </form>
</body>
</html>
