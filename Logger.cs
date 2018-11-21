using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kassa
{
    class Logger
    {
        private string pathToLog
        {
            get;
            set;
        }

        public void add(string record)
        {
            File.AppendAllText(pathToLog, "\n" + record);
        }

        public virtual void setPathToLog(string path)
        {
            pathToLog = path;
        }

        //Выводит файл лога в консоль
        public void showLog()
        {
            try
            {
                using (StreamReader sr = new StreamReader(pathToLog))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The log file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        //Возвращает все записи лога 
        public string[] getLog()
        {
            return File.ReadAllLines(pathToLog);
        }
    }
}
