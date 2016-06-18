# Demo: WebApp security
This is a basic ASP.NET MVC app for showing some bad practices and exploits on them. Purpose of this project and demo is to show developers some easy steps to better protect their apps and customers.


# Exploits

## HTTP traffic capture
Pages and apps being served over plain HTTP are vounarble to traffic sniffing and man in a middle attack among other things. Traffic sniffing is easy to demonstrate using tools like Burp or Fiddler

## Query tampering
Occurs when a user (attacker) is changing the query parameters to change the behaviour of the app. Most often use of it is getting resources or data that don't belong to that user. Example exploit: in the app each user has it's orders, but order details page doesn't check for ownership, if a user would change order number it would show other users orders.

## Exception handling and stack


## Directory browsing
If you are retrieving any resource using code using file name as a parameter and not cleaning that parameter attacker could get access to any of your files. Example exploit would be on a link: Admin/readLog?filename=appsecurity.log where app receives a filename as a query parameter, if you substitute that with ex: ../web.config it's Game Over.

## XSS attack