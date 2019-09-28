import logging

logging.basicConfig(filename="mylogs.log", level=logging.DEBUG)

try:
    f = open("myfile.txt", "w")
    a, b = [int(x) for x in input("Enter two number: ").split()] # 1 0
    logging.info("Division in progress...")
    c = a/b
    f.write("Writing %d into a file" %c)
except ZeroDivisionError:
    print("Division by zero is not allowed")
    print("Pleaes enter a non-zero nubmer")
    logging.error("Division by zero")
finally:
    f.close()
    print("File closed")

print("Code after the exception")