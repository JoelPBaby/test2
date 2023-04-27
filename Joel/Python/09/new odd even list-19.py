llist=[]
odd=[]
even=[]
q=int(input("Enter limit of the list: "))
for i in range(0,q):
    w=int(input("Enter element :"))
    llist.append(w)
print(llist)
for i in range(0,q):
    if(llist[i]%2==0):
        ans=llist[i]
        even.append(ans)      
    else:
        ans=llist[i]
        odd.append(ans)
print("Odd List: ",odd)
print("Even List: ",even)

