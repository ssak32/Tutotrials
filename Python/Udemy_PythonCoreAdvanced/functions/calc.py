def Calc(a,b ):
    x = a + b
    y = a - b
    z = a * b
    u = a / b

    return (x, y, z, u)

# Multiple return values are stored in Tuple.
result = Calc(10, 5)
print(result)