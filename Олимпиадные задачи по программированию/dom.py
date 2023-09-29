print('введите размеры дома')
x=int(input())
y=int(input())
print('введите длину уцелевшей стены')
l=int(input())
print('введите 6 цен, согласно условию')
c1=int(input())
c2=int(input())
c3=int(input())
c4=int(input())
c5=int(input())
c6=int(input())
p=2*(x+y)
pokst=c4+c5
summ=0
if l>max(x,y):
   summ=(l-max(x,y))*c2
   ostat=l-max(x,y)
   if ((c2+c6+pokst)>c1) and ((c2+c3)>c1):
      summ=summ+max(x,y)*c1
   elif ((c2+c6+pokst)>(c2+c3)):
      summ=summ+max(x,y)*(c2+c3)
   else:
      summ=summ+max(x,y)*(pokst+c6+c2)
   p=p-max(x,y)
   if c3<pokst+c6:
      if ostat<=p:
          p=p-ostat
          summ=summ+ostat*c3
          summ=summ+p*pokst
      else:
          summ=summ+p*c3+(ostat-p)*c6
          p=0
   else:
       summ=summ+p*pokst+ostat*c6
       p=0
elif l<=max(x,y):
    if ((c2+c3)>c1) and ((c2+c6+pokst)>c1):
       summ=summ+l*(c2 + c3)
    elif ((c2+c6+pokst)>(c2+c3)):
       summ=summ+l*(c2+c3)
    else:
       summ=summ+l*(pokst+c6+c2)
    p=p-l
    summ=p*pokst+summ
print(summ)
