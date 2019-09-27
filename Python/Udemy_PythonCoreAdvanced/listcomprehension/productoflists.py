lst1 = [1,2,3,4]
lst2 = [5,6,7,8]

# Conventional way
lstx = []
for i in range(len(lst1)):
    lstx.append(lst1[i] * lst2[i])
print(lstx)

# List Comprehensive way
lsty = [lst1[i] * lst2[i] for i in range(len(lst1))]
print(lsty)