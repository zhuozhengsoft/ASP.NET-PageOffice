﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="PageOffice, Version=5.0.0.1, Culture=neutral, PublicKeyToken=1d75ee5788809228"
    Namespace="PageOffice" TagPrefix="po" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        count = 0;
        //显示进度条
        window.myFunc = function() {
            count++;
            if (count < 10) {
                //子页面刷新：方法一
                //document.frames["iframe1"].window.location.href = document.frames["iframe1"].window.location.href;
                //子页面刷新：方法二（可传参）
                document.getElementById("iframe1").src = "FileMaker.aspx?id=" + count;

                //设置进度条
                document.getElementById("ProgressBarSide").style.visibility = "visible";
                document.getElementById("ProgressBar").style.width = count + "0%";
                //                document.body.insertBefore(document.getElementById("ProgressBarSide"), document.body.childNode[0];
            } else {
                //隐藏进度条div
                document.getElementById("ProgressBarSide").style.visibility = "hidden";
                count = 0;
                //重置进度条
                document.getElementById("ProgressBar").style.width = "0%";
                document.getElementById("aDiv").style.display = "";
                //alert('批量转换完毕！');
            }
        };

        //开始转换文档
        function ConvertFiles() {
            //第一次让子页面自刷新
            document.getElementById("iframe1").src = "FileMaker.aspx?id=" + count;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <!--显示进度条-->
    <div id="ProgressBarSide" style="color: Silver; width: 200px; visibility: hidden;
        position: absolute; text-align: center; left: 40%; top: 50%; margin-top: -32px">
        <span style="color: gray; font-size: 12px; text-align: center;">正在转换请稍候...</span><br />
        <div id="ProgressBar" style="background-color: Green; height: 16px; width: 0%; border-width: 1px;
            border-style: Solid;">
        </div>
    </div>
    <div style="text-align: center;">
        <br />
        <span style="color: Red; font-size: 12px;">演示：把数据填充到模板中批量生成10个正式的word文件，请点下面的按钮进行转换</span><br />
        <input id="Button1" type="button" value="批量转换Word文件" onclick="ConvertFiles()" />
        <div id="aDiv" style="display: none; color: Red; font-size: 12px;">
            <span>转换完成，可在下面的地址中打开文件名为“maker0.doc”到“maker9.doc”的Word文件，查看转换的效果：<%=url %></span>
        </div>
    </div>
    <div style="width: 1px; height: 1px; overflow: hidden;">
        <iframe id="iframe1" name="iframe1" src=""></iframe>
    </div>
    </form>
</body>
</html>
