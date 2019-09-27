from functools import reduce

lst=[5,10,15,20]
result = reduce(lambda x,y:x+y, lst) # (((5+10)+15)+20 = 50
print(result)