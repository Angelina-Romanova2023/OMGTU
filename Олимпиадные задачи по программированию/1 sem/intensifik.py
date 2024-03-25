from datetime import datetime
a=str(input())
b=str(input())
p=int(input())
date1=datetime.strptime(a, '%d.%m.%Y')
date2=datetime.strptime(b, '%d.%m.%Y')
n=(date2-date1).days
n+=1
s=p
for i in range(2,n+1):
    p+=1
    s=s+p
print(s)

