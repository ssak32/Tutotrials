maths = int(input("Enter maths marks: "))
physics = int(input("Enter physics marks: "))
chemistry = int(input("Enter chemistry marks: "))

if maths < 35 or physics < 35 or chemistry < 35:
    print('The candidate has failed the exam')
else:
    avg = (maths + physics + chemistry)/3
    if avg <= 59:
        print('The candidate secured "C" grade')
    elif avg > 59 and avg <= 69:
        print('The candidate secured "B" grade')
    else:
        print('The candidate secured "A" grade')