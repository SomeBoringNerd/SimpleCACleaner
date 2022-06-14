using System;
using System.Diagnostics;
using System.IO;
using System.Net;
namespace CACleaner
{
    class MainClass
    {

        public static string[] paths = new string[]
        {
            @"C:\Windows\Temp",
            @"C:\Users\" + Environment.UserName + @"\AppData\Local\Temp"
        };

        public static void Main(string[] args)
        {
            resetAsync();
        }

        private static void resetAsync()
        {
            Console.Title = "CACleaner : https://github.com/SomeBoringNerd";
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("===========================");
            Console.WriteLine("");
            Console.WriteLine("        CACleaner");
            Console.WriteLine("");
            Console.WriteLine("===========================");
            Console.WriteLine("");
            Console.WriteLine("");

            foreach(string path in paths)
            {
                DirectoryInfo di = new DirectoryInfo(path);
                if (di.Exists) {
                    Console.WriteLine("Le dossier " + di.FullName + " existe, on supprime son contenu.");
                    foreach (FileInfo file in di.GetFiles())
                    {
                        Console.WriteLine("Suppression du fichier " + file.FullName);
                    }
                }
                else
                {
                    Console.WriteLine("Le dossier " + di.FullName + " est vide ou n'existe pas, passons.");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Fini ! on peut maintenant passer a MalwareByte Cleaner");
            Console.WriteLine("");
            Console.WriteLine("Appuyez sur n'importe quelle touche pour continuer.");
            bool keyRead = false;
            while (!keyRead)
            {
                keyRead = Console.KeyAvailable;
            }
        }
    }
}
