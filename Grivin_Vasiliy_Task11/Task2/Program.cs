using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists(Spy.versionDirectory + @"\" + "0"))
            {
                Spy.CopyTo(Spy.spyDirectory, Spy.versionDirectory + @"\" + Spy.count);
                File.AppendAllText(Spy.historieDirectory, "0. Откатить в начало\r\n");
            }
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = Spy.spyDirectory;
                watcher.IncludeSubdirectories = true;
                watcher.Filter = "*.txt";
                watcher.EnableRaisingEvents = true;
                Spy spy = new Spy(watcher, "historiefile");
                string[] arrayForCount = spy.GetVesrion();
                Spy.count = arrayForCount.Length - 1;
                Console.WriteLine("Для слежки команда \"spy\" ,а для отката \"change\"");
                string arg = Console.ReadLine();
                while (arg != "volna123")
                {
                    switch (arg)
                    {
                        case "spy":
                            spy.Monitor();
                            break;
                        case "change":
                            Console.WriteLine("Выберите,к какому состоянию откатить");
                            string[] array = spy.GetVesrion();
                            for (int i = 0; i < array.Length; i++)
                            {
                                Console.WriteLine(array[i]);
                            }
                            int.TryParse(Console.ReadLine(), out int temp);
                            spy.Change(temp);
                            break;
                        default:
                            Console.WriteLine("Для слежки команда \"spy\" ,а для отката \"change\", попробуйте ввести еще раз");
                            break;
                    }
                    arg = Console.ReadLine();
                }
            }
        }
    }
}

