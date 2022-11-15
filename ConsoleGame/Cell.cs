internal class Cell : IDrawable
{
    public Cell(Position position)
    {
        Color = ConsoleColor.Red;
        Position = position;
    }

    public string Symbol => ". ";

    public ConsoleColor Color { get; }
    public Position Position { get; set; }
}