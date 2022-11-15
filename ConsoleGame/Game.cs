using ConsoleGame;
using System.Data;

internal class Game
{
    private Map map = null!;
    private Hero hero = null!;

    public Game()
    {
        
    }

    internal void Run()
    {
        Initialize();
        Play();

    }

    private void Play()
    {
        bool gameInProgress = true;

        do
        {
            //DrawMap
            DrawMap();
            //GetCommand
            GetCommand();
            //Act
            //DrawMap
            
            //EnemyAction
            //DrawMap

        } while (gameInProgress);
    }

    private void DrawMap()
    {
        Console.Clear();

        for(int y = 0; y < map.Height; y++)
        {
            for (int x = 0; x < map.Width; x++)
            {
                Cell? cell = map.GetCell(y, x);
                ArgumentNullException.ThrowIfNull(cell, nameof(cell));
                IDrawable drawable = cell;

                drawable = map.Creatures.CreataureAtExtension(cell);

                Console.ForegroundColor = drawable.Color;
                Console.Write(drawable.Symbol);

            }
            Console.WriteLine();
        }
        Console.ForegroundColor = ConsoleColor.White;


    }


    private void GetCommand()
    {
        var KeyPressed = ConsoleUI.GetKey();

        switch (KeyPressed)
        {
            case ConsoleKey.LeftArrow:
                Console.WriteLine("vä");
                break;
            case ConsoleKey.RightArrow:
                Console.WriteLine("hö");
                break;
            case ConsoleKey.UpArrow:
                Console.WriteLine("upp");
                break;
            case ConsoleKey.DownArrow:
                Console.WriteLine("ner");
                break;
            case ConsoleKey.Q:
                Environment.Exit(0);
                break;
        }
    }

    private void Initialize()
    {
        //ToDo read this from a config file
        map = new Map(width: 10, height: 10);

        var heroCell = map.GetCell(0, 0)!;
        hero = new Hero(heroCell);
        map.Creatures.Add(hero);
    }
}