//INPUT
using System.Text;

int heroesCount = int.Parse(Console.ReadLine());

//ACTION
Dictionary<string, int> heroesAndHitpoints = new Dictionary<string, int>();
Dictionary<string, int> heroesAndManapoints = new Dictionary<string, int>();

for (int i = 0; i < heroesCount; i++)
{
    string[] heroInfo = Console.ReadLine().Split();
    string heroName = heroInfo[0];
    int hitPoints = int.Parse(heroInfo[1]);
    int manaPoints = int.Parse(heroInfo[2]);

    if (hitPoints <= 100)
    {
        heroesAndHitpoints.Add(heroName, hitPoints);
    }
    if (manaPoints <= 200)
    {
        heroesAndManapoints.Add(heroName, manaPoints);
    }
}

string command = string.Empty;
while ((command = Console.ReadLine()) != "End")
{
    string[] commandArray = command.Split(" - ");
    string commandType = commandArray[0];

    //CastSpell Command
    if (commandType == "CastSpell")
    {
        string heroName = commandArray[1];
        int manaPointsNeeded = int.Parse(commandArray[2]);
        string spellName = commandArray[3];

        if (heroesAndManapoints[heroName] >= manaPointsNeeded)
        {
            heroesAndManapoints[heroName] -= manaPointsNeeded;
            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesAndManapoints[heroName]} MP!");
        }
        else
        {
            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
        }
    }

    //TakeDamage Command
    else if (commandType == "TakeDamage")
    {
        string heroName = commandArray[1];
        int damage = int.Parse(commandArray[2]);
        string attacker = commandArray[3];

        heroesAndHitpoints[heroName] -= damage;
        if (heroesAndHitpoints[heroName] > 0)
        {
            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesAndHitpoints[heroName]} HP left!");
        }
        else
        {
            heroesAndHitpoints.Remove(heroName);
            heroesAndManapoints.Remove(heroName);
            Console.WriteLine($"{heroName} has been killed by {attacker}!");
        }
    }

    //Recharge Command
    else if (commandType == "Recharge")
    {
        string heroName = commandArray[1];
        int amountMP = int.Parse(commandArray[2]);

        int previousManaPoints = heroesAndManapoints[heroName];
        heroesAndManapoints[heroName] += amountMP;

        if (heroesAndManapoints[heroName] > 200)
        {
            heroesAndManapoints[heroName] = 200;
            Console.WriteLine($"{heroName} recharged for {200 - previousManaPoints} MP!");
        }
        else
        {
            Console.WriteLine($"{heroName} recharged for {amountMP} MP!");
        }
    }

    //Heal Command
    else if (commandType == "Heal")
    {
        string heroName = commandArray[1];
        int amountHP = int.Parse(commandArray[2]);

        int previousHitPoints = heroesAndHitpoints[heroName];
        heroesAndHitpoints[heroName] += amountHP;

        if (heroesAndHitpoints[heroName] > 100)
        {
            heroesAndHitpoints[heroName] = 100;
            Console.WriteLine($"{heroName} healed for {100 - previousHitPoints} HP!");
        }
        else
        {
            Console.WriteLine($"{heroName} healed for {amountHP} HP!");
        }
    }
}

//OUTPUT
foreach (var hero in heroesAndHitpoints)
{
    Console.WriteLine(hero.Key);
    Console.WriteLine($"HP: {hero.Value}");
    Console.WriteLine($"MP: {heroesAndManapoints[hero.Key]}");
}