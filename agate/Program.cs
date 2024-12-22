using System.Reflection;

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("1 - Editar arquivo");
    Console.WriteLine("2 - Criar arquivo");
    Console.WriteLine("3 - Listar arquivos");
    Console.WriteLine("0 - Finalizar programa");

    Console.Write("Digite sua escolha: ");
    short opcao = short.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1: EditarArquivo(); break;
        case 2: CriarArquivo(); break;
        case 3: ListarArquivos(); break;
        case 0:
            Console.Clear();
            Console.WriteLine("Encerrando programa.");
            Thread.Sleep(2000);
            System.Environment.Exit(0);
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opção não encontrada, retornando ao menu.");
            Thread.Sleep(2300);
            Menu();
            break;
    }

}
static void EditarArquivo()
{
    Console.Clear();
    Console.WriteLine("Digite o texto no espaço abaixo. (ESC para sair): \n");

    string texto = "";

    do
    {
        texto += Console.ReadLine();
        texto += Environment.NewLine;
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Console.Write(texto);
}
static void CriarArquivo() { }
static void ListarArquivos() { }