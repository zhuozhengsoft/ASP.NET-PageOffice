<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word.aspx.cs" Inherits="NoFrame_Word" %>

<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>XX文档系统</title>
<link rel="stylesheet" href="css/style.css"  type="text/css">
<style>
		#main{
			width:768px;
			height:887px;
			border:#83b3d9 2px solid;
			background:#f2f7fb;

		}
    #shut {
        width: 45px;
        height: 30px;
        float: right;
        margin-right: -1px;
    }
		#shut:hover{
		}
</style>
</head >
<body style="margin:0; padding:0;border:0px; overflow:hidden" >
       <script type="text/javascript">
          function SaveDocument() {
              document.getElementById("PageOfficeCtrl1").WebSave();
           }

          function PrintSet() {
             document.getElementById("PageOfficeCtrl1").ShowDialog(5); 
           }

	      function PrintFile() {
              document.getElementById("PageOfficeCtrl1").ShowDialog(4); 
           }

          function Close() {
            window.external.close();
          }

          function IsFullScreen() {
                document.getElementById("PageOfficeCtrl1").FullScreen = !document.getElementById("PageOfficeCtrl1").FullScreen;
          }

        //文档关闭前先提示用户是否保存
        function BeforeBrowserClosed(){
         if (document.getElementById("PageOfficeCtrl1").IsDirty){
                if(confirm("提示：文档已被修改，是否继续关闭放弃保存 ？"))
                {
                    return  true;                  
                }else{               
                    return  false;
                }	         	
            }
        }
	</script>
<div id="main">
	<div id="shut"><img src="../js/close.png"  onclick="Close()" title="关闭" /></div>
		<div id="content"  style="height:850px;width:768px;overflow-y:hidden;">
        <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
    </div> 
</div>
</body>
</html>

