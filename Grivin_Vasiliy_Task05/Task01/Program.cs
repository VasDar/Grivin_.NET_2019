using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2011, 03, 2);
            Employee peopleNikolay = new Employee("Programmer", "Globus", "Grivin", "Nikolay", "Aleksandrovich", date);

            Console.WriteLine($"ФИО: {peopleNikolay.Surname} {peopleNikolay.Name} {peopleNikolay.Patronymic}\n" +
                              $"Предприятие: {peopleNikolay.CompanyEmployee} \n" +
                              $"Должность: {peopleNikolay.Position} \n" +
                              $"Стаж: {peopleNikolay.Experience}");
            Console.ReadKey();
        }
    }
}

