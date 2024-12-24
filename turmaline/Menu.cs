using System;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Black;
        DrawScreen();
        WriteOptions();
        short option = short.Parse(Console.ReadLine()!);
        HandleMenuOption(option);
    }

    public static void WriteOptions()
    {
        Console.SetCursorPosition(2, 1);
        Console.WriteLine("Editor HTML");
        DrawLine(30);
        Console.SetCursorPosition(2, 3);
        Console.WriteLine("1 - Novo arquivo");
        Console.SetCursorPosition(2, 4);
        Console.WriteLine("2 - Abrir arquivo\n");
        Console.SetCursorPosition(2, 6);
        Console.WriteLine("0 - Sair");
        Console.SetCursorPosition(2, 7);
        Console.Write("O que deseja fazer? ");
    }

    public static void DrawScreen()
    {
        int spaces = 30; // Posições horizontais
        int lines = 7; //Posições verticais / Linhas

        DrawLine(spaces);
        DrawBorder(lines, spaces);
        DrawLine(spaces);
    }
    public static void DrawLine(int spaces)
    {
        Console.Write("+");
        for (int i = 0; i < spaces; i++)
        {
            Console.Write("-");
        }
        Console.Write("+\n");
    }
    public static void DrawBorder(int lines, int spaces)
    {
        for (int line = 0; line < lines; line++)
        {
            Console.Write("|");
            for (int space = 0; space < spaces; space++)
            {
                Console.Write(" ");
            }
            Console.Write("|\n");
        }
    }

    public static void HandleMenuOption(short option)
    {
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("Abrir"); break;
            case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
            default: Menu.Show(); break;
        }
    }
}

