import re

str = "Take up one idea. One idea at a time"
result = re.search(r'o\w*', str) #string starting with 'o' and any number of characters there after.
print(result.group())

str = "Take up one idea. one idea at a time"
result = re.findall(r'o\w\w', str) #returns a list
print(result)

str = "Take up one idea. one idea at a time"
result = re.match(r'o\w\w', str) #returns a list #match method works only on starting of the string
print(result)

str = "Take 1 up 25 idea. 28 idea at a time"
result = re.split(r'\d+', str)
print(result)

str = "Take up one idea. One idea at a time"
result = re.sub(r'One', 'Two', str)
print(result)

str = "Take 29-09-2019 up 25 idea. 28 idea at a time"
result = re.findall(r'\d{1,2}-\d{1,2}-\d{4}', str)
print(result)

