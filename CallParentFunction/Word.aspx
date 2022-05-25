<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word.aspx.cs" Inherits="CallParentFunction_Word" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <script type="text/javascript">
        function Close() {
            window.external.close();
        }
        function increaseCount(value) {
            var sResult = window.external.CallParentFunc("updateCount(" + value + ");");
			 if(sResult=='poerror:parentlost'){
		       alert('父页面关闭或跳转刷新了，导致父页面函数没有调用成功！');
		       return false;
		      }
            document.getElementById("PageOfficeCtrl1").Alert("现在父窗口Count的值为：" + sResult);
        }
        function increaseCountAndClose(value) {
            var sResult = window.external.CallParentFunc("updateCount(" + value + ");");
            if (sResult == 'poerror:parentlost') {
		       alert('父页面关闭或跳转刷新了，导致父页面函数没有调用成功！');
		      }
            window.external.close();
        }
    </script>
 
    <input type="button" value="设置父窗口Count的值加1" onclick="increaseCount(1);" />
	<input type="button" value="设置父窗口Count的值加5，并关闭窗口" onclick="increaseCountAndClose(5);" /><br />
    <div style=" width:auto; height:700px;">
          <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </form>
</body>
</html>
