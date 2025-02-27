using Confluent.Kafka;

namespace ConsoleApplication
{
    class Producer
    {
        public static async Task EnviarMensagensAsync()
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092" // Endereço do Kafka
            };

            using var producer = new ProducerBuilder<string, string>(config).Build();

            for (int i = 0; i < 5; i++)
            {
                var key = $"chave-{i}";
                var value = $"Mensagem {i} enviada para Kafka!";

                var result = await producer.ProduceAsync("meu-topico", new Message<string, string> { Key = key, Value = value });

                Console.WriteLine($"Mensagem enviada para {result.TopicPartitionOffset} | Chave: {key} | Valor: {value}");
            }

            producer.Flush(TimeSpan.FromSeconds(5)); // Garantir que as mensagens sejam enviadas antes de sair
        }
    }
}
