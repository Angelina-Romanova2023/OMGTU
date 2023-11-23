/*для н вводимых элементов определить:
1. все ли элементы кратны своему номеру
2. положение первого четного элемента в массиве
3. положение последнего нулевого элемента
4. количество элементов, кратных минимальному элементу(не равному 0)
5. образуют ли элементы, расположенные между минимальным и максимальным 
элементами(каждого только по одному), убывающую последовательность. 
если между ними нет ни одного элемента, вывести соответствующее сообщение*/
using System;
class HelloWorld {
  static void Main() {
    int n = Convert.ToInt32(Console.ReadLine());
    int[] a = new int[n];
    int count = 0;
    int v = -1;
    int flag = 0;
    int min=1000000;
    int k=0;
    int maxim=-100000000;
    int minim=100000000;
    int f=0;
    int b=-1;
    for (int i=0;i<n;i++)
    {
        a[i]=Convert.ToInt32(Console.ReadLine());
        if (a[i]%(i+1)==0)
        count=count+1; 
        if (a[i]%2==0 && flag==0)
        {
            b=i+1;
            flag = 1;
        }
        if (a[i]==0)
        v=i+1;
        if (a[i]<min && a[i]!=0)
        min=a[i];
        if (a[i]<minim)
        minim=i;
        if (a[i]>maxim)
        maxim=i;
    }
    if (count==n)
    Console.WriteLine("1 true");
    else
    Console.WriteLine("1 false");
    if (flag==0)
    Console.WriteLine("2 ego net");
    else
    Console.WriteLine($"2 {b}");
    if (v!=-1)
    Console.WriteLine($"3 {v}");
    else
    Console.WriteLine("3 ego net");
    for (int i=0;i<n;i++) 
    {
        if (a[i]%min==0)
        k=k+1;
    }
    Console.WriteLine($"4 {k}");
    if (minim==maxim)
    Console.WriteLine("5 равны");
    else
    {
        if (minim<maxim)
    {
        for (int i=minim+1;i<maxim;i++)
        {
            if (a[i]>=a[i+1])
            f=1;
        }
        if (f==0)
        Console.WriteLine("5 da");
        else
        Console.WriteLine("5 net");
    }
        else
    {
       for (int i=maxim+1;i<minim;i++)
        {
            if (a[i]>=a[i+1])
            f=1;
        }
        if (f==0)
        Console.WriteLine("5 da");
        else
        Console.WriteLine("5 net");
    }
    }
  }
}