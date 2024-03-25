n=int(input())
if n==0:
    print(0)
for i in range (0,24):
    if n==3*(2**i):
        print(2**i)
        break
    if n==(2**i):
        print(0)
        break
    for j in range(1,2**i):
        if (n==(3*(2**i)-j)) or (n==(3*(2**i)+j)):
            print(2**i-j)
            break
