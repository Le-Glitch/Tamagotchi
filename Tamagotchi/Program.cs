using System;

string answer = "e";

Console.WriteLine("Press ENTER to start playing");
Console.ReadLine();

Tamagotchi tamagotchi = new Tamagotchi();

Console.WriteLine("Name your Tamagotchi:");
tamagotchi.name = Console.ReadLine();

while (tamagotchi.GetAlive())
{
    while (answer != "1" && answer != "2" && answer != "3" && answer != "4")
    {
        Console.Clear();
        Console.WriteLine("Choose an action:");
        Console.WriteLine("1. Teach your Tamagotchi a new word");
        Console.WriteLine("2. Say something to your Tamagotchi");
        Console.WriteLine("3. Feed your Tamagotchi");
        Console.WriteLine("4. Do nothing");

        answer = Console.ReadLine();
    }

    switch (answer)
    {
        case ("1"):
            Console.WriteLine("What word do you want to teach your Tamagotchi?");
            tamagotchi.Teach(Console.ReadLine());
            break;

        case ("2"):
            tamagotchi.Hi();
            break;

        case ("3"):
            tamagotchi.Feed();
            break;
    }




    tamagotchi.Tick();
}