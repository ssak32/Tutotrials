class Patient:

    def getId(self):
        return self.id

    def getName(self):
        return self.name

    def getSSN(self):
        return self.ssn

    def __init__(self, id, name, ssn):
        self.id = id
        self.name = name
        self.ssn = ssn

    def PatientDetails(self):
        print(self.id)
        print(self.name)
        print(self.ssn)

p1 = Patient(1, "Jim", 111)
p2 = Patient(2, "Dally", 222)

p2.PatientDetails()
p1.PatientDetails()