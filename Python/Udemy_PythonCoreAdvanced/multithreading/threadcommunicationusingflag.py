from threading import *
from time import *

class Producer:
    def __init__(self):
        self.products =[]
        self.ordersplaced = False

    def produce(self):

        for i in range(1, 5):
            self.products.append("Product_" + str(i))
            sleep(1)
            print("Product added")

        self.ordersplaced = True
        print("Orders placed")

class Consumer:
    def __init__(self, prod):
        self.prod = prod

    def consume(self):
        while self.prod.ordersplaced == False:
            print("Waiting for the orders")
            sleep(0.4)

        print("Orders shipping ", self.prod.products)

p = Producer()
c = Consumer(p)

#Consumer thread
ct = Thread(target=c.consume)
ct.start()

#Producer thread
pt = Thread(target=p.produce)
pt.start()