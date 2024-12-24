using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

public class Viewer
{
    public static void Show(string texto)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Clear();
        Console.WriteLine("MODO DE VISUALIZAÇÃO\n");
        Replace(texto);
        Console.ReadKey();
        Menu.Show();
    }

    public static void Replace(string texto)
    {
        var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
        var words = texto.Split(" ");

        for (var i = 0; i < words.Length; i++)
        {
            if (strong.IsMatch(words[i]))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(
                    words[i].Substring(
                        words[i].IndexOf('>') + 1,
                        ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')))
                );
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(words[i]);
                Console.Write(" ");
            }
        }
    }
}