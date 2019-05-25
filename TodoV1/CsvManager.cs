using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TodoV1
{
    class CsvManager
    {
        public static void WriteCsv(string fileName, List<ToDo> content)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in content)
            {
                sb.AppendLine(item.ToString());
            }

            File.WriteAllText(
                Path.Combine(
                fileName),
                sb.ToString());

        }

        public static List<ToDo> ReadCsv(string fileName)
        {
            using (var reader = new StreamReader(File.OpenRead(fileName)))
            {
                List<ToDo> ls = new List<ToDo>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    ToDo.StatusType p = new ToDo.StatusType();
                    if (Convert.ToInt32(values[2]) == 0)
                        p = ToDo.StatusType.Open;
                    else if (Convert.ToInt32(values[2]) == 1)
                        p = ToDo.StatusType.Done;
                    var newObject = new ToDo
                    {
                        Serial = Convert.ToInt32(values[0]),
                        Name = values[1],
                        Status = p
                    };

                    ls.Add(newObject);

                }
                return ls;
            }

        }
    }
}