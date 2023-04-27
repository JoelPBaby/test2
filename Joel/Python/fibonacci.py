a=int(input("Enter a Limit : "))
f=0
s=1
t=0
print("Fibonacci series is",f,s,end=" ")
for i in range(2,a+1):
    t=f+s
    if(t<a):
        f=s
        s=t
        print(t,end = " ")
        
   
        
   
    
      
