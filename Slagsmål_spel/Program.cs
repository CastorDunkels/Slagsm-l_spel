using System;
int AdolfHitler = 1000000000;

int JeffBezos = 1000000000;

string jeffname = "Jeff";

string adolfname = "Adolf";

int round = 0;

Console.WriteLine("Racial cleaner vs guy who went into space with a genetalia shaped rocket\n press any button to start");
Console.ReadKey();


Random generator = new Random();
while (AdolfHitler > 0 && JeffBezos > 0)
{
    Console.Clear();
    Console.WriteLine($"Begin round {round}");
    Console.WriteLine($"{jeffname} {JeffBezos} Hp {adolfname} {AdolfHitler} Hp");
    Console.ReadKey();
    round++;


    int jeffdmg = generator.Next(1000000000);
    AdolfHitler -= jeffdmg;
    AdolfHitler = Math.Max(0, AdolfHitler);
    Console.WriteLine($"{jeffname} deals {jeffdmg} dmg to {adolfname}");

    int adolfdmg = generator.Next(1000000000);
    JeffBezos -= adolfdmg;
    JeffBezos = Math.Max(0, JeffBezos);
    Console.WriteLine($"{adolfname} deals {adolfdmg} dmg to {jeffname}");

    Console.WriteLine("Press any button to continue");
    Console.ReadKey();
}

Console.WriteLine("------------------------------------Fight over------------------------------");
Console.ReadLine();

