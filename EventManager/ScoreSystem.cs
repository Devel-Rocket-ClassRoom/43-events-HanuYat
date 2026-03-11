using System;

class ScoreSystem
{
    public void ScoreChanged(string name, int score)
    {    
        Console.WriteLine($"점수 변경: {score}점");
    }
}