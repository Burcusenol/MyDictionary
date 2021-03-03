using System;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> kisiler = new MyDictionary<string, int>();
            kisiler.Add("Ayşe", 26);
            kisiler.Add("Ali", 18);
            kisiler.Add("Sena", 21);
            kisiler.List();
            kisiler.Length();
        }
    }
}
