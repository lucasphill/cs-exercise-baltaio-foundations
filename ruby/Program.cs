using System;

Menu();

static void Menu()
{
    Console.Clear();
    Thread.Sleep(400);

    Console.WriteLine("Qual operação deseja fazer:");

    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("0 - Encerrar");

    Thread.Sleep(300);
    Console.Write("\nDigite sua escolha: ");
    short escolha = short.Parse(Console.ReadLine()!);

    switch (escolha)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 0: System.Environment.Exit(0); break;
        default: Console.WriteLine("Opção não encontrada. Pressione qualquer botão para retornar."); Console.ReadKey(); break;
    }

    Menu();
}

static void Titulo(string titulo)
{
    Console.Clear();
    Console.WriteLine("------" + titulo + "------");
}

static void Soma()
{
    Titulo("Soma");

    Console.Write("Primeiro valor: ");
    decimal valor1 = decimal.Parse(Console.ReadLine()!);

    Console.Write("Segundo valor: ");
    decimal valor2 = decimal.Parse(Console.ReadLine()!);

    Console.Write($"\nO Resultado da soma é: {valor1 + valor2}");

    Console.ReadKey();
}

static void Subtracao()
{
    Titulo("Subtração");

    Console.Write("Primeiro Valor: ");
    double valor1 = double.Parse(Console.ReadLine()!);

    Console.Write("Segundo Valor: ");
    double valor2 = double.Parse(Console.ReadLine()!);

    Console.Write($"\nO resultado da subtração é: {valor1 - valor2}");

    Console.ReadKey();
}

static void Divisao()
{
    Titulo("Divisão");

    Console.Write("Primeiro valor: ");
    decimal valor1 = decimal.Parse(Console.ReadLine()!);

    Console.Write("Segundo valor: ");
    decimal valor2 = decimal.Parse(Console.ReadLine()!);

    Console.WriteLine($"\nO resultado da divisão é: {valor1 / valor2}");

    Console.ReadKey();
}

static void Multiplicacao()
{
    Titulo("Multiplicação");

    Console.Write("Primeiro valor: ");
    double valor1 = double.Parse(Console.ReadLine()!);

    Console.Write("Segundo valor: ");
    double valor2 = double.Parse(Console.ReadLine()!);

    Console.WriteLine($"\nO resultado da multiplicação é: {valor1 * valor2}");

    Console.ReadKey();
}