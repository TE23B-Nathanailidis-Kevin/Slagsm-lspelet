int hamiltonhp = 100;
int verstappenhp = 100; 

string hamiltonName = "Lewis Hamilton";
string verstappenName = "Max Verstappen";

Random generator = new Random();

Console.WriteLine("Press any button to begin.");
Console.ReadLine();

while (hamiltonhp > 0 && verstappenhp > 0)
{
    Console.WriteLine("\n ---New fight---");
    Console.WriteLine($"{hamiltonName}: {hamiltonhp} {verstappenName}: {verstappenhp}\n");
    Console.ReadLine();

    int hamiltonDamage = generator.Next(20);
    verstappenhp -= hamiltonDamage; 
    verstappenhp = Math.Max(0, verstappenhp);
    Console.WriteLine($"{hamiltonName} gör {hamiltonDamage} skada på {verstappenName}");

    int verstappenDamage = generator.Next(20);
    hamiltonhp -= verstappenDamage;
    hamiltonhp = Math.Max(0, hamiltonhp);
    Console.WriteLine($"{verstappenName} gör {verstappenDamage} skada på {hamiltonName}");
    
    Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
    Console.ReadKey();
}

Console.WriteLine("\n ---Race is over---");

if (hamiltonhp == 0 && verstappenhp == 0)
{
    Console.WriteLine("Tie");
}
else if (hamiltonhp == 0)
{
    Console.WriteLine($"{verstappenName} Won!");
}
else
{
    Console.WriteLine($"{hamiltonName} Won!");
}

Console.WriteLine("Press any button to close.");
Console.ReadKey();