/* 25.10 заправки
Количество городов = k 
a(i)-расстояние м/ж городами
p-расстояние ближе которого нельзя располагать заправку к городу
Определить: положение заправки так, чтобы суммарное расстояние от каждого города до заправки было мин*/
using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("k=");
      int k = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("p=");
      int p = Convert.ToInt32(Console.ReadLine());
      int [] a = new int[k];
      a[0]=0;
      for (int i=1; i<k;i++)
      {
          Console.WriteLine($"a({i})=__>={2*p}");
          a[i] = Convert.ToInt32(Console.ReadLine());
          a[i]=a[i]+a[i-1];
      }
      if ((k-1)%2==0)
      {
          int b1=a[((k-1)/2)]+p;
          int b2=a[((k-1)/2)]-p;
          Console.WriteLine($"заправку можно расположить на расстоянии {b2} или {b1} от первого города");
      }
      else
      {
          int b=a[((k+1)/2)]-p;
          Console.WriteLine($"заправку можно расположить на расстоянии {b} от первого города");
      }
  }
}
