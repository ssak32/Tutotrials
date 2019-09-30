from threading import *

class BookMyBus:

    def __init__(self, availableSeats):
        self.availableSeats = availableSeats

        self.l = Lock() #Lock approach for locking an object
        # self.l = Semaphore() #Semaphore approach for locking an object

    def buy(self, seatsRequested):

        self.l.acquire()

        print("-------------------")
        print("Requested seat(s) {}".format(seatsRequested))

        if self.availableSeats >= seatsRequested:
            print("Confirming seat(s)")
            print("Payment processing")
            print("Ticket printing(s)")
            self.availableSeats -= seatsRequested
        else:
            print("Sorry! {} seat(s) available".format(self.availableSeats))

        self.l.release()

obj = BookMyBus(5)
t1 = Thread(target = obj.buy, args=(3,)) #Adding a comma after the argument in args, converts it into a list obj.
t2 = Thread(target = obj.buy, args=(1,))
t3 = Thread(target = obj.buy, args=(4,))

t1.start()
t2.start()
t3.start()