using System;
using System.IO;

namespace FileIOc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write to file
            // Mehtod 1
            string[] lines = { "First 250", "Second 242", "Third 240" };
            File.WriteAllLines(@"C:\Users\Danielch\Desktop\textFile.txt", lines);

            // Method 2
            Console.WriteLine("Fielname: ");
            string filename = Console.ReadLine();
            Console.WriteLine("Text for the file: ");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Danielch\Desktop\" + filename + ".txt", input);

            // Method 3
            // Streamwriter opens and closes as required
            using (StreamWriter file = new StreamWriter(@"C:\Users\Danielch\Desktop\myTextFile.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            };

            // Additional line
            using (StreamWriter file = new StreamWriter(@"C:\Users\Danielch\Desktop\myTextFile.txt", true))
            {
                file.WriteLine("Additional line");
            }


            /*
             * Read from file
            string text = System.IO.File.ReadAllText(@"C:\Users\Danielch\Desktop\textFile.txt");
            Console.WriteLine("Textfile contains following text: {0}", text);


            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Danielch\Desktop\textFile.txt");
            Console.WriteLine("Contents of textfile.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            */

        }
    }
}
