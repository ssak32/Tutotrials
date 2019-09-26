students = []

class Student:
    school_name = "National Children School"

    def __init__(self, name, student_id=332):
        self.name = name
        self.student_id = student_id
        students.append(self)

    # Called every time we print a stutement
    def __str__(self):
        return "Student " + self.name

    def get_name_capitalize(self):
        return self.name.capitalize()

    def get_school_name(self):
        return self.school_name

sajid = Student("sajid")
print(sajid.get_name_capitalize() + " belongs to " + sajid.get_school_name())

# Derived class from Student class
class HighSchoolStudent(Student):
    school_name = "St. Aloysius High School"

    def get_school_name(self):
        return self.get_school_name()

    def get_name_capitalize(self):
        original_value = super().get_name_capitalize()
        return original_value + "-HS"


khalid = HighSchoolStudent("khalid")
print(khalid.get_name_capitalize())