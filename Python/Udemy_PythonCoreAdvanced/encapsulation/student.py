class Student:
    def __init__(self):

        #Private variables
        self.__id = 123
        self.__name = "Dan"

    def display(self):
        print(self.__id)
        print(self.__name)

s = Student()
s.display()

#Name Mangling syntax- for accessing private fields of a class
print(s._Student__id)
print(s._Student__name)