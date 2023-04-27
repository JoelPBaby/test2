print("/*/*/*/*/*/*Menu Driven Program/*/*/*/*/*/*")
for i in range(4):
    print("Main Menu")
    print("1. Create List")
    print("2. Adding element")
    print("3. Removing element")
    print("4. Display List")
    a=int(input("Enter your Choice: "))
    while a:
         if a==1:
              b=int(input("Enter Limit:"))
              newlist=[]
              for i in range(b):
                  x=input("Enter Element:")
                  newlist.append(x)
              print(newlist)
              break
         if a==2:
              print("Adding element")
              c=int(input("Limit to Enter element: "))
              for i in range(c):
                    e=input("Enter new element to add : ")
                    newlist.append(e)
              print(newlist)
              break    
         if a==3:
             print("Remove element")
             newlist.pop(0)
             print(newlist)
             break
         if a==4:
             print(newlist)
             break
             
             
        

        

      
      
