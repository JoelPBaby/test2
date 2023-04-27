mylist=[]
a=int(input("enter limit of list:"))
i=0
while(i<a):
          value=input("enter the element:")
          mylist.append(value)
          i=i+1
print("my list=",mylist)
var=str(input("enter the element to remove: "))
for x in mylist:
    if var==x:
        mylist.remove(var)
        break
print("new list:",mylist)
