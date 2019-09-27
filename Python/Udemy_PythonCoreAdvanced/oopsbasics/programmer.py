class Programmer:

    def setName(self, name):
        self.name = name

    def getName(self):
        return self.name

    def setSalary(self, sal):
        self.salary = sal

    def getSalary(self):
        return self.salary

    def setTechnologies(self, techs):
        self.Technologies = techs

    def getTechnologies(self):
        return self.Technologies

p1 = Programmer()
p1.setName("Rob")
p1.setSalary(10000)
p1.setTechnologies(["C#", "Python"])

print(p1.getName())
print(p1.getSalary())
print(p1.getTechnologies())