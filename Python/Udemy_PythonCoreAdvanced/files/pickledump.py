import pickle, student

f = open("student.dat", "wb")
s = student.Student(123, "Sajid", 99)
pickle.dump(s, f)
f.close()
