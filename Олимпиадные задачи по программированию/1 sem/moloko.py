print('введите N')
n=int(input())
a=0
minst=10000
for i in range (1,n+1):
    print('введите размеры двух упаковок')
    x1=int(input())
    y1=int(input())
    z1=int(input())
    x2=int(input())
    y2=int(input())
    z2=int(input())
    print('введите стоимости упаковок')
    c1=float(input())
    c2=float(input())
    s1=2*(x1*y1+y1*z1+x1*z1)    #площадь 1 упаковки
    s2=2*(x2*y2+y2*z2+x2*z2)    #площадь 2 упаковки
    v1=x1*y1*z1                 #объём 1 упаковки
    v2=x2*y2*z2                 #объём 2 упаковки
    p=(c1-c2*s1/s2)/(v1-v2*s1/s2)*1000
    if p<minst:
        minst=p
        a=n
minst=round(minst,2)
print(a,'   ',minst)
