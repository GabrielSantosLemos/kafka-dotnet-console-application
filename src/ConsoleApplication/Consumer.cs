using Confluent.Kafka;

namespace ConsoleApplication
{
    class Consumer
    {
        public static void ConsumirMensagens()
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "meu-grupo",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<string, string>(config).Build();
            consumer.Subscribe("meu-topico");

            Console.WriteLine("Aguardando mensagens...");

            try
            {
                while (true)
                {
                    var consumeResult = consumer.Consume(CancellationToken.None);
                    Console.WriteLine($"Recebido: {consumeResult.Message.Value} | Chave: {consumeResult.Message.Key}");
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Encerrando consumidor...");
            }
            finally
            {
                consumer.Close();
            }
        }
    }
}
