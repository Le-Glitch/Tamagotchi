using System;
using System.Collections.Generic;
using System.IO;

public class Tamagotchi
{
    int hunger;
    int boredom;
    List<string> words = new List<string>() { "hi" };
    bool isAlive = true;
    Random generator;
    public string name;



    public void Teach(string word)
    {
        if (!words.Contains(word))
        {
            this.words.Add(word);
            ReduceBoredom();
        }
        else
        {
            Console.WriteLine($"{name} already knows this word");
        }

    }

    public void PrintStats()
    {
        Console.WriteLine($"Hunger: {hunger}");
        Console.WriteLine($"Boredom: {boredom}");

        if (this.isAlive)
        {
            Console.WriteLine("Status: Alive");
        }
        else
        {
            Console.WriteLine("Status: Dead");
        }
    }

    public bool GetAlive()
    {
        return this.isAlive;
    }

    public void Hi()
    {
        Console.WriteLine(words[generator.Next(0, words.Count)]);

        ReduceBoredom();
    }

    public void Tick()
    {
        this.hunger++;
        this.boredom++;

        if (this.hunger >= 10)
        {
            this.isAlive = false;
        }
        if (this.boredom >= 10)
        {
            this.isAlive = false;
        }
    }

    public void Feed()
    {
        this.hunger -= generator.Next(1, 4);
        if(this.hunger < 0)
        {
            this.hunger = 0;
        }
    }

    void ReduceBoredom()
    {
        this.boredom -= generator.Next(1, 4);
        if(this.boredom < 0)
        {
            this.boredom = 0;
        }
    }
}
