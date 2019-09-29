f = open("myfile.txt", "w") #opens the file for writing
print("Enter multi line text (Type '#' when done)")
s=''
while s != '#':
    s = input()
    f.write(s + "\n")
f.close()