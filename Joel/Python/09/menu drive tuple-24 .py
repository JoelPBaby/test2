b=()
a=0
while a<6:
    print("   Menu Driven   ")
    print("**********")
    print("1. Create")
    print("2. Add")
    print("3. Remove")
    print("4. Search")
    print("5. Traverse")
    print("6. Exit")
    print("*********")
    a=int(input("Enter your choice: "))
    if a==1:
        l=int(input("Enter Limit: "))
        for i in range(0,l):
            q=int(input("Enter number: "))
            c=list(b)
            c.append(q)
            b=tuple(c)
        print("Tuple: ",b)
    if a==2:
        l=int(input("Enter limit to add: "))
        for i in range(0,l):
            q=int(input("Enter element to add: "))
            c=list(b)
            c.append(q)
            b=tuple(c)
        print("Tuple: ",b)
    if a==3:
        l=int(input("Enter element to remove: "))
        c=list(b)
        c.remove(l)
        b=tuple(c)
        print("Tuple: ",b)
    if a==4:
        l=int(input("Enter element to search: "))
        c=b.index(l)
        print("Found at position: ",c)
    if a==5:
        print(b)
        
         
        
    

      
