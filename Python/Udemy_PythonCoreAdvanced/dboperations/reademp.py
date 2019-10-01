import mysql.connector

conn = mysql.connector.connect(host='localhost', database='mydb', user='root', password='Welcome')

if conn.is_connected():
    print("Connected to mysql db")

cursor = conn.cursor()

cursor.execute('select * from emp')

rows = cursor.fetchall()
print("Total number of records:", cursor.rowcount)

for row in rows:
    print(row)

cursor.close()

conn.close()