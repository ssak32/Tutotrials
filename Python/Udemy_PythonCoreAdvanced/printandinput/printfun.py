print()
print('Hello ' * 3)
print('All the power\nyou need')

a, b = 10, 20
print(a, b)
print(a, b, sep=',')

name = 'John'
marks = 94.5
print('Name is: ', name, 'Marks are: ', marks)
print('Name is %s, Marks are %f'%(name,marks))
print('Name is %s, Marks are %.2f'%(name,marks))


print('Name is {}, Marks are {}'.format(name,marks))
print('Name is {0}, Marks are {1}'.format(name,marks))
