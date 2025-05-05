namespace Arthur_Rodrigues_DR4_TP1
{
    internal class Program
    {
        delegate double CalculateDiscount(double OriginalPrice);
        static double AplicarDesconto10(double price)
        {
            return price * 0.90; // Aplica 10% de desconto
        }
        static void Main(string[] args)
        {
            //Questão 01 --------------------------------------------------------------
            /*
            Console.Write("Informe o preço original do produto: ");
            string sPreco = Console.ReadLine();
            double precoOriginal = double.Parse(sPreco);

            CalculateDiscount desconto = new CalculateDiscount(AplicarDesconto10);
            double precoComDesconto = desconto(precoOriginal);

            Console.WriteLine($"\nPreço original: R$ {precoOriginal:F2}");
            Console.WriteLine($"Preço com 10% de desconto: R$ {precoComDesconto:F2}");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            */

            //Questão 02 --------------------------------------------------------------
            /*
            Action<string> mensagemPortugues = nome => Console.WriteLine($"Bem-vindo, {nome}!");
            Action<string> mensagemIngles = nome => Console.WriteLine($"Welcome, {nome}!");
            Action<string> mensagemEspanhol = nome => Console.WriteLine($"¡Bienvenido, {nome}!");

            Console.Write("Escolha o idioma (pt, en, es): ");
            string idioma = Console.ReadLine();

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            if (idioma == "pt")
            {
               mensagemPortugues(nome);
            }
            else if (idioma == "en")
            {
                mensagemIngles(nome);
            }
            else if (idioma == "es")
            {
               mensagemEspanhol(nome);
            }
            else
            {
               Console.WriteLine($"Idioma não reconhecido. Olá, {nome}!");
            }
            */

            //Questão 03 --------------------------------------------------------------
            /*
            Console.Write("Digite a base do retângulo: ");
            double baseRetangulo = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            double alturaRetangulo = double.Parse(Console.ReadLine());

            Func<double, double, double> calcularArea = (b, h) => b * h;

            double area = calcularArea(baseRetangulo, alturaRetangulo);
            Console.WriteLine($"\nA área do retângulo é: {area:F2}");
            */

            //Questão 04 --------------------------------------------------------------
            /*
            TemperatureSensor sensor = new TemperatureSensor();
            sensor.TemperatureExceeded += Sensor_TemperatureExceeded;

            while (true)
            {
                Console.Write("Digite a temperatura lida: ");
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "sair")
                    break;

                if (double.TryParse(entrada, out double temperatura))
                {
                    sensor.ReadTemperature(temperatura);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um valor numérico.");
                }
            }

            static void Sensor_TemperatureExceeded(object sender, double temperatura)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"⚠ ALERTA: Temperatura crítica detectada! ({temperatura}°C)");
                Console.ResetColor();
            }
            */

            //Questão 05 --------------------------------------------------------------
            /*
            DownloadManager manager = new DownloadManager();
            manager.DownloadCompleted += DownloadFinishedHandler;
            manager.StartDownload();

            static void DownloadFinishedHandler(object sender, EventArgs e)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("✅ Download concluído com sucesso!");
                Console.ResetColor();
            }
            */

            //Questão 06 --------------------------------------------------------------
            /*
            Logger logger = new Logger();
           
            Action<string> logDelegate = logger.LogToConsole;
            logDelegate += logger.LogToFile;
            logDelegate += logger.LogToDatabase;
        
            Console.Write("Digite a mensagem de log: ");
            string mensagem = Console.ReadLine();

            logDelegate(mensagem);

            Console.WriteLine("\nMensagem registrada em todos os destinos.");
            */

            //Questão 07 --------------------------------------------------------------
            /*
            Logger logger = new Logger();

            Action<string> logDelegate = null;

            Console.Write("Digite a mensagem de log: ");
            string mensagem = Console.ReadLine();

            logDelegate?.Invoke(mensagem);

            Console.WriteLine("\nNenhum destino configurado. Nada foi registrado.\n");

            logDelegate += logger.LogToConsole;
            logDelegate += logger.LogToFile;
            logDelegate += logger.LogToDatabase;

            logDelegate?.Invoke(mensagem);

            Console.WriteLine("\nMensagem registrada com sucesso em todos os destinos.");
            */
        }
    }
}
