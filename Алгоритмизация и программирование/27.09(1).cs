//27.09
//1 определить количество элементов, значение которых меньше своих соседей
using System;
class HelloWorld {
static void Main() {
int n = Convert.ToInt32(Console.ReadLine()), k=0;
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
n=n-1;
for(int i = 0; i<n-2; i++){
if (b<a && b<c)
k=k+1;
if (n<=3) break;
int d = b;
b = c;
c = Convert.ToInt32(Console.ReadLine());
a = d;
}
if (b<a && b<c)
k=k+1;
Console.WriteLine("finally");
Console.WriteLine(k);
}
}

//2 определить количество смен знаков последовательности
using System;
class HelloWorld {
static void Main() {
int n = Convert.ToInt32(Console.ReadLine()), k=0;
int a = Convert.ToInt32(Console.ReadLine());
n=n-1;
for(int i = 0; i<n; i++){
int b = Convert.ToInt32(Console.ReadLine());
if (a*b<0)
k=k+1;
a = b;
}
Console.WriteLine("finally");
Console.WriteLine(k);
}
}

//3 определить макс длину подпоследовательности, состоящей из одинаковых элементов
using System;
class HelloWorld {
static void Main() {
int n = Convert.ToInt32(Console.ReadLine()), k=1;
int a = Convert.ToInt32(Console.ReadLine()), m=0;
for(int i = 0; i<n-1; i++){
int b = Convert.ToInt32(Console.ReadLine());
if (a==b)
k=k+1;
else
if (k>m)
{
m = k;
k = 1;
}
a = b;
}
if (k>m)
m = k;
Console.WriteLine("finally");
Console.WriteLine(m);
}
}

//4 определить мин длину подпоследовательности из отрицательных элементов
using System;
class HelloWorld {
static void Main() {
int n = Convert.ToInt32(Console.ReadLine()), k=0;
int a = Convert.ToInt32(Console.ReadLine()), m=n+1;
if (a < 0)
k++;
for(int i = 0; i<n-1; i++){
a = Convert.ToInt32(Console.ReadLine());
if (a<0)
k++;
else
if (k<m && k>0)
{ m = k;
k = 0;}
}
if (k<m && k>0)
{ m = k;
k = 0;}
Console.WriteLine("finally");
Console.WriteLine(m);
}
}