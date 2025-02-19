//// See https://aka.ms/new-console-template for more information
//using EasyNetQ;
//using eGostujucaPredavanja.Model.Messages;

//Console.WriteLine("Hello, World!");

//// Istanciramo bus
//var bus = RabbitHutch.CreateBus("host=localhost:5672");



//await bus.PubSub.SubscribeAsync<EventUpdatet>("seminarski", msg =>
//    {
//        Console.WriteLine($"Doslo je do izmjena kod sljedeceg eventa: {msg.eventDetails.Title}. Molimo provjerite izmjene. ");
//});
//Console.WriteLine("Listening for message, pres eny key to close");

//Console.ReadLine();

using EasyNetQ;
using eGostujucaPredavanja.Model.Messages;

Console.WriteLine("Hello, World!");


var bus = RabbitHutch.CreateBus("host=localhost:5672");


await bus.PubSub.SubscribeAsync<EventUpdatet>("my_subscription_id", msg =>
{
    Console.WriteLine($"Product activated:  {msg.EventDetails.Title}");
});

Console.WriteLine("Lisening for messages, press <return> to closse! ");
Console.ReadLine();