using System;
using System.IO;

namespace Seccao13
{
    class Program
    {
        static void Main(string[] args)
        {
            // O usu do @ se dá para que não seja necessário escrever duas barra. Ex: d:\\...
            string path = @"D:\Joao\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch(IOException e)
            {
                Console.WriteLine("An erro accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }                    
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
