// See https://aka.ms/new-console-template for more information
using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo (string title)
    {
        this.id = RandomId();
        this.title = title;
        this.playCount = 0;
    }

    private int RandomId()
    {
        Random random = new Random();
        return random.Next(10000, 99999);
    }

    public void IncreasePlayCount (int count)
    {
        playCount=+ count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Title: " +  title);
        Console.WriteLine("Play Counts: " + playCount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo vid = new SayaTubeVideo("Tutorial Design by Contract - Dara Sheiba");
        vid.IncreasePlayCount(200);
        vid.PrintVideoDetails();
    }
}

