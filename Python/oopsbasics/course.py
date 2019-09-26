class Course:

    def __init__(self, name, ratings):
        self.name = name
        self.ratings = ratings

    def average(self):
        numberOfRatings = len(self.ratings)
        average = sum(self.ratings) / numberOfRatings
        print("Average rating for ", self.name, " is ", average)


c1 = Course("Python", [1, 2, 3, 4])

print(c1.name)
print(c1.ratings)
c1.average()
