
using System.ComponentModel.Design.Serialization;
using System.Text;

Console.Clear();
Console.WriteLine(Guid.NewGuid()); //novo id
Console.WriteLine(new Guid("373b6b0e-9b86-4182-a581-d06f6b51cf2a")); //inicializa id com o id informado
Console.WriteLine(new Guid("373b6b0e-9b86-4182-a581-d06f6b51cf2a").ToString().Substring(0, 8)); //pega os 8 primeiros caracteres do id
Console.WriteLine(new Guid()); //somente inicializa um id
Console.WriteLine("Seu id é: " + Guid.NewGuid()); //interpolação de strings (converte valores para strings)
Console.WriteLine(string.Format("Seu id é: {0} neste momento e é {1}.", Guid.NewGuid(), true)); //interpolação com format
Console.WriteLine($"Seu id é: {Guid.NewGuid()} neste momento e é {true}."); //interpolação com $

Console.WriteLine($@"Seu id é: {Guid.NewGuid()} 
            Neste momento e é {true} com quebra de linha sem \n."); //quebra de linha de string com @ e não identifica caracteres especiais no codigo


var texto = "Testando as comparações de string";
Console.WriteLine(texto.CompareTo("testando")); //compareto retorna um int
Console.WriteLine(texto.CompareTo("Testando"));
Console.WriteLine(texto.Contains("Test")); //retorna bool
Console.WriteLine(texto.Contains("test", StringComparison.OrdinalIgnoreCase)); //ignora case sensitive

Console.WriteLine(texto.StartsWith("Testa")); //compara o inicio da string
Console.WriteLine(texto.StartsWith("testa"));
Console.WriteLine(texto.EndsWith("String")); //compara o final da string
Console.WriteLine(texto.EndsWith("string"));
Console.WriteLine(texto.EndsWith("de"));

Console.WriteLine(texto.Equals("Testando as comparações de string")); //retorna true ou false
Console.WriteLine(texto.Equals("Testando AS comparações de string")); //É CASE SENSITIVE

Console.WriteLine(texto.IndexOf("õ")); //mostra o indice do primeiro caractere na string
Console.WriteLine(texto.LastIndexOf("s")); //mostra o indice do ultimo caractere na string

Console.WriteLine(texto.ToLower()); //converte todo para minúsculo
Console.WriteLine(texto.ToUpper()); //converte todo para maiúsculo

Console.WriteLine(texto.Insert(5, "novo insert ")); //insere uma string na posição informada
Console.WriteLine(texto.Remove(5, 6)); //Remove os 6 caracteres após o 5 indice
Console.WriteLine(texto.Length); //Mostra a quantidade de caracteres que uma string tem

Console.WriteLine(texto.Trim()); //remove os espaços antes e depois da string
Console.WriteLine(texto.Replace("a", "X")); //substitui os caracteres

var lista = texto.Split(" "); //separa a string em uma lista
Console.WriteLine(lista[0]);
Console.WriteLine(lista[1]);
Console.WriteLine(lista[2]);
Console.WriteLine(lista[3]);
Console.WriteLine(lista[4]);

Console.WriteLine(texto.Substring(9, 5));
Console.WriteLine(texto.Substring(9, (texto.LastIndexOf("s") - 9)));

var novotexto = new StringBuilder();
novotexto.Append(texto);
novotexto.Append(texto);
novotexto.Append(texto);
novotexto.Append(texto);
Console.WriteLine(novotexto.ToString());

Console.WriteLine(texto += " aqui");