/* Дано n мышек, из них одна белая. Необходимо определить с какой мышки следует съедать каждую k-ую мышку,
чтобы в конце осталась белая*/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("количество мышей =");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("шаг =");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("позиция белой мыши (счёт ведётся с нуля) =");
    int p = Convert.ToInt32(Console.ReadLine());
    int c=0;
    int step=k;
    int pb=n;
    int[] a = new int[n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[j] = 1;
        }
        step=k;
        c = (i + 1)%n;
        pb = n;
        while (true)
        {
            if (a[c] != -1)
            step = step-1;
            if (step==0)
            {
                a[c] = -1;
                pb = pb-1;
                step=k;
                
                if (pb>=1 && (c-1)==p)
                break;
        
                if (pb==1)
                {
                    Console.WriteLine($"otvet {i}");
                    break;
                }
            }
            c=(c+1)%n;
        }
    }
}
}