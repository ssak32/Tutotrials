from abc import abstractmethod
import JsontoDictionary as jd
import LoadJsonData as ljd


class LoadCasperData:
    data = []
    dictCasperData = {}

    def get_data(self):
        return LoadCasperData.dictCasperData

    @abstractmethod
    def load_data(self):
        pass

    def load_into_dictionary(self):
        LoadCasperData.dictCasperData = jd.jsontodictionary(LoadCasperData.data)


class LoadCasperDataFromFile(LoadCasperData):
    def __init__(self, fileName):
        self.fileName = fileName

    def load_data(self):
        rjf = ljd.ReadJsonFile(self.fileName)
        LoadCasperData.data = rjf.read()
        super().load_into_dictionary()


class LoadCasperDataFromUrl(LoadCasperData):
    def __init__(self, urlPath):
        self.urlPath = urlPath

    def load_data(self):
        rjf = ljd.LoadJsonfromAPI(self.urlPath)
        LoadCasperData.data = rjf.read()
        super().load_into_dictionary()
