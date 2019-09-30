import urllib.request

try:
    url = urllib.request.urlopen("https://www.python.org")
    content = url.read()
except urllib.error.HTTPError:
    print("Page not found error")
    exit()

f = open("python.html", "wb")
f.write(content)
f.close()
