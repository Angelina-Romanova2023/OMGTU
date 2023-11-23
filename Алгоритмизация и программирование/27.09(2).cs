//27.09 дано n пар элементов, из каждой пары взять 1 элемент и определить сумму, которая делиться на 3
using System;
class HelloWorld {
  static void Main() {
    int N = Convert.ToInt32(Console.ReadLine()), maxsum = 0, minr = 500;
    for (int i = 0; i<N; i++)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        if (a>b)
        {
            maxsum=maxsum+a;
        }
        else
        {
            maxsum=maxsum+b;
        }
    int v = Math.Abs(a-b);
    if (v < minr && v!=0)
    {
        minr=v;
    }
    }
    if (maxsum % 3 == 0)
    {
        Console.WriteLine(maxsum);
    }
    else if ((maxsum-minr) % 3==0 && minr!=500)
    {
        Console.WriteLine(maxsum-minr);
    }
    else if ((maxsum - 2*minr)%3==0 && minr!=500)
    {
        Console.WriteLine(maxsum - 2*minr);
    }
    else
    { 
        Console.WriteLine("final");
    }
  }
}