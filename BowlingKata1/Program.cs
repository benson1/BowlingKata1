// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Game
{
    private List<int> Bowls = new List<int>();
    public int GetScore()
    {
        int score = 0;
        for (int i = 0; i < Bowls.Count; i++)
        {
        score += Bowls[i];
        }
        return score;
    }
        public void BowlTheBall(int pins)
        {
            Bowls.Add(pins);
        }
    }