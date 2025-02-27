using ConsoleApplication;

class Program
{
    static async Task Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Enviar mensagens");
            Console.WriteLine("2 - Consumir mensagens");

            var escolha = Console.ReadLine();

            if (escolha == "1")
            {
                await Producer.EnviarMensagensAsync();
            }
            else if (escolha == "2")
            {
                Consumer.ConsumirMensagens();
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}
