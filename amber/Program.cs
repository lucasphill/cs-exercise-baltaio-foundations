using System.Globalization;

Console.Clear();

var valor = 10.75m;

Console.WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("pt-BR"))); //generico
Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); //currency
Console.WriteLine(valor.ToString("E04", CultureInfo.CreateSpecificCulture("pt-BR"))); //cientifica
Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR"))); //porcentagem
Console.WriteLine(valor.ToString("F", CultureInfo.CreateSpecificCulture("pt-BR"))); //precisão maior
Console.WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR"))); //sem formatação de moeda


Console.WriteLine(Math.Round(valor)); //remove os decimais do numero / arredonda para o mais proximo
Console.WriteLine(Math.Ceiling(valor)); //arredonda para cima
Console.WriteLine(Math.Floor(valor)); //arredonda para baixo

Console.WriteLine($"{valor:C}"); //outra forma de escrever a formatação
Console.WriteLine($"{valor:E04}"); //outra forma de escrever a formatação
