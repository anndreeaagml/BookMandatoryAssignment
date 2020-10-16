# BookMandatoryAssignment

1.	Explain how the addressing process in-process communication is and how to process communication happens using sockets.

Sockets are connection points between the network and the application. The process sends and receives data through it. Every process has a unique port number and the host on which the process runs on has an IP address. These two combined create an identifier. 

2.	 Suppose you wanted to do a transaction from a remote client to a server as fast as possible. would you use UDP or TCP? Why?

UDP is faster than TCP, this is because UDP does not need to recognize the packet that permits continuous packet stream, instead of TCP that Acknowledges a set of packets.
UDP does not need to establish the connection (which can add delay). No connection state at the sender and receiver. Instead, TCP is a connection-oriented - setup required between client and server processes (the handshake).

3.	 Explain how browsers use the HTTP to retrieve web pages. Your explanation must include the HTTP request and response format

When the DNS server finds the IP address, the browser sent an HTTP request message to the server asking for the website to the client.  If the server approves the client's request, the server sends to the client a 200 OK response message and then starts sending the website's file to the browser as a series of small packet called data packet. The browser then assembles this small packet into a complete website and display it to the client. 

4.	What is the role of HTTP? Why is it called a stateless protocol?

HTTP is a protocol in which the main function is to establish a connection with the server and send an HTML page back to the user. The HTTP protocol is called the Stateless protocol because the server maintains no information about the past client requests.


5.	 What is the role of a Proxy server (Caching)?

The goal of a proxy server (caching) is to satisfy the client without involving the origin server. It reduces the response time for client requests, reduces traffic on an institution’s access link, and the internet dense with caches: it enables “the poor” content providers to effectively deliver content.


6.	How web applications/sites identify users. Explain how cookies are used for this purpose.

When you browse a website for the first time, let's just say for this example it’s an E-Commerce, the website puts a cookie on the Hard drive that has its unique identification code. The website then uses this ID to keep track of your section, the section being your overall visits from start to finish. The reason it does this is to track which item you put in your shopping cart, which item did you loop at, so it suggests similar items or perform authorizations and can be used for you even if you close the website and come back to it.

7.	What is the role of the DNS server?

The role of the Domain Name System is to translate the domain name to an IP address. For example, when users type www.instagram.com into web browsers, the DNS is responsible to find the correct IP address for the web site.
