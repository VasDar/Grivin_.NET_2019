using System;

namespace Task01
{
    public class Employee : User
    {
        private DateTime _experience;
        private string _position;
        public string CompanyEmployee;
        public Employee(string position, 
                        string companyEmployee, 
                        string surname, 
                        string name, 
                        string patronymic, 
                        DateTime date) : base(surname, name, patronymic, date)
        {
            Position = position;
            CompanyEmployee = companyEmployee;
            
        }
        public int Experience
        {
            get
            {
                return Age(Experience1);
            }

        }
        public string Position
        {
            get
            {
                if(_position == null)
                {
                    return "Ввидите должность!";
                } 
                return _position;
            }
            set
            {
                _position = value;
            }
        }

        public DateTime Experience1 => _experience;
    }

}
