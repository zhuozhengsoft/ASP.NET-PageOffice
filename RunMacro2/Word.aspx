﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word.aspx.cs" Inherits="RunMacro2_Word" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>执行有返回值的宏命令</title>
    <script type="text/javascript">
// <!CDATA[
        function Button1_onclick() {
            var value = document.getElementById("PageOfficeCtrl1").RunMacro("myFunc1", document.getElementById("TextBox1").value);
            document.getElementById("PageOfficeCtrl1").Alert("myFunc1宏的返回值是：" + value);
        }
        
        function RunMacro2() {
            var value = document.getElementById("PageOfficeCtrl1").RunMacro("myFunc2", 'Function myFunc2() \r\n myFunc2 = "123" \r\n End Function');
            document.getElementById("PageOfficeCtrl1").Alert(value);
        }
// ]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-size: 12px; line-height: 20px; border-bottom: dotted 1px #ccc; border-top: dotted 1px #ccc;
        padding: 5px;">
        注意：<span style="background-color: Yellow;">执行“执行宏myFunc1”按钮之前需先设置好MS Word的关于执行宏命令的设置。
        <br />设置步骤如下：打开一个Word文档，点击“文件”→“选项”→“信任中心”→“信任中心设置”→“宏设置”→勾选上“信任对VBA工程对象模型的访问（V）”</span>
    </div>
    <asp:TextBox ID="TextBox1" runat="server" Height="87px" TextMode="MultiLine" Width="486px"></asp:TextBox>
    <input id="Button1" type="button" value="执行宏myFunc1" onclick="return Button1_onclick()" />
    <input id="Button2" type="button" value="执行宏myFunc2" onclick="RunMacro2();" />
    <div style="height: 800px;">
       <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </form>
</body>
</html>
