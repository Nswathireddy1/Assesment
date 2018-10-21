using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class FileStreamExample
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream(@"F:\ReadWrite\Demo3.txt", FileMode.OpenOrCreate);//creating file stream  
            f.WriteByte(65);//writing byte into stream  
            f.Close();//closing stream  
            //WriteForFile();
            ReadForFile();
            UpdateForFile();
            Console.ReadLine();
            void WriteForFile()
            {
                StreamWriter writer = new StreamWriter(@"F:\ReadWrite\Demo1.txt");
                writer.WriteLine("hello world how r u");

                writer.Close();
            }
            void ReadForFile()
            {
                StreamReader reader = new StreamReader(@"F:\ReadWrite\Demo1.txt");
                Console.WriteLine(reader.ReadToEnd());
                reader.Close();
            }
            void UpdateForFile()
            {
                StreamReader reader = new StreamReader(@"F:\ReadWrite\Demo1.txt");
                Console.WriteLine(reader.ReadToEnd());
                reader.Close();
            }
        }
    }
}
