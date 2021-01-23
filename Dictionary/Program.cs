using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary <int, string> MyDictionary = new MyDictionary <int, string>();
            MyDictionary.Add(125, "Matematik");
            MyDictionary.Add(853, "İstatistik");
            MyDictionary.Add(120, "Programlama");
        }
    }
}
