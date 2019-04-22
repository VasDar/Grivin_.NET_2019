using System;
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввидите первую строку: ");
            MyString mystring1 = new MyString(Console.ReadLine());
            Console.WriteLine("Ввидите вторую строку: ");
            MyString mystring2 = new MyString(Console.ReadLine());
            if(mystring1 == mystring2)
            {
                Console.WriteLine("Строки равны");
            }
            else
            {
                Console.WriteLine("Строки не равны"); 
            }
            mystring1 = mystring1 + mystring2;
            string outPutString = mystring1.ToString();
            Console.WriteLine($"\"+\" строка - {outPutString}");
            mystring1 = mystring1 - mystring2;
              
            outPutString = mystring1.ToString();
            Console.WriteLine($"\"-\" строка - {outPutString}");
            Console.ReadKey();
        }
    }
}
