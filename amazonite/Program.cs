
using System.ComponentModel.Design.Serialization;

Console.WriteLine(Guid.NewGuid()); //novo id
Console.WriteLine(new Guid("373b6b0e-9b86-4182-a581-d06f6b51cf2a")); //inicializa id com o id informado
Console.WriteLine(new Guid("373b6b0e-9b86-4182-a581-d06f6b51cf2a").ToString().Substring(0, 8)); //pega os 8 primeiros caracteres do id
Console.WriteLine(new Guid()); //somente inicializa um id
Console.WriteLine("Seu id é: " + Guid.NewGuid()); //interpolação de strings (converte valores para strings)
Console.WriteLine(string.Format("Seu id é: {0} neste momento e é {1}.", Guid.NewGuid(), true)); //interpolação com format
Console.WriteLine($"Seu id é: {Guid.NewGuid()} neste momento e é {true}."); //interpolação com $

Console.WriteLine($@"Seu id é: {Guid.NewGuid()} 
            Neste momento e é {true} com quebra de linha sem \n."); //quebra de linha de string com @ e não identifica caracteres especiais no codigo




