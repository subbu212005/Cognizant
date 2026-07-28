using Confluent.Kafka;

var config = new ProducerConfig
{
    BootstrapServers = "localhost:9092"
};

using var producer = new ProducerBuilder<Null, string>(config).Build();

await producer.ProduceAsync("chat-message",
    new Message<Null, string>
    {
        Value = "Hello from C# Kafka Producer"
    });

Console.WriteLine("Message Sent Successfully.");