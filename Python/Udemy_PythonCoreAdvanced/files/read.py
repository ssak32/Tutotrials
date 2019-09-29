import os, sys

filename = "myfile.txt"

if os.path.isfile(filename):
    f = open(filename, "r")
else:
    print("File does not exist!")
    sys.exit()

s = f.read()
print(s)
f.close()