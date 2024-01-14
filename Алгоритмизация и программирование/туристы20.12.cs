/******************************************************************************
20.12 задача про туристов
1) какие пункты посетит группа туристов
2) сколько дней займет путь от начала до конца
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("скорость туристов(км/ч)=");
    double q=Convert.ToInt32(Console.ReadLine());
    q=q*1000/3600;    // q (m/s)
    Console.WriteLine("время восхода солнца(введите часы (enter) минуты");
    int v=Convert.ToInt32(Console.ReadLine());
    int v1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("время захода солнца(введите часы (enter) минуты");
    int z=Convert.ToInt32(Console.ReadLine());
    int z1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("длина всего пути=");
    int d=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("количество пунктов отдыха=");
    int n=Convert.ToInt32(Console.ReadLine());
    int[] a=new int [n+2];
    a[-1]=d;
    a[0]=0;
    for (int i=1;i<n+1;i++)
    {
        Console.WriteLine("расстояние от начала до пункта=");
        a[i]=Convert.ToInt32(Console.ReadLine());
    }
    int t=((z*60+z1)-(v*60-v1))*60; //time (s)
    double l=q*t;   //расстояние, которое проходят за день (м)
    int k=1;  //дни
    int s=0;
    for (int i=1;i<n+2;i++)
    {
        int c=a[i]-a[i-1]; //расстояние между пунктами (км)
        s=s+c;
        if (s*1000>=l)
        {
            k=k+1;
            if (s*1000==l)
            Console.WriteLine(a[i]);
            else
            Console.WriteLine(a[i-1]);
            s=0;
        }
    }
    Console.WriteLine(k);
  }
}