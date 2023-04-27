a=int(input("Enter the number:"))
b=0
i=2
for i in range(i,a):
    if(a%i==0):
        b=b+1
if(b>0):
    print(a, "is a not prime number")
else:
    print(a, "is a prime number")
    
