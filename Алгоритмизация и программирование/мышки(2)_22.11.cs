/* "выходные"
n- кол-во серых мышей
m- кол-во белых мышей
k-шаг
"выходные"
n1-выжившие серые
m1-выжившие белые
Определить положение мышей, чтобы при выходе с позиции серой мыши при съедании k-той с входными данными получались выходные*/
using System;
class HelloWorld {
  static void Main() {
    int sum = -1, b = 0;
    bool f = false;
    Console.WriteLine("количество серых мышей =");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("количество белых мышей =");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("шаг =");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("количество выживших серых мышей =");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("количество выживших белых мышей =");
    int m1 = Convert.ToInt32(Console.ReadLine());
    int N = n - n1;
    int[] a = new int[n + m];
    for (int i = 0; i < n + m; i++) a[i] = i;
    for (int i = 0; i < (n + m) - (m1 + n1); i++)
    {
        while (!((sum == k) && (a[b] != -1)))
        {
            if (a[b] != -1) sum += 1;
            if ((sum != k) || (a[b] == -1)) b = (b + 1) % (m + n);
        }
        a[b] = -1; sum = 0;
    }
    Console.WriteLine();
    for (int i = 0; i < n + m; i++)
    {
        if ((n < n1) || (m < m1))
            {f = true; break;}
        if (a[i] == -1)
        {
            if (N != 0)
            {
                N += -1;
                Console.WriteLine($"серая {i+1}");
            }
            else
            {
                if (i == 0)
                {
                    f = true;
                    break;
                }
                Console.WriteLine($"белая {i+1}");
            }
        }
        else
        {
            if (n1 != 0)
            {
                n1 += -1;
                Console.WriteLine($"серая {i + 1}");
            }
            else
            {
                if (i == 0)
                {
                    f = true;
                    break;
                }
                Console.WriteLine($"белая {i + 1}");
            }
        }
    }
    if (f) Console.WriteLine("Расположить не возможно");
    Console.WriteLine();
}
}