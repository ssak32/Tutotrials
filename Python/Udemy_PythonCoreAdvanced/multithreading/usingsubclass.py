from threading import *

class MyThread(Thread):
    def run(self) -> None: # overriding the run method within Thread class
        print(current_thread().getName())
        i = 0
        while (i < 10):
            print(i)
            i += 1

t = MyThread()
t.start()
print(current_thread().getName())