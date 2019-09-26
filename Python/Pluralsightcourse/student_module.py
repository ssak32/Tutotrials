class Student:
    school_name = "National Children School"

    def __init__(self, name, student_id=332):
        self.name = name
        self.student_id = student_id

    # Called every time we print a stutement
    def __str__(self):
        return "Student " + self.name

    def get_name_capitalize(self):
        return self.name.capitalize()

    def get_school_name(self):
        return self.school_name