using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SampleService
{
    public partial class MyService1 : ServiceBase
    {
        public MyService1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            LogToFile("Service Started");
        }

        protected override void OnStop()
        {
            LogToFile("Service Stopped");
        }
        public void LogToFile(string data)
        {
            string path = @"D:\Data\d drive\Corp\RPS\CTS\CDE20ID004\Stage3Day1\Stahe3Day7\MyLog";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            string fileNameWithPath = path+@"\ServiceLog.txt";
            StreamWriter sw = null;
            if (!File.Exists(fileNameWithPath))
                sw = File.CreateText(fileNameWithPath);
            else
                sw = File.AppendText(fileNameWithPath);
            sw.WriteLine(data + " " + DateTime.Now);
        }
    }
}
