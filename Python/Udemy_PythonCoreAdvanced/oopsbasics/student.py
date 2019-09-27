class Student:
    major = 'Computers'

    def __init__(self, roll_no, name):
        self.roll_no = roll_no
        self.name = name

s1 = Student(123, "John")

print(s1.roll_no)
print(s1.name)
print(s1.major)
print(Student.major)