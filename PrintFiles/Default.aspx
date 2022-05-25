﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="PageOffice, Version=5.0.0.1, Culture=neutral, PublicKeyToken=1d75ee5788809228"
    Namespace="PageOffice" TagPrefix="po" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        count = 1;
        //显示进度条
        window.myFunc = function() {
            if (count < 5) {
                //设置进度条
                document.getElementById("ProgressBarSide").style.visibility = "visible";
                document.getElementById("ProgressBar").style.width = (count) * 25 - 1 + "%";
                
                //加载文档打印页面（可传参）
                document.getElementById("iframe1").src = "Print.aspx?id=" + count;
                count++; 
            } else {
                //隐藏进度条div
                document.getElementById("ProgressBarSide").style.visibility = "hidden";
                count = 1;
                //重置进度条
                document.getElementById("ProgressBar").style.width = "0%";
                document.getElementById("aDiv").style.display = "";
                //alert('批量转换完毕！');
            }            
        };

        //开始转换文档
        function ConvertFiles() {
            myFunc();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <!--显示进度条-->
    <div id="ProgressBarSide" style="color: Silver; width: 200px; visibility: hidden;
        position: absolute; text-align: center; left: 40%; top: 50%; margin-top: -32px">
        <span style="color: gray; font-size: 12px; text-align: center;">正在生成并打印请稍候...</span><br />
        <div style=" border:solid 1px green;">
            <div id="ProgressBar" style="background-color: Green; height: 16px; width: 0%; border-width: 1px;
                border-style: Solid;">
            </div>
        </div>
    </div>
    <div style="text-align: center;">
        <br />
        <span style="color: Red; font-size: 12px;">演示：把数据填充到模板中批量生成4个正式的word文件并打印出来，请点下面的按钮查看效果</span><br />
        <input id="Button1" type="button" value="批量生成和打印Word文件" onclick="ConvertFiles()" />
        <div id="aDiv" style="display: none; color: Red; font-size: 12px;">
            <span>执行完毕，可在下面的地址中打开文件名为“maker1.doc”到“maker4.doc”的Word文件，查看生成的所有文件：<%=url %></span>
        </div>
    </div>
    <div style="width: 1px; height: 0px; overflow: hidden;">
        <iframe id="iframe1" name="iframe1" src=""></iframe>
    </div>
    </form>
</body>
</html>
