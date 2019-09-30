import socket

host = 'localhost'
port = 4000

s = socket.socket()

s.bind((host, port))

print("Server listing on port: ", port)
s.listen(1)

c, addr = s.accept()

print("Connection from: ", str(addr))

c.send(b"Hello, how are you?") #converting string into binary
c.send("bye".encode()) #other way of sending message

c.close()