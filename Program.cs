using System;
using System.IO;
namespace csvreader
{
    class Program
    {
        static void Main(string[] args)
        {
           string filename = "values.csv";
           if (File.Exists(filename))
           {
            System.IO.StreamReader file = new System.IO.StreamReader("values.csv");
            int counter =0;
            string line;
            string[] headerline = null;
            while ((line = file.ReadLine())!= null)
            {
                string[] values = line.Split(',');
                if (counter!=0)
                {
                    //json format
                    Console.WriteLine("{");
                    Console.WriteLine("\t\"{0}\":{1}", headerline[0], values[0]);
                    Console.WriteLine("\t\"{0}\":\"{1}\"", headerline[1], values[1]);
                    Console.WriteLine("\t\"{0}\":\"{1}\"", headerline[2], values[2]);
                    Console.WriteLine("\t\"{0}\":\"{1}\"", headerline[3], values[3]);

                    Console.WriteLine("}");
                }else{
                    headerline = line.Split(',');
                }
                
               counter++;
            }

            Console.WriteLine("There are {0} lines in this file", counter-1);
            file.Close();

               
           }else{
               Console.WriteLine("File does not exist");
           }
           
        }
    }
}
