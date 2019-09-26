'''
1. Set removes duplicates if any
2. Values are stored in any order
3. Cannot perform Indexing, Slicing, Repetation on a Set
4. If a set is Frozen, then 'update' and 'remove' cannot be performed over the set
'''
s = {10, 20, 30, 'abc', 10, 20}
print(s)
print(type(s))

s.update([88, 99])
print(s)
s.remove(30)
print(s)

#f=frozenset(s)
#f.remove(10)

