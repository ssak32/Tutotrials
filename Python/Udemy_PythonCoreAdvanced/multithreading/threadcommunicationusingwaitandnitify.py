from threading import *
from time import *

class Producer:
    def __init__(self):
        self.products =[]
        self.c = Condition()

    def produce(self):
        self.c.acquire()
        for i in range(1, 5):
            self.products.append("Product_" + str(i))
            sleep(1)
            print("Product added")

        self.c.notify()
        self.c.release()
        print("Orders placed")

class Consumer:
    def __init__(self, prod):
        self.prod = prod

    def consume(self):
        self.prod.c.acquire()
        self.prod.c.wait(timeout=0)
        print("Orders shipping ", self.prod.products)
        self.prod.c.release()

p = Producer()
c = Consumer(p)

#Consumer thread
ct = Thread(target=c.consume)

#Producer thread
pt = Thread(target=p.produce)

pt.start()
ct.start()