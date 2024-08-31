using RabbitMQ.Client;
using System.Text;

//Open a connection factory with de hostname
var factory = new ConnectionFactory() { HostName = "localhost"};

//Create a "model" to publish the message
using (var connection = factory.CreateConnection())
using (var channel = connection.CreateModel())
{
    string strQueue = "BasicTest";

    //Declare queue parameters
    channel.QueueDeclare(strQueue, false, false, false, null);

    //Message that will be sent
    string message = "Getting Started with .Net 8 RabbitMQ";
    // Encoding to byte
    var body = Encoding.UTF8.GetBytes(message);

    //Publish to queue your message
    channel.BasicPublish("", strQueue, null, body);
    Console.WriteLine($"Sent message: {message}");
}

Console.WriteLine("Press Key [Enter] to exit the Sender App...");
Console.ReadLine();



