// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Game
{
    private int Score = 0;
    public int GetScore() => Score;
    public void BowlTheBall(int pins)
    {
        Score += pins;
    }
}