student_names = ["James", "Katarina", "Jessica", "Mark", "Bort", "Frank Grimes", "Max Power"]

"""Simple for loop to find specified name within the list"""
print("\nSimple for loop to find specified name within the list")
for name in student_names:
    if name == "Mark":
        print("Found him! " + name)
    print("Currently looking " + name)

"""For loop to find specified name within the list and stop continuing the code there after"""
print("\nFor loop to find specified name within the list and stop continuing the code there after")
for name in student_names:
    if name == "Mark":
        print("Found him! " + name)
        break
    print("Currently looking " + name)

"""For loop to find specified name within the list and skip the same, while continuing the rest"""
print("\nFor loop to find specified name within the list and skip the same, while continuing the rest")
for name in student_names:
    if name == "Bort":
        continue
        print("Found him! " + name)
    print("Currently looking " + name)