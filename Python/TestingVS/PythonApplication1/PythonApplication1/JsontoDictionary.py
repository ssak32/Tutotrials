'''Load Json to Dictionary, loads raw Json data into Multivalue dictionary'''
import operator
from functools import reduce
from itertools import chain
from collections import defaultdict

'''Merge two dictionaries'''
def Merge(dict1, dict2):
    res = {**dict1, **dict2}
    return res


'''Retaining key, and appending values - Single key with multiple values'''
def RetainKeyAppendValuesMerge(dict1, dict2):
    res = defaultdict(list)
    for k, v in chain(dict1.items(), dict2.items()):
        res[k].append(v)

    return res

def BuildDictionary(data):
    myarray = []

    for i in data:
        myarray.append(i)

    all_keys = reduce(operator.or_, (d.keys() for d in myarray))
    myarray = {key: [d.get(key) for d in myarray] for key in all_keys}

    return myarray


def jsontodictionary(data):
    mydict = BuildDictionary(data)
    return mydict
