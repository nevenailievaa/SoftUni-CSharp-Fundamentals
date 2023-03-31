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

//You got your hands on the most recent update on the best MMORPG of all time –
//Heroes of Code and Logic. You want to play it all day long! So cancel all other
//arrangements and create your party!
//On the first line of the standard input, you will receive an integer n – the
//number of heroes that you can choose for your party. On the next n lines, the
//heroes themselves will follow with their hit points and mana points separated
//by a single space in the following format: 
//"{hero name} {HP} {MP}"

//HP stands for hit points and MP for mana points
//a hero can have a maximum of 100 HP and 200 MP
//After you have successfully picked your heroes, you can start playing the game.
//You will be receiving different commands, each on a new line, separated by " – ",
//until the "End" command is given. 
//There are several actions that the heroes can perform:

//"CastSpell – {hero name} – {MP needed} – {spell name}"
//If the hero has the required MP, he casts the spell, thus reducing his MP. Print
//this message: 
//"{hero name} has successfully cast {spell name} and now has {mana points left} MP!"
//If the hero is unable to cast the spell print:
//"{hero name} does not have enough MP to cast {spell name}!"

//"TakeDamage – {hero name} – {damage} – {attacker}"
//Reduce the hero HP by the given damage amount. If the hero is still alive (his HP is
//greater than 0) print:
//"{hero name} was hit for {damage} HP by {attacker} and now has {current HP} HP left!"
//If the hero has died, remove him from your party and print:
//"{hero name} has been killed by {attacker}!"

//"Recharge – {hero name} – {amount}"
//The hero increases his MP. If it brings the MP of the hero above the maximum value (200),
//MP is increased to 200. (the MP can't go over the maximum value).
//Print the following message:
//"{hero name} recharged for {amount recovered} MP!"

//"Heal – {hero name} – {amount}"
//The hero increases his HP. If a command is given that would bring the HP of the hero above
//the maximum value (100), HP is increased to 100 (the HP can't go over the maximum value).
//Print the following message:
//"{hero name} healed for {amount recovered} HP!"

//Print all members of your party who are still alive, in the following format (their HP/MP
//need to be indented 2 spaces):
//"{hero name}
//HP: {current HP}
//MP: {current MP}"
