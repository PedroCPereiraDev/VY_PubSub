# INVOICE ENGINE — A proof of concept Invoice Sub/Pub

This software is a proof of concept of a system where invoices would be inserted via publishers, then their values would be manipulated and refined by the backend, and finally they would be sent via an Event Bus to all interested clients, who would receive the meaningful data already prepared.

With this repository and PoC we present a demonstration of the Publisher/Subscriber pattern in C# and .NET 8, without the use of any messaging frameworks, complete with a simple and fun visual interface to make it easy to see and manipulate the number of publishers and subscribers.

## Requirements
If you want to build and run our INVOICE ENGINE yourself, it is very simple, you will need:

- a Windows computer (You could also use other platforms but not natively and its use is out of this scope and not trivial)

- a modern IDE like Visual Studio 2022

- free time to play with the code and application 😁

## Local development
Once you have cloned the repository you can open the solution with your prefered IDE and develop. The repository comes with a .editorconfig file to maintain a standard type of styling convention across the develpers of the repository.

### Building and Running
Once you have all the dependencies working as expected, you may build and run the application.

Assuming all went well and that the code compiled without problems you should now be presented with a window with 2 buttons, one allows you to spin up an instance of a subscriber (Invoice Viewer) or of a publisher (Invoice Reporter).

You main spin up as many instances as you desire. On the publishers you will be able to insert a Invoice Number and Total Value (the software has some data valitions in place) and submit that data to the subscribers.

The subscribers will then receive the manipulated data sent by the publishers and present it in a simple table.

A final action you can do is press the DISCONNECT button on the subscribers, this will unsubscribe that instance, meaning all others should remain receiving events except that one.

## Considerations
Before taking on this assingnement I did use this pattern professionaly when dealing with solutions that required/used for exemple SignalR or other similar frameworks, but had never actually created an application of this sort in pure C# code.
Still I believe it was a good experience and it let me brush up on the concepts of delegates which is something I have only used very little once in a while.

At first I thought of doing several different implementations, but along development I came to realize I was over-complicating something simple and running away from the intended focus of the exercise.
As such I took note of some of those ideas and will present them as possible improvements.

## Improvements list
In this section, I will be listing the improvements I would perform on this assignment:

1) I could implement logic to deal with TOPICS, for example I could maintain the current flow, as a Invoice topic, but add a new topic called QUOTES. There publishers would send quotes given to the company and they would be received only by subscribers interested in quotes.

2) In this iteration due to dealing with exceptions we are processing the subscriptions in a syncronous way. In future I could develop a way to call the event subscribers in parallel, thus decreasing total latency.

3) One of my first ideas was to use a connection to a T-SQL database to persist data and to retrieve it when the application started, but for just one simple table with little data it was hitting a nail with a cannon, but it could be valid as an improvement, specially if the code turns more complex with more topics.

4) I used a simple Dependency Injection using the standard library from Microsoft, in future I could use other library or at least organize better the dependency injection in its own classes and methods. In this iteration it was so simple it made sense to stay in the Program.cs

5) The final improvement would be logs, specially in the exception handling block of the broker, where instead of throwing a aggregated exception we could log the issue and keep the application alive.

## Feedback
Feedback on improvement points, tips to implement the improvement list or just new ideas that can make this application better, more reliable, secure and performative are always welcome and will be discussed and iterated upon. Therefore, feel free to reach out to me. :) 

## Maintainers
| Name                | Github            | Role                               |
|---------------------|-------------------|------------------------------------|
| Pedro Costa Pereira | @PedroCPereiraDev | Repository Owner                   |