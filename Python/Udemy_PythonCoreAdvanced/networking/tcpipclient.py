# For the client to receive msg, make sure the 'tcpipserver.py' program is running.

import socket

s = socket.socket()

s.connect(("localhost", 4000))

msg = s.recv(1024)

while msg:
    print("Received: ", msg.decode())
    msg = s.recv(1024)

s.close()