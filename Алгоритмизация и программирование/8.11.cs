/******************************************************************************
8.11
В массиве размерность n*m определить:
кол-во строк, в которых мин и макс элементы чет
(Ввод данных в массив, нахождение мин и макс с помощью функций)
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() 
   {
      Console.WriteLine("n=");
      int n=Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("m=");
      int m=Convert.ToInt32(Console.ReadLine());
      int [,] array=new int [n,m];
      array = Zapolnenie(n, m, array);
      int r=0;
      for (int i=0;i<n;i++)
      {
          int Max = FindMax(array,i,m);
          int Min = FindMin(array,i,m);
          if ((Max%2==0) && (Min%2==0))
          r=r+1;
      }
      Console.WriteLine("количество строк, в которых мин и макс элементы чет:"+r);
    }
    //функция для заполнения массива
    static int[,] Zapolnenie(int n, int m, int[,] array)
        {
            for (int i=0; i<n; i++)
            {
                Console.WriteLine($"введите элементы {i} строки массива");
                for (int j=0; j<m; j++)
                {
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return array;
        }
    //функции для поиска макс и мин
    static int FindMax(int[,] array, int i, int m)
    {
        int max = 0;
        for (int j=0;j<m;j++)
        {
            if (max<array[i,j])
            max=array[i,j];
        }
        return max;
    }
    
    static int FindMin(int[,] array, int i, int m)
    {
        int min = 10000000;
        for (int j=0;j<m;j++)
        {
            if (min>array[i,j])
            min=array[i,j];
        }
        return min;
    }
}