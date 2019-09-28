try:
    f = open("myfile.txt", "w")
    a, b = [int(x) for x in input("Enter two number: ").split()] # 1 0
    c = a/b
    f.write("Writing %d into a file" %c)
except ZeroDivisionError:
    print("Division by zero is not allowed")
    print("Pleaes enter a non-zero nubmer")
finally:
    f.close()
    print("File closed")

print("Code after the exception")