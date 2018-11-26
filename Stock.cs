using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kassa
{
    public class Stock
    {
        private Logger logger
        {
            get;
            set;
        }

        private string pathToData
        {
            get;
            set;
        }

        public Stock(string _pathToData, string _pathToLog)
        {
            logger = new Logger(_pathToLog);
            pathToData = _pathToData;

            if (!File.Exists(pathToData))
                File.Create(pathToData);

            addItems(123, "Тапочки", 10);
            addItems(456, "Туфли", 50);
            addItems(1000, "Пальто", 50);
            deleteItems(1000, 20);
        }

        //Добавление поступивших товаров в базу, если запись с введенным штрих кодом не существует, то создание новой с переданным именем
        public virtual void addItems(int barcode, string name, int quantity)
        {
            try
            {
                var lines = File.ReadAllLines(pathToData);

                for (int i = 0; i < lines.Count(); i++)
                {
                    if (lines[i].Contains(barcode.ToString()))
                    {
                        string[] subStrings = lines[i].Split(',');

                        int currentQuantity = Int32.Parse(subStrings[2]);

                        lines[i] = barcode.ToString() + "," + (name == "" ? subStrings[1] : name) + "," + (currentQuantity + quantity).ToString();

                        File.WriteAllLines(pathToData, lines);

                        logger.addLine(barcode.ToString() + "," + (name == "" ? subStrings[1] : name) + "," + quantity.ToString());

                        return;
                    }
                }

                File.AppendAllText(pathToData, barcode.ToString() + "," + name + "," + quantity.ToString() + "\n");

                logger.addLine(barcode.ToString() + "," + name + "," + quantity.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured:");
                Console.WriteLine(e.Message);
            }
        }

        //Удаление quantity количества товаров из базы
        public virtual void deleteItems(int barcode, int quantity)
        {
            try
            {
                var lines = File.ReadAllLines(pathToData);

                for (int i = 0; i < lines.Count(); i++)
                {
                    if (lines[i].Contains(barcode.ToString()))
                    {
                        string[] subStrings = lines[i].Split(',');

                        int currentQuantity = Int32.Parse(subStrings[2]);

                        if (currentQuantity - quantity > 0)
                        {
                            lines[i] = subStrings[0] + "," + subStrings[1] + "," + (currentQuantity - quantity).ToString();
                            logger.addLine(subStrings[0] + "," + subStrings[1] + ",-" + quantity.ToString());
                        }
                        else
                            return;
                    }
                }

                File.WriteAllLines(pathToData, lines);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured:");
                Console.WriteLine(e.Message);
            }
        }

        //Удаление записи о товаре полностью
        public virtual void deleteItemForever(int barcode)
        {
            try
            {
                var lines = File.ReadAllLines(pathToData);

                for (int i = 0; i < lines.Count(); i++)
                {
                    if (lines[i].Contains(barcode.ToString()))
                    {
                        lines = lines.Where((val, idx) => idx != i).ToArray();
                    }
                }

                File.WriteAllLines(pathToData, lines);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured:");
                Console.WriteLine(e.Message);
            }
        }

        //Удаление записи о товаре полностью
        public virtual void deleteItemForever(string name)
        {
            try
            {
                var lines = File.ReadAllLines(pathToData);

                for (int i = 0; i < lines.Count(); i++)
                {
                    if (lines[i].Contains(name))
                    {
                        lines = lines.Where((val, idx) => idx != i).ToArray();
                    }
                }

                File.WriteAllLines(pathToData, lines);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured:");
                Console.WriteLine(e.Message);
            }
        }

        //Возвращает все строки из файла с данными
        public string[] getCurrentStock()
        {
            return File.ReadAllLines(pathToData);
        }

        public virtual void setPathToData(string path)
        {
            pathToData = path;
        }

        public string[] getLog()
        {
            return logger.getLog();
        }

        public Logger getLoggerObj()
        {
            return logger;
        }
        
    }
}
