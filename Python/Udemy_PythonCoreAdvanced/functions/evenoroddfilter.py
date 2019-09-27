lst=[10,2,33,45,89,2]

#filter even numbers using Filter method
result = filter(lambda x:x%2==0, lst)
print(list(result))