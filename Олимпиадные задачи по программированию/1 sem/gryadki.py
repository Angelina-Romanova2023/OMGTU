print('введите значение переменной k')
k=int(input())
print('введите значение переменной l')
l=int(input())
print('введите значение переменной n')
n=int(input())
print('введите значение переменной m')
m=int(input())
S=0
i=2
for c in range(1,k+1):
    S=S+2*(l+n)+i*m
    i=i+2
print('длина пути=',S)

