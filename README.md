# ASP.NET-PageOffice
### 一、简介

​      ASP.NET-PageOffice项目演示了在ASP.NET框架下如何使用PageOffice产品，此项目演示了PageOffice产品近90%的功能，是一个demo项目。

### 二、项目环境要求

​    Visual Studio2019 及以上版本

### 三、项目运行步骤

1. 使用git clone或者直接下载项目压缩包到本地并解压缩。
2. 双击运行ASP.NET-PageOffice目录下的Samples5.sln，并对Bin/PageOffice.dll添加引用，然后运行示例并访问index.html页面看示例效果。

### 四、PageOffice序列号

​     PageOfficeV5.0标准版试用序列号：I2BFU-MQ89-M4ZZ-ZWY7K           
​     PageOfficeV5.0专业版试用序列号：DJMTF-HYK4-BDQ3-2MBUC

### 五、集成PageOffice到您的项目中的关键步骤

1. 拷贝“ASP.NET-PageOffice/Bin”目录下的“PageOffice.dll”文件夹到您自己网站的Bin目录下,并对该dll添加引用； 
2. 在当前项目的web.config中<handlers>标签中配置如下代码(详细代码请参考ASP.NET-PageOffice/web.config)：

```xml
<add name="poserver" path="poserver.aspx" verb="*" type="PageOffice.POServer.ServerHandler"/>
<add name="posetup" path="posetup.exe" verb="GET" type="PageOffice.POServer.ServerHandler"/>
 <add name="sealsetup" path="sealsetup.exe" verb="GET" type="PageOffice.POServer.ServerHandler"/>
 <add name="pageoffice" path="pageoffice.js" verb="GET"  type="PageOffice.POServer.ServerHandler"/>
 <add name="pobstyle" path="pobstyle.css"  verb="GET"    type="PageOffice.POServer.ServerHandler"/>
<add name="adminseal" path="adminseal.aspx" verb="*" type="PageOffice.POServer.AdminSealHandler"/>
<add name="loginseal" path="loginseal.aspx" verb="*"  type="PageOffice.POServer.AdminSealHandler"/>
```
3. 对PageOffice编程控制：

   (1) 后台代码(详细代码请参考ASP.NET-PageOffice/SimpleWord /Word.aspx.cs文件)：

```c#
public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        // 设置PageOffice组件服务页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        //添加自定义按钮
        PageOfficeCtrl1.AddCustomToolButton("保存", "Save()", 1);
        PageOfficeCtrl1.AddCustomToolButton("打印", "PrintFile()", 6);
        PageOfficeCtrl1.AddCustomToolButton("全屏/还原", "IsFullScreen()", 4);
        PageOfficeCtrl1.AddCustomToolButton("关闭", "Close", 21);
        // 设置保存文件页面
        PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx";
        // 打开文档
        PageOfficeCtrl1.WebOpen("doc/test.doc", PageOffice.OpenModeType.docNormalEdit, "Tom");

```
  (2) 前台页面代码：(详细代码请参考ASP.NET-PageOffice//SimpleWord/Word.aspx文件)：

```C#
<%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
```

4. 如果使用 PageOffice 的 POBrowser 方式打开文件， 那么调用 javascript 方法

“POBrowser.openWindowModeless”的页面一定要引用下面的 js 文件：

`<script type="text/javascript" src="/pageoffice.js"></script>`

> 【注意】：pageoffice.js 文件的位置在第 2 步web.config文件中已经设置好了，
>
> 所以直接引用这个 js 即可，无需拷贝 pageoffice.js 文件到自己的Web项目目录下。


### 六、电子印章功能说明

如果您用到电子印章功能，请按以下步骤集成

1. 拷贝“ASP.NET-PageOffice/Bin”文件夹中的x86,x64文件夹和System.Data.SQLite.dll文件到您项目的Bin目录下，并对System.Data.SQLite.dll文件添加引用。
2. 拷贝“ASP.NET-PageOffice/Bin”夹中的poseal.db文件到您项目的App_Data目录下
3. 为了电子印章简易管理平台的安全性，强烈建议修改电子印章管理平台的登录密码， 打开当前项目的web.config文件，在<configSections>标签中添加如下代码：

```xml
<!-- 修改简易平台的登录密码，默认密码是111111-->
	<appSettings >
		<add key="adminseal-password" value="111111"></add>
	</appSettings>
```

4. 访问项目根目录下/loginseal.aspx登录此项目的电子印章简易管理平台(例如：<http://localhost:3306/loginseal.aspx>)，进行添加和删除印章。
5. 具体的盖章代码请参考ASP.NET-PageOffice/InsertSeal中的示例代码。

### 七、 PageOffice开发帮助

​     1 .[JS API文档](http://www.zhuozhengsoft.com/help/js3/index.html)  

​     2 .[PageOffice从入门到精通](https://www.kancloud.cn/pageoffice_course_group/pageoffice_course/646953)

​     技术支持：http://www.zhuozhengsoft.com/Technical/

### 八、联系我们

​   卓正官网：[http://www.zhuozhengsoft.com](http://www.zhuozhengsoft.com)

​   联系电话：400-6600-770  

   QQ: 800038353
