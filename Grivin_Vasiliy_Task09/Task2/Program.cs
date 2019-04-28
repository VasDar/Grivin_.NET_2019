using System;
using System.Collections.Generic;
using System.Text;


namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Office office = new Office();
            Employee p1 = new Employee("Джон", office);
            Employee p2 = new Employee("Билл", office);
            Employee p3 = new Employee("Хьюго", office);

            p1.GoToOffice(9);
            p2.GoToOffice(11);
            p3.GoToOffice(14);

            p1.GoHome();
            p2.GoHome();
            p3.GoHome();

            Console.ReadKey();
        }
    }
}