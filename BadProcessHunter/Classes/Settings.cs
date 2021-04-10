using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BadProcessHunter.Classes
{
   [XmlRoot("Settings")]
   public class Settings
   {
       [XmlElement("ProcessName")]
       public string ProcessName;

       [XmlElement("Interval")] 
       public int Interval;

       [XmlElement("StartFile")]
       public bool StartFile;

       [XmlElement("StartFilePath")]
       public string StartFilePath;

       
       public Settings()
       {  
       }

       
       public Settings(string processName, int interval,bool startFile,string startFilePath)
       {
           ProcessName = processName;
           Interval = interval;
           StartFile = startFile;
           StartFilePath = startFilePath;
       }
   }
}
