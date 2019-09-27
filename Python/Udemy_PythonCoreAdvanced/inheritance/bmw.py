class BMW:
    def __init__(self, make, model, year):
        self.make = make
        self.model = model
        self.year = year

    def start(self):
        print("Starting the car")

    def stop(self):
        print("Stopping the car")


class ThreeSeries(BMW):
    def __init__(self, cruiseControlEnabled, make, model, year):
        super().__init__(make, model, year)
        self.cruiseControlEnabled = cruiseControlEnabled

    def display(self):
        print(self.cruiseControlEnabled, "\t", self.make, "\t", self.model, "\t", self.year)

    def start(self):
        print("Button start")


class FiveSeries(BMW):
    def __init__(self, parkingAssistEnabled, make, model, year):
        super().__init__(make, model, year)
        self.parkingAssistEnabled = parkingAssistEnabled

    def display(self):
        print(self.parkingAssistEnabled, "\t", self.make, "\t", self.model, "\t", self.year)

    def start(self):
        super().start()
        print("Remote start")

threeSeries = ThreeSeries(True, "BMW", "328i", "2018")
fiveSeries = FiveSeries(True, "BMW", "678i", "2018")

threeSeries.display()
threeSeries.start()
fiveSeries.display()
fiveSeries.start()
threeSeries.stop()
fiveSeries.stop()

