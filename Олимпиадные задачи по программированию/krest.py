maxN=int(input())
count=maxN
i=2
while (2**i)-1<=maxN:
    count+=maxN//((2**i)-1)
    i+=1
print(count)
