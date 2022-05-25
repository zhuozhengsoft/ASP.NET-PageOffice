<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="PageOffice, Version=5.0.0.1, Culture=neutral, PublicKeyToken=1d75ee5788809228"
    Namespace="PageOffice" TagPrefix="po" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>动态生成Word</title>
    <!--pageoffice.js一定要引用--->
    <script type="text/javascript" src="../pageoffice.js"></script>
    <script type="text/javascript">
        function myFunc(type) {
            alert("文件生成成功！");
            document.getElementById("pgImg").style.display = "none";
            if ("1" == type) {
                //下载生成的pdf文件
                location.href = "DownWord.aspx";
            } else if ("2" == type) {
                //打开pdf文件
                POBrowser.openWindowModeless('OpenWord.aspx', 'width=1200px;height=800px;');
            }
        }
        function convert(type) {
            document.getElementById("pgImg").style.display = "block";
            POBrowser.openWindowModeless('FileMakerSingle.aspx?type=' + type, 'width=1px;height=1px;frame=no;');
        }
    </script>
</head>
<body style="text-align: center;">
    <a href="javascript:;" onclick="convert(1)">1.动态生成Word文件并下载文件</a><br>
    <br>
    <a href="javascript:;" onclick="convert(2)">2.动态生成Word文件并打开文件</a>
    <div id="pgImg" style="with: 100px; height: 100px; margin-top: 20px; display: none;">
        正在生成文件，请稍等：<img src="image/pg.gif">
    </div>
</body>
</html>
