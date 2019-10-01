import mysql.connector

conn = mysql.connector.connect(host='localhost', database='mydb', user='root', password='Welcome')

if conn.is_connected():
    print("Connected to mysql db")

cursor = conn.cursor()

try:
    cursor.execute("insert into emp values(3, 'John', 10001)")
    conn.commit()
    print("Record inserted")
except:
    conn.rollback()
finally:
    cursor.close()
    conn.close()