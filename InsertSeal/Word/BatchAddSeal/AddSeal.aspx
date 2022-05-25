<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddSeal.aspx.cs" Inherits="InsertSeal_Word_BatchAddSeal_AddSeal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script language="javascript" type="text/javascript">
         //标识盖章是否成功
         var isAddSealSuc = false;
         function AfterDocumentOpened() {
             try {
                 //先定位到印章位置,再在印章位置上盖章
                 document.getElementById("FileMakerCtrl1").ZoomSeal.LocateSealPosition("Seal1");
                 isAddSealSuc = document.getElementById("FileMakerCtrl1").ZoomSeal.AddSealByName("公司公章", null, "Seal1"); //位置名称不区分大小写
             } catch (e) { };

         }

         function OnProgressComplete() {
             window.parent.convert(isAddSealSuc); //调用父页面的js函数
         }
    </script>
</head>
<body>
    <form id="form1" runat="server">
      <%=FileMakerCtrl1.GetHtmlCode("FileMakerCtrl1")%>
    <div>    
    </div>
    </form>
</body>
</html>
