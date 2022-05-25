<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SendParameters.aspx.cs" Inherits="SendParameters_SendParameters" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function Save() {
            document.getElementById("PageOfficeCtrl1").WebSave();
        }

        function SetFullScreen() {
            document.getElementById("PageOfficeCtrl1").FullScreen = !document.getElementById("PageOfficeCtrl1").FullScreen;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-size: 14px;">
    <div style="border:1px solid black;">PageOffice给保存页面传值的三种方式：<br/>
          <span>1.通过设置保存页面的url中的?给保存页面传递参数：</span><br/>
          <span>2.通过input隐藏域给保存页面传递参数：</span><br/>  
          <span>3.通过Form控件给保存页面传递参数(这里的Form控件包括输入框、下拉框、单选框、复选框、TextArea等类型的控件)：</span><br/>
                
    </div>
        <span style="color: Red;">更新人员信息：</span><br />
        <input id="age" name="age" type="hidden" value="25" />
        <span style="color: Red;">姓名：</span><input id="userName" name="userName" type="text" value="张三" /><br />
        <span style="color: Red;">性别：</span><select id="selSex" name="selSex">
            <option value="男">男</option>
            <option value="女">女</option>
        </select>
    </div>
    <!--PageOfficeCtrl控件-->
    <div style="width: auto; height: 700px;">
        <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
    </div>
    </form>
</body>
</html>
