'''Tuple's are like Static list'''

tpl = (40, 50, 10, 'abc', 50)
print(tpl)
print(tpl[2])
print(tpl.count(50))
print(tpl.index('abc'))

'''Converting Tuple into a List'''
lst = [10, 20, 30]
print(type(lst))
tpl1 = tuple(lst)
print(type(tpl1))
print(tpl1)
