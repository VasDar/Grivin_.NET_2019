using System;
namespace Task01
{
    public class User
    {
        public string Surname;
        public string Name;
        public string Patronymic;
        public DateTime Date;
       


        public User(string surname, string name, string patronymic, DateTime date)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Date = date;

        }

        public int Age(DateTime date)
        {
            int result;
                if ((DateTime.Now.Month - date.Month) > 0)
                {
                  result = DateTime.Now.Year - Date.Year - 1;
                }
                else if((DateTime.Now.Month - Date.Month) == 0)
                {
                    if ((DateTime.Now.Day - Date.Day) <= 0)
                    {
                    result = DateTime.Now.Year - Date.Year;
                    }
                    else
                    {
                    result = DateTime.Now.Year - Date.Year - 1;
                    }
                }
                else
                {
                result = DateTime.Now.Year - Date.Year ;
                }
            return result;

        }

       
    }
}
