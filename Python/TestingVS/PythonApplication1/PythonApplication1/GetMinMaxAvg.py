import numpy as np


class CalcMinMaxAvg:
    __Min = __Max = __Avg = 0.0
    data = {}

    def get_min(self):
        return self.__Min

    def get_max(self):
        return self.__Max

    def get_avg(self):
        return self.__Avg

    def __init__(self, data):
        CalcMinMaxAvg.data = data

    def calculate(self, schema_prop):
        map_output = map(lambda x: len(x), CalcMinMaxAvg.data[schema_prop])
        list_map_output = list(map_output)

        numpy_array = np.array(list_map_output)
        self.__Min = numpy_array.min()
        self.__Max = numpy_array.max()
        self.__Avg = np.average(numpy_array)
