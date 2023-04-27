a=int(input("Enter the number : "))
arm=0
t=a
while(t>0):
    rem=t%10
    arm=arm+(rem*rem*rem)
    t=t//10
if(arm==a):
    print(a,"is an  armstrong number")
else:
    print(a, "is not an armstrong nummber")
    
