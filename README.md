# Stock-Price-Tracker-App
This app has two modules, Service and Client. Service module act as publisher and publish the event whenever the stock Price changed, and Client module subscribe to the event published by the Service module.

To simulate these module, in the Program.cs, I have subscribed for 2 stocks {Stock1, Stock2}. And unsubscribing them after some second to simulate both subscribe and unsubscribe.

Here’s the output when run this application.

Stock price changed, Stock price of Stock2 is 185.68118307538384 at 2019-11-11 1:26:38 AM
Stock price changed, Stock price of Stock1 is 260.13883832382913 at 2019-11-11 1:26:38 AM
Stock price changed, Stock price of Stock2 is 192.7184442303695 at 2019-11-11 1:26:39 AM
Stock price changed, Stock price of Stock1 is 249.1949291337258 at 2019-11-11 1:26:39 AM
Unsubscribing for Stock1
Stock price changed, Stock price of Stock2 is 198.00691495556705 at 2019-11-11 1:26:41 AM
Stock price changed, Stock price of Stock2 is 185.63264270575374 at 2019-11-11 1:26:42 AM
Unsubscribing for Stock2
