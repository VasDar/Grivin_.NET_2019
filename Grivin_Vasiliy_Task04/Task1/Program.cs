using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(1998, 04, 29);
            User peopleVasiliy = new User("Grivin", "Vasiliy", "Aleksandrovich", date);
            Console.WriteLine(peopleVasiliy.Surname
                              + " " +
                              peopleVasiliy.Name
                              + " " +
                              peopleVasiliy.Patronymic
                              + " " +
                              peopleVasiliy.Age);
        }
    }
}


    

