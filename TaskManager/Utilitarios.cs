using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaskManager
{
    internal static class Utilitarios
    {

        public static void ClearFileText(string pathFile)
        {
            File.WriteAllText(pathFile, "");
        }
        

        public static void SaveText(string pathFile, params string[] values)
        {

                StreamWriter sw = new StreamWriter(pathFile);
                for (int i = 0; i < values.Length; i++)
                {
                    sw.WriteLine(values[i]);
                }
                sw.Close();
 

        }

        public static string[] GetText(string filePath, int lines)
        {
            try
            {
                StreamReader sr = new StreamReader(filePath);
                List<string> list = new List<string>();

                for(int i = 0; i < lines; i++)
                {
                    string value;
                    value = sr.ReadLine();
                    list.Add(value);
                }
                sr.Close();
                return list.ToArray();
                
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static string GetLine(string filePath, int line)
        {
            try
            {

                string text = "";
                StreamReader sr = new StreamReader(filePath);

                for(int i = 0; i <= line; i++)
                {
                    if(i == line-1)
                    {
                        text = sr.ReadLine();
                    }
                    else
                    {
                        sr.ReadLine();
                    }
                }
                sr.Close();

                return text;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static void CreateTextFile(string name)
        {
            if (!File.Exists($"{name}.txt"))
            {
                File.Create($"{name}.txt");
            }
            
        }

        public static void CreateTextFile(string name, params string[] values)
        {
            if (!File.Exists($"{name}.txt"))
            {
                var file = File.Create($"{name}.txt");
                file.Close();
                SaveText($@"{name}.txt","root");
            }

        }

    }
}
