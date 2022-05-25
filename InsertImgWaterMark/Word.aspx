<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word.aspx.cs" Inherits="InsertImgWaterMark_Word" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
<title>JS给Word文件插入图片水印</title>
    <script type="text/javascript">
    function AfterDocumentOpened(){
        /**  
           *document.getElementById("PageOfficeCtrl1").SetWordWaterMarkImage( ImageURL, ImageWidth, IsWashout ); 
           *ImageURL  字符串类型，必选参数，图片的路径。
           *ImageWidth  整数类型，必选参数，图片的宽度（单位：厘米）。如果是0表示采用图片默认宽度。
           *IsWashout  布尔类型，必选参数，是否冲蚀。true：冲蚀，false：不冲蚀
           */
        document.getElementById("PageOfficeCtrl1").SetWordWaterMarkImage("doc/logo.jpg", 20, false);
        }     
    </script>  
</head>
<body>
   <form id="form1" runat="server">
    <div style=" width:auto; height:700px;">
        <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
    </div>
    </form>
</body>
</html>

