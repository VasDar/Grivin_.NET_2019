using System.Text;

namespace Task4
{
    class MyString
    {
        char[] array;

        public MyString() { }
        public MyString(string s)
        {
            array = s.ToCharArray();
        }
        public static MyString operator +(MyString string1, MyString string2)
        {
            MyString mainString = new MyString();
            mainString.array = new char[string1.array.Length + string2.array.Length];
            string1.array.CopyTo(mainString.array, 0);
            string2.array.CopyTo(mainString.array, string2.array.Length);
            return mainString;
        }

        public static MyString operator -(MyString string1, MyString string2)
        {
            StringBuilder stringBilder1 = new StringBuilder();
            foreach (char letter in string1.array)
            {
                stringBilder1.Append(letter);
            }
            string string3 = string2.ToString();
            stringBilder1.Replace(string3, "");
            return new MyString(stringBilder1.ToString());
        }
        public static bool operator !=(MyString string1, MyString string2) { return !(string1 == string2); ; }
        public static bool operator ==(MyString string1, MyString string2)
        {
            bool equal = true;
            if (string1.array.Length != string2.array.Length)
            {
                return false;
            }
            for (int i = 0; i < string1.array.Length; i++)
            {
                if (string1.array[i] != string2.array[i])
                {
                    return false;
                }
            }
            return equal;

        }
        public override string ToString()
        {
            StringBuilder outPutString = new StringBuilder();
            foreach (char latter in array)
            {
                outPutString.Append(latter);
            }
            return outPutString.ToString();
        }
    }
}
