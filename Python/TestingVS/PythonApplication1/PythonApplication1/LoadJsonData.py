import json
from urllib.request import urlopen


class LoadJsonData:
    data = []

    def getData(self):
        return self.data


'''Reading json file'''
class ReadJsonFile(LoadJsonData):

    def __init__(self, fileName):
        self.fileName = fileName

    def read(self):
        with open(self.fileName, "r", encoding="utf8") as f:
            self.data = json.load(f)

        return self.data


'''Loading json data from an rest api'''
class LoadJsonfromAPI(LoadJsonData):
    # "https://api.exchangeratesapi.io/latest"

    def __init__(self, urlPath):
        self.urlPath = urlPath

    def loadJsonfromAPI(self):
        with urlopen(self.urlPath) as response:
            source = response.read()

        self.data = json.loads(source)

        # print(json.dumps(data, indent=2))
        # print('Total number of rates fetched:', len(data['rates']))
        # print('INR rate:', data['rates']['INR'])
        # pass

        return self.data
