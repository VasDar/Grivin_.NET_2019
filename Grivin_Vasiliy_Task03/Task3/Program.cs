using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввидете какие отличия вы бы хотели видеть:\n" +
                              "\"ru\" vs \"en\" (Ввидите 1) \n" +
                              "\"en\" vs \"invariant\" (Ввидите 2)\n" +
                              "\"ru\" vs \"invariant\" (Ввидите 3)");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    OutCulture("ru-RU", "en-US");
                    break;
                case 2:
                    OutCulture("en-US", "invariant");
                    break;
                case 3:
                    OutCulture("ru-RU", "invariant");
                    break;
                default:
                    Console.WriteLine("Вы ввели не правильный вариант!");
                    break;
            }
            Console.ReadKey();
        }
        public static void OutCulture(string oneValueCulture, string twoValueCulture)
        {
            DateTime now = DateTime.Now;
            double number = 1524.1987;
            string dateOut = "G";
            string numberOut = "F";
            string namberOutInvariant = "e3";
            if (twoValueCulture != "invariant")
            {
                Console.WriteLine($"Число {oneValueCulture} {number.ToString(numberOut, CultureInfo.CreateSpecificCulture(oneValueCulture))} vs " +
                                  $"Число {twoValueCulture} {number.ToString(numberOut, CultureInfo.CreateSpecificCulture(twoValueCulture))} ");
                Console.WriteLine($"Дата {oneValueCulture} {now.ToString(dateOut, CultureInfo.CreateSpecificCulture(oneValueCulture))} vs " +
                                  $"Дата {twoValueCulture} {now.ToString(dateOut, CultureInfo.CreateSpecificCulture(twoValueCulture))} ");
            }
            else
            {
                Console.WriteLine($"Число {oneValueCulture} {number.ToString(numberOut, CultureInfo.CreateSpecificCulture(oneValueCulture))} vs " +
                                  $"Число {twoValueCulture} {number.ToString(namberOutInvariant, CultureInfo.CreateSpecificCulture(twoValueCulture))} ");
                Console.WriteLine($"Дата {oneValueCulture} {now.ToString(dateOut, CultureInfo.CreateSpecificCulture(oneValueCulture))} vs " +
                                  $"Дата {twoValueCulture} {now.ToString(dateOut, CultureInfo.CreateSpecificCulture(twoValueCulture))} ");
            }
        }
    }
}
