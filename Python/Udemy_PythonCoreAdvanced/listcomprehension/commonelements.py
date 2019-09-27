lst1 = [1,2,3,4,5]
lst2 = [1,3,5,6,7]

# Conventional way
lstx = []
for i in lst1:
    if i in lst2:
        lstx.append(i)
print(lstx)

# List Comprehensive way
lsty = [i for i in lst1 if i in lst2]
print(lsty)