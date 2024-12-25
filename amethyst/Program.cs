
var arr = new int[3];

try
{
    // for (var index = 0; index < 10; index++)
    // {
    //     Console.WriteLine(arr[index]);
    // }

    Salvar("");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.InnerException);
    Console.WriteLine("Index não encontrado..");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.InnerException);
    Console.WriteLine("Falha ao salvar");
}
catch (MinhaException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.QuandoAconteceu);
    Console.WriteLine("Minha Exception");
}
catch (Exception nomeException)
{
    Console.WriteLine(nomeException.Message);
    Console.WriteLine(nomeException.InnerException);
}
finally //sempre é executado
{
    Console.WriteLine("Chegou ao fim..");
}

static void Salvar(string texto)
{
    if (string.IsNullOrEmpty(texto))
    {
        // throw new Exception("O texto não pode ser nulo ou vazio.");
        // throw new ArgumentNullException("O texto não pode ser nulo ou vazio."); //essa string será enviada para o "Message" do exception acima (Catch da função raiz)
        throw new MinhaException(DateTime.Now);

    }
}

public class MinhaException : Exception
{
    public MinhaException(DateTime date)
    {
        QuandoAconteceu = date;
    }

    public DateTime QuandoAconteceu { get; set; }
}