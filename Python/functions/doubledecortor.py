def decor(func):
    def inner():
        result = func()
        return result*2
    return inner

@decor
def num():
    return 5

print(num())