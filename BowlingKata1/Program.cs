// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Game
{
    private List<int> Bowls = new List<int>();
    public int GetScore()
    {
        int score = 0;
        int frameIndex = 0;
        for (int frame = 0; frame < 10; frame++)
        {
            if (IsSpare(frameIndex))
            {
                score += SpareBonus(frameIndex);
                frameIndex += 2;
            }
            else
            {
                score += Bowls[frameIndex] + Bowls[frameIndex + 1];
                frameIndex += 2;
            }
        }
        return score;
    }

    private int SpareBonus(int frameIndex)
    {
        return 10 + Bowls[frameIndex + 2];
    }

    public void AddBowlsToGame(int pins)
        {
            Bowls.Add(pins);
        }

    private bool IsSpare(int i)
    {
        return Bowls[i] + Bowls[i + 1] == 10;
    }

}