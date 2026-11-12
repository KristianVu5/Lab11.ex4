using System;
using System.IO;
namespace file
{
    class Program
    {
        static void Main()
        {
            string test = "Irena Todorova Ivanova, Tzar Osvoboditel, 21, Varna";

            char[] b = new char[22];

            StringReader r = new StringReader(test);

            while (true)
            {
                int bytesRead = r.Read(b, 0, 13);
                if(bytesRead == 0)
                {
                    break;
                }
                else
                {
                    string cc = new string(b, 0, bytesRead);
                    Console.WriteLine(cc);
                }
            }
            r.Close();
            Console.ReadKey();
        }
    }
}