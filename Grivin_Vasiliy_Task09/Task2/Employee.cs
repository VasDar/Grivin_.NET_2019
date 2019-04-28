using System;


namespace Task2
{
    class Employee
    {
        public delegate void ComeEvenDelegate(Employee o, OnComeEventArgs args);
        public event ComeEvenDelegate Come;

        public delegate void LeaveEvenDelegate(Employee o, EventArgs args);
        public event LeaveEvenDelegate Leave;

        public string Name { get; private set; }
        public Office Office { get; private set; }

        public Employee(string name, Office office)
        {
            Name = name;
            Office = office ?? throw new ArgumentNullException(nameof(office));

            Come += office.OnCome;
            Leave += office.OnLeave;
        }

        public void SayHi(Employee e, OnComeEventArgs args)
        {
            string hello;

            if (args.Hours < 12)
                hello = "Доброе утро";
            else if (args.Hours > 12 && args.Hours < 17)
                hello = "Доброго дня";
            else
                hello = "Доброго вечера";


            Console.WriteLine($"{hello}, {args.Name} - сказал {Name}");
        }

        public void SayGoodby(Employee e, EventArgs args)
        {
            Console.WriteLine($"Пока,{e.Name} - сказал {Name}");
        }

        public void GoToOffice(int time)
        {
            Come?.Invoke(this, new OnComeEventArgs(Name, time));
        }

        public void GoHome()
        {
            Leave?.Invoke(this, new EventArgs());
        }

        public void Leaved(Employee person)
        {
            Come -= person.SayHi;
        }
    }
}