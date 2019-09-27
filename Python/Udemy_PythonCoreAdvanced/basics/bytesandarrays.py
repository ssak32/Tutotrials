'''
Bytes
1. Cannot perform Add or Modify a Byte. ByteArray on the other hand do the same
2. No slicing or repetation allowed either on Byte or ByteArray
'''

lst=[20,30,40,244]
print(type(lst))
b=bytes(lst)
print(type(b))
#b[2]=22

b1=bytearray(lst)
print(type(b1))
b1[2]=22
print(b1)