lst = [10, 20, -10, 'Sajid']
print(lst)
print(lst[2])
print(lst[1:2])
print(len(lst))

lst.append(-20)
print(lst)
lst.remove('Sajid')
print(lst)
del(lst[3])
print(lst)

#lst.clear()
#print(lst)

print(max(lst))
print(min(lst))

lst.insert(3, 40)
print(lst)

lst.sort()
print(lst)
lst.sort(reverse=True)
print(lst)