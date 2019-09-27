from abc import abstractmethod, ABC

class BMW(ABC):  # ABC - setting a class as a abstract class
    def __init__(self, make, model, year):
        self.make = make
        self.model = model
        self.year = year

    def start(self):
        print("Starting the car")

    def stop(self):
        print("Stopping the car")

    @abstractmethod  # @abstractmethod - decorator to indicate abstract method
    def drive(self):
        pass  # indicating empty method


class ThreeSeries(BMW):
    def __init__(self, cruise_control_enabled, make, model, year):
        super().__init__(make, model, year)
        self.cruiseControlEnabled = cruise_control_enabled

    def display(self):
        print(self.cruiseControlEnabled, "\t", self.make, "\t", self.model, "\t", self.year)

    def start(self):
        print("Button start")

    def drive(self):
        print("Driving BMW ThreeSeries")


class FiveSeries(BMW):
    def __init__(self, parking_assist_enabled, make, model, year):
        super().__init__(make, model, year)
        self.parkingAssistEnabled = parking_assist_enabled

    def display(self):
        print(self.parkingAssistEnabled, "\t", self.make, "\t", self.model, "\t", self.year)

    def start(self):
        super().start()
        print("Remote start")

    def drive(self):
        print("Driving BMW FiveSeries")


threeSeries = ThreeSeries(True, "BMW", "328i", "2018")
fiveSeries = FiveSeries(True, "BMW", "678i", "2018")

threeSeries.display()
threeSeries.start()
fiveSeries.display()
fiveSeries.start()
threeSeries.drive()
fiveSeries.drive()
threeSeries.stop()
fiveSeries.stop()
