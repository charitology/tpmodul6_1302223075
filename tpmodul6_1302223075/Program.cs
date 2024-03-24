// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo (string title)
    {
        Contract.Requires(string.IsNullOrEmpty(title));
        Contract.Requires(title.Length <= 100);
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
        Contract.Requires (count > 0);
        Contract.Requires(count <= 10000000);
        try
        {
            checked
            {
                playCount = +count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Penambahan menyebabkan overflow");
        }
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
        try
        {
            SayaTubeVideo vid1 = new SayaTubeVideo(new string('a', 200));
            vid1.IncreasePlayCount(1000000000);
            SayaTubeVideo vid2 = new SayaTubeVideo("Tutorial");
            for (int i = 0; i < 1000000; i++)
            {
                vid2.IncreasePlayCount(1000000);
            }

            vid1.PrintVideoDetails();
            vid2.PrintVideoDetails();
        }
        catch(Exception ex)
        {
            Console.WriteLine("ERROR");
        }
    }
}

