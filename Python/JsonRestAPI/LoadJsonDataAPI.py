import json
import objectpath as objectpath
import requests

resp = requests.get('http://ergast.com/api/f1/2004/1/results.json')
if resp.status_code != 200:
    # This means something went wrong.
    raise ApiError('GET /tasks/ {}'.format(resp.status_code))

MRData = json.loads(resp.text)

# json_tree = objectpath.Tree(MRData['MRData'])
# drivers_tuple = tuple(json_tree.execute('$..Driver.datOfBirth'))

print(json.dumps(MRData, indent=4))

for k in MRData.items():
    print(k[1])