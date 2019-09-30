import smtplib
from email.mime.text import MIMEText

body = "This is the test email from Python program"

msg = MIMEText(body)
msg['From'] = "ssak32@gmail.com"
msg['To'] = "ssak32@gmail.com"
msg['Subject'] = "This is the test email from Python program"

server = smtplib.SMTP('smtp.gmail.com', 587)

server.starttls()

server.login("ssak32@gmail.com", 'password')

server.send_message("msg")

print("Mail sent!")

server.quit()