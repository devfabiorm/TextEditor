﻿internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("1 - Abrir aquivo");
        Console.WriteLine("2 - Criar novo arquivo");
        Console.WriteLine("0 - Sair");

        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0: Environment.Exit(0); break;
            case 1: Abrir(); break;
            case 2: Editar(); break;
            default: Menu(); break;
        }
    }

    static void Abrir() { }

    static void Editar()
    {
        Console.Clear();

        Console.WriteLine("Digite seu texto abaixo");
        Console.WriteLine("-----------------------");
        string text = "";

        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine;
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        Salvar(text);
    }

    static void Salvar(string text)
    {
        Console.Clear();
        Console.WriteLine("Qual caminho para salvar o arquivo?");
        var path = Console.ReadLine();

        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }

        Console.WriteLine($"Arquivo {path} Salvo com sucesso!");
        Console.ReadKey(true);
        Menu();
    }
}