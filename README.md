# Stock-Price-Tracker-App
This app has two modules, Service and Client. Service module act as publisher and publish the event whenever the stock Price changed, and Client module subscribe to the event published by the Service module.

To simulate these module, in the Program.cs, I have subscribed for 2 stocks {Stock1, Stock2}. And unsubscribing them after some second to simulate both subscribe and unsubscribe.

