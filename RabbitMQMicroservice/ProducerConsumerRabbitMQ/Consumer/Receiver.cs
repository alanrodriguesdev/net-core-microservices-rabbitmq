using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

var factory = new ConnectionFactory() { HostName = "localhost"};
using (var connection = factory.CreateConnection())
using (var channel = connection.CreateModel())
{
    string strQueue = "BasicTest";

    channel.QueueDeclare(strQueue,false,false,false,null);

    var consumer = new EventingBasicConsumer(channel);

    consumer.Received += (model, ea) =>
    {
        var body = ea.Body;
        var message = Encoding.UTF8.GetString(body.ToArray());

        Console.WriteLine($"Received message {message}");
    };

    channel.BasicConsume(strQueue,true,consumer);
    Console.WriteLine("Press [Enter] to exitthe consumer");
    Console.ReadLine();
}