import socket

host = 'localhost'
port = 2323

s = socket.socket()

s.bind((host, port))

print("Server listing on port: ", port)
s.listen(1)

c, addr = s.accept()

fileName = c.recv(1024)

try:
    f = open(fileName, 'rb')
    content = f.read()
    c.send(content)
except FileNotFoundError:
    c.send(b"File does not exist")
finally:
    f.close()

c.close()