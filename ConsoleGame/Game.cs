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
        //var KeyPressed = ConsoleUI
    }

    private void Initialize()
    {
        
    }
}