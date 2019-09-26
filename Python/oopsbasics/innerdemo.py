class Car:
    def __init__(self, make, year):
        self.make = make
        self.year = year

    def car_details(self):
        print(self.make)
        print(self.year)

    class Engine:
        def __init__(self, number):
            self.number = number

        def engine_details(self):
            print(self.number)

        def start(self):
            print("Engine started!")

c = Car("BMW", 2018)
e = c.Engine(12345)
c.car_details()
e.engine_details()
e.start()