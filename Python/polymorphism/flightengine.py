class Flight:
    def __init__(self, engine):
        self.engine = engine

    def startEngine(self):
        self.engine.start()

class AirbusEngine:
    def start(self):
        print("Starting Airbus Engine")

class BoingEngine:
    def start(self):
        print("Starting Boing Engine")

#Examples of Dependency Injection
ae = AirbusEngine()
f1 = Flight(ae)
f1.startEngine()

be = BoingEngine()
f2 = Flight(be)
f2.startEngine()