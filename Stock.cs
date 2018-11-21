using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kassa
{
    class Stock
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

        //Добавление поступивших товаров в базу, если запись с введенной комбинацией штрих кода и названия не существует, то создание новой
        public virtual void addItems(int barcode, string name, int quantity)
        {
            var lines = File.ReadAllLines(pathToData);

            for (int i = 0; i < lines.Count(); i++)
            {
                if (lines[i].Contains(name))
                {
                    string[] subStrings = lines[i].Split(',');

                    int currentQuantity = Int32.Parse(subStrings[2]);

                    lines[i] = "\n" + barcode.ToString() + "," + name + "," + (currentQuantity + quantity).ToString();

                    File.WriteAllLines(pathToData, lines);

                    logger.add(barcode.ToString() + "," + name + "," + quantity.ToString());

                    return;
                }
            }

            File.AppendAllText(pathToData, "\n" + barcode.ToString() + "," + name + "," + quantity.ToString());

            logger.add(barcode.ToString() + "," + name + "," + quantity.ToString());
        }

        public virtual void deleteItems(int barcode, int quantity)
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
                        logger.add(subStrings[0] + "," + subStrings[1] + ",-" + (currentQuantity - quantity).ToString());
                    }
                    else
                        return;
                }
            }

            File.WriteAllLines(pathToData, lines);


        }

        public virtual void deleteItemForever(int barcode)
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

        public virtual void deleteItemForever(string name)
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

        public virtual void setPathToData(string path)
        {
            pathToData = path;
        }
        
    }
}
