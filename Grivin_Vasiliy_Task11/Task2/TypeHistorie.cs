using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task2
{
    class TypeHistorie
    {
        private string _type;
        public TypeHistorie(string type)
        {
            Type = type;
        }
        public string Type
        {
            get
            {
                return _type;
            }
            private set
            {
                if (value == "console" || value == "historiefile")
                {
                    _type = value;
                }
            }
        }
        public void Historie(string str)
        {
            if (Type == "console")
            {
                Console.WriteLine(str);
            }
            File.AppendAllText(Spy.historieDirectory, str);
        }
    }
}
