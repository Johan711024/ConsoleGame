internal class Game
{


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
            //GetCommand
            GetCommand();
            //Act
            //DrawMap
            //EnemyAction
            //DrawMap

        } while (gameInProgress);
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
        
    }
}