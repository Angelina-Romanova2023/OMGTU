/* Дан массив, в котором элементы строк - это множество Z не отриц чисел разной размерности.
Необходимо сформировать одномерные массивы, котрые содержат:
1) элементы пересечения множеств
2) элементы объединения множеств
3) максимальные элементы множеств */
using System.Linq;
using System;
class HelloWorld {
    static int[] Per(int[] a, int[] b)
    {
        int[] maxij = {a.Length,b.Length};
        int maxi = maxij.Max();
        int[] per = new int[maxi];
        int peri = 0;
        for (int i=0;i<a.Length;i++)
        {
            if (b.Contains(a[i]))
            {
                per[peri]=a[i];
                peri++;
            }
        }
        per = per.Skip(0).Take(peri).ToArray();
        return per;
    }
    static void Main() {
    Console.WriteLine("n=");
    int m = 0;   // количество элементов в строках
    int n = Convert.ToInt32(Console.ReadLine());
    int[][] a = new int[n][];
    int[] M = new int[n];  // массив с макс элементами
    int max = -1;
    int[] R = new int [n]; // массив количеств элементов в строках
    int sumR = 0;
    for (int i=0; i<n; i++)
    {
        Console.WriteLine("количество элементов в строке=");
        m=Convert.ToInt32(Console.ReadLine());
        a[i] = new int [m];
        for (int j=0; j<m; j++)
        {
            Console.WriteLine($"a[{i}][{j}]=");
            a[i][j]=Convert.ToInt32(Console.ReadLine());
            if (a[i][j]>max)
            max=a[i][j];
        }
        M[i]=max;
        for (int z=0;z<n;z++)
            R[z]=m;
            sumR+=m;
    }

    int[] per = a[0];
    Console.WriteLine("1) массив с пересечениями:");
    for (int i=1;i<a.Length;i++)
    {
        int[] perz = Per(per,a[i]);
        per=perz;
    }
    foreach (int k in per)
    Console.WriteLine(k);
    
    int[] obn = new int[sumR]; //объединение начало 
    int obi = 0;

    for (int i = 0; i<a.Length;i++)
    {
        for (int j=0;j<a[i].Length;j++)
        {
            if (!obn.Contains(a[i][j]))
            {
                obn[obi]=a[i][j];
                obi++;
            }
        }
    }
    var obk= obn.Skip(0).Take(obi);//объединение конец
    Console.WriteLine("2) массив с объединениями:");
    foreach (int k in obk)
    Console.WriteLine(k);
    int b = R.Length;
    
    Console.WriteLine("3) массив с максимальными элементами:");
    for (int i=0; i<n; i++)
        Console.WriteLine(M[i]);
  }
}