using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System;
using System.Collections.Generic;

namespace ChiTonPrivateEnterpriseManagement.Classes.Modules
{
    /// <summary>
    /// Create a New INI file to store or load data
    /// </summary>
    public class IniFile
    {
        public string path;

        /// <summary>
        /// INIFile Constructor.
        /// </summary>
        /// <param name="INIPath"></param>
        public IniFile(string INIPath)
        {
            path = INIPath;
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal,
                                                          int size, string filePath);

        /// <summary>
        /// Write Data to the INI File
        /// </summary>
        /// <param name="Section"></param>
        /// Schedule name
        /// <param name="Schedule"></param>
        /// <param name="Key"></param>
        /// Key Name
        /// <param name="Value"></param>
        /// Value Name
        public void IniWriteValue(string Schedule, string Key, string Value)
        {
            WritePrivateProfileString(Schedule, Key, Value, path);
        }

        /// <summary>
        /// Read Data Value From the Ini File
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="Path"></param>
        /// <returns></returns>
        public string IniReadValue(string Section, string Key, string strDefault)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, strDefault, temp, 255, path);
            return temp.ToString();
        }

        public void IniDeleteOneSection(string Section, string directoryPath, string fileObjectpath)
        {
            StreamReader sr = File.OpenText(path);
            string lineinfile = null;
            List<string> fileConf = new List<string>();
            while ((lineinfile = sr.ReadLine()) != null)
            {
                fileConf.Add(lineinfile);
            }
            sr.Close();
            File.Delete(path);
            File.Delete(fileObjectpath);
            int indexFileConf = 0;
            for (int i = 0; i < fileConf.Count; i++)
            {
                if (fileConf[i].Equals("[" + Section + "]"))
                {
                    indexFileConf = i;
                    fileConf.RemoveAt(indexFileConf);
                    do
                    {
                        if (fileConf[indexFileConf].Contains("["))
                        {
                            indexFileConf = fileConf.Count;
                        }
                        else
                        {
                            fileConf.RemoveAt(indexFileConf);
                        }
                    }
                    while (indexFileConf < fileConf.Count);
                }
            }
            FileInfo file = new FileInfo(path);
            StreamWriter sw = file.CreateText();
            for (int i = 0; i < fileConf.Count; i++)
            {
                sw.WriteLine(fileConf[i]);
            }
            sw.Close();
        }
    }
}