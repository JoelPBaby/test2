a=int(input("Enter the limit of the list: "))
new=[]
i=0
for i in range(0,a):
    b=int(input("Enter Element:"))
    new.append(b)
print(new)
for i in new[0:a]:
    new.remove(i)
    i+=1
print("Item Successfully Removed !")
print(new)

      
