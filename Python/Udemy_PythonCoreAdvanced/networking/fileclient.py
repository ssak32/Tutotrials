# For the client to receive msg, make sure the 'fileserver.py' program is running.

import socket

s = socket.socket()

s.connect(("localhost", 2323))

fileName =  input("Enter a file name:")

s.send(fileName.encode())

content = s.recv(1024)

print(content.decode())

s.close()