import json
import objectpath

# with open('CasperTestScrapedData', "r", encoding="utf8") as f:
#     data = json.load(f)
#
# print(json.dumps(data, indent=4))
#
# print(len(data))

# json_tree = objectpath.Tree(data['MRData'])
# drivers_tuple = tuple(json_tree.execute('$..Driver'))
#
# print(drivers_tuple)


'''Reading json file'''
class ReadJsonFile():

    def __init__(self, fileName):
        self.fileName = fileName

    def read(self):
        with open(self.fileName, "r", encoding="utf8") as f:
            self.data = json.load(f)

        return self.data

data=[]

for i in range(100000
               ):
    rjf = ReadJsonFile('CasperTestScrapedData')
    data1 = rjf.read()
    data.append(data1)

print("Done!")