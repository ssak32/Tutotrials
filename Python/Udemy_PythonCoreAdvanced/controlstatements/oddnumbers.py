num1 = int(input("Enter the starting number: "))
num2 = int(input("Enter the ending number (should be greater than starting number): "))

if (num1 > num2):
    print("Starting number is greater than Ending number, hence swapping them")
    temp = num1
    num1 = num2
    num2 = temp

print("Printing odd numbers between the range:" + str(num1) + " and " + str(num2))
while(num1 <= num2):
    if(num1%2 != 0):
        print(num1)
    num1+=1