class ObjectCounter:
    ObjectCount = 0

    def __init__(self):
        ObjectCounter.ObjectCount += 1


OC1 = ObjectCounter()
OC2 = ObjectCounter()
OC3 = ObjectCounter()
OC4 = ObjectCounter()
OC5 = ObjectCounter()

print(ObjectCounter.ObjectCount)