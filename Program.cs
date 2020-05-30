using System;

namespace HomeWork3_Practic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            bool b = true;
            str = str.Replace(" ", string.Empty);
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                    b = false;
            }

            Console.WriteLine(((b) ? "является" : "не является") + " палиндромом");
            Console.ReadKey();

            string s = " Андре й К а ннн ";
            int c = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((i < (s.Length - 1)))
                {
                    if ((s[i] == ' ') && (s[i + 1] != ' ')) c++;
                }
            }
            Console.WriteLine("In the string is {0} word('s).", c);
            Console.ReadKey();

        }
        
     }
}
