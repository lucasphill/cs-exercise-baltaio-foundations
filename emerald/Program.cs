
Menu();

static void Menu()
{
    Console.Clear();

    Thread.Sleep(300);

    Titulo();

    Console.WriteLine("\ns - Segundos (ex: 10s = 10 Segundos)");
    Console.WriteLine("m - Minutos (1m = 60 Segundos)");
    Console.WriteLine("0 - Finalizar o programa");
    Console.Write("Quanto tempo deseja contar? ");

    string data = Console.ReadLine()!.ToLower();

    //Validação de saída do programa ou dados errados
    if (data.Length == 1 && int.Parse(data) == 0)
    {
        Console.Clear();
        Console.WriteLine("Encerrando o programa.");
        Thread.Sleep(1000);
        Console.Clear();
        System.Environment.Exit(0);
    }
    else if (data.Length == 1 && int.Parse(data) != 0)
    {
        Console.Clear();
        Thread.Sleep(200);
        Console.WriteLine("Entrada incorreta. Insira o tempo conforme o menu.");
        Console.ReadKey();
        Menu();
    }

    int time = int.Parse(data.Substring(0, data.Length - 1));
    char type = char.Parse(data.Substring(data.Length - 1, 1));

    int multiplier = 1;

    //Validação da opção de minutos
    if (type == 'm')
    {
        multiplier = 60;
    }

    Start(time * multiplier);
}

static void Titulo()
{
    Console.WriteLine(@"
█▀▀ █▀█ █▀█ █▄░█ █▀█ █▀▄▀█ █▀▀ ▀█▀ █▀█ █▀█
█▄▄ █▀▄ █▄█ █░▀█ █▄█ █░▀░█ ██▄ ░█░ █▀▄ █▄█");
}

static void Start(int time = 10)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.WriteLine("Contador finalizado. Pressione enter para retornar ao menu.");
    Console.ReadKey();
    Menu();
}
