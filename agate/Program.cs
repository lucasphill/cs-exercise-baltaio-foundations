using System.Reflection;
using System.IO;
using System.Linq.Expressions;
// using System.Xml.Serialization;

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("1 - Editar arquivo");
    Console.WriteLine("2 - Criar arquivo");
    Console.WriteLine("3 - Listar arquivos");
    Console.WriteLine("4 - Excluir um arquivo");
    Console.WriteLine("0 - Finalizar programa");

    Console.Write("Digite sua escolha: ");
    try
    {
        short opcao = short.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1: AbrirArquivo(); break;
            case 2: CriarArquivo(); break;
            case 3: ListarArquivos(); break;
            case 4: ExcluirArquivo(); break;
            case 0:
                Console.Clear();
                Console.WriteLine("Encerrando programa.");
                Thread.Sleep(2000);
                System.Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine("Opção não encontrada, retornando ao menu.");
                Thread.Sleep(1500);
                Menu();
                break;
        }
    }
    catch
    {
        Console.WriteLine("Opção inserida errada. Retornando ao menu...");
        Thread.Sleep(2000);
        Menu();
    }

}

static string GetDir()
{
    var currDir = System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())!; ;
    var actualDir = currDir + """\agate\.txt\""";

    return actualDir;
}

static void CriarArquivo()
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

    Salvar(texto);
}

static void AbrirArquivo()
{
    Console.Clear();
    Console.WriteLine("Qual o nome do arquivo?");
    string nome = Console.ReadLine()!;
    var path = GetDir() + nome + """.txt""";

    if (File.Exists(path))
    {
        using (var file = new StreamReader(path))
        {
            string texto = file.ReadToEnd();
            Console.WriteLine(texto);
        }

        Console.ReadKey();
        Menu();
    }
    else
    {
        Console.WriteLine($"Arquivo '{nome}' não encontrado. Retornando ao menu...");
        Thread.Sleep(2000);
        Menu();
    }
}

static void ListarArquivos()
{
    Console.Clear();

    var dir = GetDir();
    string[] filePaths = Directory.GetFiles(dir);

    foreach (string path in filePaths)
    {
        Console.WriteLine(path);
    }

    Console.WriteLine("\nPressione enter para retornar ao menu");
    Console.ReadKey();

    Menu();
}

static void Salvar(string texto)
{
    Console.Clear();
    Console.WriteLine("Qual o nome do arquivo?");
    var nome = Console.ReadLine()!;
    var path = GetDir() + nome + ".txt";
    Console.WriteLine(path);

    //Permite usar um arquivo sem correr o risco de abrir sem fechar e travar o arquivo
    using (var file = new StreamWriter(path))
    {
        file.Write(texto);
    }

    Console.WriteLine($"Arquivo salvo {path} com sucesso. Retornando ao menu...");
    Thread.Sleep(2000);
    Menu();
}

static void ExcluirArquivo()
{
    Console.Clear();
    Console.WriteLine("Qual o nome do arquivo que deseja excluir?");
    var nome = Console.ReadLine();
    var path = GetDir() + nome + """.txt""";

    if (File.Exists(path))
    {
        // If file found, delete it
        File.Delete(Path.Combine(path));
        Console.WriteLine($"Arquivo '{nome}' excluido com sucesso. Retornando ao menu...");
        Thread.Sleep(2000);
        Menu();
    }
    else
    {
        Console.WriteLine($"Arquivo '{nome}' não encontrado. Retornando ao menu...");
        Thread.Sleep(2000);
        Menu();
    }



}