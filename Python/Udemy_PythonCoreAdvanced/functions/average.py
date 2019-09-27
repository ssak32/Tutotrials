def average(a=10, b=20): #function with defualt values
    print(a)
    print(b)
    return (a+b)/2

print(average(3, 4))

# Keyword arguments
print(average(a=3, b=4))
print(average(b=3, a=4))

# function will use the default values
print(average())
print(average(a=30))
print(average(b=40))