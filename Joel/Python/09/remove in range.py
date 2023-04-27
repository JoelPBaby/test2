a=int(input("Enter the limit of the list: "))
new=[]
for i in range(0,a):
    b=int(input("Enter Element:"))
    new.append(b)
print(new)
print("Enter Range to remove: ")
f=int(input("From : "))
t=int(input("To : "))
for i in new[f:t]:
    new.remove(i)
print("Item Successfully Removed !")
print(new)

      
      
