using Confluent.Kafka;

var config = new ConsumerConfig
{
    BootstrapServers = "localhost:9092",
    GroupId = "chat-group",
    AutoOffsetReset = AutoOffsetReset.Earliest
};

using var consumer =
    new ConsumerBuilder<Ignore, string>(config).Build();

consumer.Subscribe("chat-message");

Console.WriteLine("Waiting for Messages...\n");

while (true)
{
    var result = consumer.Consume();

    Console.WriteLine(result.Message.Value);
}