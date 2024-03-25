/* На вход подается строка, необходимо проверить является ли она палиндромом и посчитать сумму четных цифр строки*/
using System;
namespace ConsoleApplication23
{ class Program
    { static void Main()
        {
            string a, mas;
            int R = 0;
            a = Console.ReadLine();
            a = a.ToLower().Replace(" ", string.Empty);
            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsDigit(a[i]))
                {
                    if ((Convert.ToInt32(a[i].ToString())%2)==0)
                    {
                        R+=Convert.ToInt32(Convert.ToString(a[i]));   //сумма четных цифр
                    }
                }
            }
            Console.Write("Сумма четных цифр = ");
            Console.WriteLine(R);
            char[] spsk = a.ToCharArray();
            Array.Reverse(spsk);
            mas = new string(spsk);
            if (mas == a)
            {
                Console.WriteLine("Является палиндромом =)");
            }
            else
            {
                Console.WriteLine("Не является палиндромом =(");
            }
        }
    }
}
