# IL_Inject
使用Mono.Cecil实现IL代码注入

通过Inject IL代码修复代码错误： 修复Inject GetMax函数为Normal GetMax执行
public class Normal
{
    public static int GetMax(int a, int b)
    {
        Debug.LogFormat("a = {0}, b = {1}", a, b);
        return a > b ? a : b;
    }
}

[TestInject]
public class Inject
{
    public static int GetMax(int a, int b)
    {
        return a;
    }
}

要使用Mono.Cecil我们首先需要将其包含到我们的项目中，在Unity的安装目录（我的在C:\Program Files\Unity\Editor\Data\Managed供参考），
找到对应的程序集文件，将Mono.Cecil.dll、Mono.Cecil.Mdb.dll、Mono.Cecil.Pdb.dll其放在Assets/Plugins/Cecil目录中。
你也可以选择其开源版本。

通过ILDasm.exe工具反编译我们项目自己的程序集文件得到，即反编译/Library/ScriptAssemblies/Assembly-CSharp.dll文件。
该工具在Windows SDK中能够找到
我用的是这个路径下的，供大家参考：
C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6 Tools\x64


