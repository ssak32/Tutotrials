num = int(input("Enter a number: "))
i=1

while i <= num:

    if i > 100:
        break
    elif i % 10 != 0:
        print(i)

    i += 1