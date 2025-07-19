using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Invox.Common
{
    class LogWritter
    {
        public String appDirectory = System.IO.Path.GetTempPath();//AppDomain.CurrentDomain.BaseDirectory;
        public static String logFilePath = "";
        public bool writeLog(String section, String logText)
        {
            bool logStatus = false;
            String fileSize = "";
            try
            {
                if (!Directory.Exists(appDirectory + @"\InvoxAppLog"))
                {
                    System.IO.Directory.CreateDirectory(appDirectory + @"\InvoxAppLog");
                }
                logFilePath = appDirectory + @"\InvoxAppLog\appLog.log";

                if (File.Exists(logFilePath))
                {
                    fileSize = getFileSize(logFilePath);
                    string[] splitSize = fileSize.Split(',');

                    if (Double.Parse(splitSize[0].ToString()) >= 10 && splitSize[1].Equals("MB"))
                    {
                        File.Move(logFilePath, Path.Combine(Path.GetDirectoryName(logFilePath), Path.GetFileNameWithoutExtension(logFilePath) + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".log"));
                    }
                }
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ": " + section + ": " + logText);
                    logStatus = true;
                }
            }
            catch (Exception)
            {
                logStatus = false;
            }

            return logStatus;
        }
        static String getFileSize(String filePath)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = new FileInfo(filePath).Length;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }
            //string result = String.Format("{0:0.##} {1}", len, sizes[order]);
            string result = len + "," + sizes[order];
            return result;
        }
    }
}
