using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kassa
{
    public class Logger
    {
        public Logger(string _pathToLog)
        {
            pathToLog = _pathToLog;

            if (!File.Exists(pathToLog))
                File.Create(pathToLog).Close();
        }

        private string pathToLog
        {
            get;
            set;
        }

        //Добавление записи в лог
        public void addLine(string record)
        {
            if (!record.All(s => (Char.IsLetterOrDigit(s) || s == ',' || s == '-')))
                return;

            File.AppendAllText(pathToLog, record + "\n");
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
            try
            {
                var res = File.ReadAllLines(pathToLog);
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine("The log file could not be read:");
                Console.WriteLine(e.Message);

                string[] res = { };
                return res;
            }
            
        }
    }
}
