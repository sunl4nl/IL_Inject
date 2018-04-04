using log4net.Config;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LogHelper  {
    //4-1，log4net配置文件的路径

    //    private static string _fileName =
    //#if UNITY_ANDROID
    //        "Config/log4net";
    //#elif UNITY_STANDALONE_WIN
    // Application.dataPath + "Assets/log4net/log4net.xml";
    //#endif

    public static void Init()
    {

        XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo("Assets/log4net/log4net.xml"));
    }

    public static StringWriter sw = new StringWriter();
    public static void WriteLog(Type t, string msg)
    {
        sw.WriteLine("");
        sw.WriteLine(msg);
        sw.WriteLine("");

        log4net.ILog log = log4net.LogManager.GetLogger(t);
        log.Info(msg);
    }

    public static void Save()
    {
        File.WriteAllText("C:/Gidea/Gidea-MT-Client/LibProjects/NodeCanvasAI/nodecanvas_unity.log", sw.ToString());
    }


}
