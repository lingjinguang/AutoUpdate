项目来源：https://github.com/Hello-Mango/MAutoUpdate

使用：

AutoUpdate项目：编译之后，需要把Debug下的文件复制到“IMCISPlugin\IMCISAssistTool\bin\Debug”路径下。

Server.xml：文件需要放到服务器上，存储最新版本的信息。

Local.xml 文件：存储本地版本信息，在升级之后LocalVersion、LastUdpate会被更新成server.xml相应的设置，

​							 ServerUpdateUrl：“Server.xml”的地址。（Server版本号比Local大才会进行升级）





