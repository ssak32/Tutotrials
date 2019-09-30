import threading

print("Current thread running: ", threading.current_thread().getName())

if threading.current_thread() == threading.main_thread():
    print("Main thread")
else:
    print("Other thread")