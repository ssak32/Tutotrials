import time, datetime

epochseconds = time.time()
print(epochseconds)

t = time.ctime(epochseconds)
print(t)

dt = datetime.datetime.today()
print(dt.day, dt.month, dt.year)
print(dt.hour, dt.minute, dt.second)