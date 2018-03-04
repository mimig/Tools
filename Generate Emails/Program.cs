using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Generate_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = string.Empty;
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter a path.");
                path = Console.ReadLine();
            }
         
            StringBuilder appendText = new StringBuilder();
       
            for (int i = 0; i < 20; i++)
            {
                appendText.Append(string.Format("testbu_{0}@test-prism.com", DateTime.UtcNow.Ticks));
                appendText.AppendLine();
            }

            File.WriteAllText(path, appendText.ToString());
         
            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}
