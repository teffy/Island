# Island
unity3d学习项目，创建游戏世界，创建一个岛屿

这套代码基于Unity5.3.0f4,C#

课程来自：
[这里](http://www.51zxw.net/study.asp?vip=11885058)
4-10

如有错误，请指出，我会及时修改，谢谢。

遇到的问题：
* 1、天空盒，在上一个项目[Shot](https://github.com/teffy/Shot)中已经说过，5.x自带
* 2、树、水、草等资源包，5.x上在Environment中，也可以去AssetStore（Window->AssetStore）中去下载，我的项目中下载了几个用，都是免费的
* 3、角色控制器，这个5.x上还有，点击Assets->右键->import package->Characters,可以只选择需要的几个，我的项目中全部导入了
* 4、雾效果，5.x上和天空盒在一起，在Window->Light->Scene面板中，Fog就是雾的效果，另外我下载的资源中有天空的材质，可以修改一下默认的天空效果
* 5、碰撞器编辑方法如下图：
![edit box collider](/screenshot/edit_box_collider.png)
* 6、C#中 ref参数是引用，out参数为输出参数。例如：public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance);