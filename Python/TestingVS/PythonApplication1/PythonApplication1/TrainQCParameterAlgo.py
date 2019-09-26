from GetMinMaxAvg import CalcMinMaxAvg
from LoadCasperData import LoadCasperDataFromFile


class TrainQCParameterAlgo:
    data = []

    def __init__(self):
        TrainQCParameterAlgo.data = self.load_data()

    def load_data(self):
        lcd = LoadCasperDataFromFile('CasperTestScrapedData - Copy')
        # lcd = LoadCasperDataFromUrl('')
        lcd.load_data()
        return lcd.get_data()

    def display(self):
        calc = CalcMinMaxAvg(TrainQCParameterAlgo.data)
        calc.calculate('sku')

        print("Data", calc.data)
        print("Min:", calc.get_min())
        print("Max:", calc.get_max())
        print("Avg:", calc.get_avg())


dqc = TrainQCParameterAlgo()
dqc.display()
