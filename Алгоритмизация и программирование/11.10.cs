/* дан массив из n элементов определить:
1) количество четных элементов, расположенных между мин и макс (по одному) (обработать, когда элементов нет)
2) все ли элементы последовательности, стоящие на четных местах (нечтных, если считать с нулевого) имеют
в своей записи хотя бы одну пятерку
3) заменить все нечетные элементы массива на сумму цифр
4) количество элементов, значение которых больше ср арифметического нечетных элементов массива
5) имеется ли в массиве хотя бы один отрицательный элемент, оканчивающийся на "3"*/
using System.Linq;
using System;
class HelloWorld {
  static void Main() {
    int n = Convert.ToInt32(Console.ReadLine());
    int[] a = new int[n];
    int min=1000000000;
    int max=-100000000;
    int k=0;
    int flag=1;
    float s=0;
    float kn=0;
    float srar=0;
    string stri="";
    int v=0;
    int b=0;
    int m=0;
    for (int i=0;i<n;i++)
    {
        a[i]=Convert.ToInt32(Console.ReadLine());
        if (a[i]<min)
        min=i;
        if (a[i]>max)
        max=i;
        if (Math.Abs(a[i])%2==1)
        {
            s=s+a[i];
            kn=kn+1;
        }
        if (a[i]<0 && Math.Abs(a[i])%10==3)
        m=1;
    }
    srar=s/kn;
    for (int i=0;i<n;i++)
    {
        if (a[i]>srar)
        v=v+1;
    }
    if (min==max)
    Console.WriteLine("1) элементов между мин и макс нет");
    else 
    {
        if (min<max)
        {
            for (int i=min+1;i<max;i++)
            {
                if (Math.Abs(a[i])%2==0)
                k=k+1;
            }
        }
        else
        {
            for (int i=max+1;i<min;i++)
            {
                if (Math.Abs(a[i])%2==0)
                k=k+1;
            }
        }
    }
    Console.WriteLine($"1) {k}");
    
    
    
    for (int i=1;i<n;i+=2)
    {
        string strz=Convert.ToString(a[i]);
        int pyat = strz.Count(p=>p=='5');
        if (pyat==0 && flag==1)
        flag=0;
    }
    if (flag==1)
    Console.WriteLine("2) da");
    else
    Console.WriteLine("2) net");
    
    
    
    Console.WriteLine("3)");
    for (int i=0;i<n;i++)
    {
        if (Math.Abs(a[i])%2==1)
        {
            while (a[i]!=0)
            {
                b=(Math.Abs(a[i])%10)+b;
                a[i]=Math.Abs(a[i])/10;
            }
            a[i]=b;
            b=0;
        }
        Console.WriteLine(a[i]);
    }
    
    
    
    Console.WriteLine($"4) {v}");
    
    
    if (m==1)
    Console.WriteLine("5) da");
    else
    Console.WriteLine("5) net");
  }
}