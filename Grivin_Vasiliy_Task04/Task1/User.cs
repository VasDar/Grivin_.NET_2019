using System;

namespace Task1
{
    public class User
    {
        public string Surname;
        public string Name;
        public string Patronymic;
        public DateTime Date;
        public DateTime dateNow = DateTime.Now;


        public User(string surname, string name, string patronymic, DateTime date)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Date = date;

        }
        //проверка по дате два день рожднения если 
        public int Age
        {
            get
            {
                if ((DateTime.Now.Month - Date.Month) > 0)
                {
                    return DateTime.Now.Year - Date.Year - 1;
                }
                else if ((DateTime.Now.Month - Date.Month) == 0)
                {
                    if ((DateTime.Now.Day - Date.Day) <= 0)
                    {
                        return DateTime.Now.Year - Date.Year;
                    }
                    else
                    {
                        return DateTime.Now.Year - Date.Year - 1;
                    }
                }
                else
                {
                    return DateTime.Now.Year - Date.Year;
                }

            }
        }
    }
}


    

