from threading import *
import time

class MyThread:
    def displayNumbers(self):
        i = 0
        while (i < 10):
            print(current_thread().getName() + " -> " + str(i))
            time.sleep(0.25)
            i += 1

print(current_thread().getName())
obj = MyThread()
t = Thread(target=obj.displayNumbers)
t.start()

t2 = Thread(target=obj.displayNumbers)
t2.start()

t3 = Thread(target=obj.displayNumbers)
t3.start()
