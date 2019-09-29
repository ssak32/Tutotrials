from datetime import *

d = date(2019, 9, 29)
t = time(20, 52)
dt = datetime.combine(d, t)
print(dt)