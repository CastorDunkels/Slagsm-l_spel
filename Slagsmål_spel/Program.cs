using System.Net.Http.Headers;
using System;
int AdolfHitler = 1000000000;

int JeffBezos = 1000000000;

string jeffname = "Jeff";

string adolfname = "Adolf";

int round = 0;

void game()
{
    Random generator = new Random();
    while (AdolfHitler > 0 && JeffBezos > 0)
    {
        Console.WriteLine("---------------------------------------------------------------------------------");
        Console.WriteLine($"| {adolfname} {AdolfHitler} Hp \n| {jeffname} {JeffBezos} Hp");
        Console.WriteLine($"| Begin round {round}\n| Press any button to start");
        Console.WriteLine("---------------------------------------------------------------------------------");
        Console.ReadKey();
        Console.Clear();
        round++;

        int jeffdmg = generator.Next(300000010);
        AdolfHitler -= jeffdmg;
        AdolfHitler = Math.Max(0, AdolfHitler);
        Console.WriteLine("---------------------------------------------------------------------------------");
        if (jeffdmg > 300000000)
        {
            Console.WriteLine("| Critical hit");
        }
        if (jeffdmg == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("| Missed");
            Console.ResetColor();
        }
        Console.WriteLine($"| {jeffname}  deals {jeffdmg} dmg to {adolfname}");

        int adolfdmg = generator.Next(300000010);
        JeffBezos -= adolfdmg;
        JeffBezos = Math.Max(0, JeffBezos);
        if (adolfdmg > 300000000)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("| Critical hit");
            Console.ResetColor();
        }
        if (adolfdmg == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("| Missed");
            Console.ResetColor();
        }
        Console.WriteLine($"| {adolfname} deals {adolfdmg} dmg to {jeffname}");
        Console.WriteLine("| Press any button to continue");
        Console.WriteLine("---------------------------------------------------------------------------------");
        Console.ReadKey();
        Console.Clear();

    }
}

void result()
{

    Console.WriteLine("-------------------------------------------------------Fight over-------------------------------------------------------");

    if (AdolfHitler == 0 && JeffBezos == 0)
    {
        Console.WriteLine($"Both died on round {round}");
    }
    else if (JeffBezos == 0)
    {
        Console.WriteLine($"{adolfname} won on round {round} with {AdolfHitler} Hp left");
    }
    else
    {
        Console.WriteLine($"{jeffname} won on round {round} with {JeffBezos} Hp left");
    }
    if (JeffBezos > 400000000 || AdolfHitler > 400000000)
    {
        Console.WriteLine("Quite a big victory");
    }

    if (round <= 4)
    {
        Console.WriteLine("You got quite a quick fight");
    }
    else if (round >= 12)
    {
        Console.WriteLine("You got quite a long fight");
    }

    Console.WriteLine("Press any key to exit");
    Console.ReadKey();
}

Console.WriteLine("Racial cleaner vs guy who went into space with a genetalia shaped rocket");


game();

result();