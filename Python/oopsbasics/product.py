class Product:

    def __init__(self):
        self.name = "Samsung"
        self.description = "Its Awesome"
        self.price = 12000

    def display(self):
        print(self.name)
        print(self.description)
        print(self.price)

p1 = Product()
p1.display()