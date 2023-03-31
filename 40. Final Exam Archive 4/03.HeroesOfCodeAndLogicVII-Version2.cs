//INPUT
using System.Text;

int heroesCount = int.Parse(Console.ReadLine());

//ACTION
List<Hero> heroesList = new List<Hero>();

for (int i = 0; i < heroesCount; i++)
{
    string[] heroInfo = Console.ReadLine().Split();
    string heroName = heroInfo[0];
    int hitPoints = int.Parse(heroInfo[1]);
    int manaPoints = int.Parse(heroInfo[2]);

    if (hitPoints <= 100 && manaPoints <= 200)
    {
        Hero currentHero = new Hero(heroName, hitPoints, manaPoints);
        heroesList.Add(currentHero);
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

        for (int i = 0; i < heroesList.Count; i++)
        {
            if (heroesList[i].Name == heroName)
            {
                if (heroesList[i].ManaPoints >= manaPointsNeeded)
                {
                    heroesList[i].ManaPoints -= manaPointsNeeded;
                    Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesList[i].ManaPoints} MP!");
                }
                else
                {
                    Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                }
            }
        }
    }

    //TakeDamage Command
    else if (commandType == "TakeDamage")
    {
        string heroName = commandArray[1];
        int damage = int.Parse(commandArray[2]);
        string attacker = commandArray[3];

        for (int i = 0; i < heroesList.Count; i++)
        {
            if (heroesList[i].Name == heroName)
            {
                heroesList[i].HitPoints -= damage;

                if (heroesList[i].HitPoints > 0)
                {
                    Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesList[i].HitPoints} HP left!");
                }
                else
                {
                    heroesList.Remove(heroesList[i]);
                    Console.WriteLine($"{heroName} has been killed by {attacker}!");
                }
            }
        }
    }

    //Recharge Command
    else if (commandType == "Recharge")
    {
        string heroName = commandArray[1];
        int amountMP = int.Parse(commandArray[2]);

        for (int i = 0; i < heroesList.Count; i++)
        {
            if (heroesList[i].Name == heroName)
            {
                int previousManaPoints = heroesList[i].ManaPoints;
                heroesList[i].ManaPoints += amountMP;

                if (heroesList[i].ManaPoints <= 200)
                {
                    Console.WriteLine($"{heroName} recharged for {amountMP} MP!");
                }
                else
                {
                    heroesList[i].ManaPoints = 200;
                    Console.WriteLine($"{heroName} recharged for {200 - previousManaPoints} MP!");
                }
            }
        }
    }

    //Heal Command
    else if (commandType == "Heal")
    {
        string heroName = commandArray[1];
        int amountHP = int.Parse(commandArray[2]);

        for (int i = 0; i < heroesList.Count; i++)
        {
            if (heroesList[i].Name == heroName)
            {
                int previousHitPoints = heroesList[i].HitPoints;
                heroesList[i].HitPoints += amountHP;

                if (heroesList[i].HitPoints <= 100)
                {
                    Console.WriteLine($"{heroName} healed for {amountHP} HP!");
                }
                else
                {
                    heroesList[i].HitPoints = 100;
                    Console.WriteLine($"{heroName} healed for {100 - previousHitPoints} HP!");
                }
            }
            
        }
    }
}

//OUTPUT
foreach (var hero in heroesList)
{
    Console.WriteLine(hero.Name);
    Console.WriteLine($" HP: {hero.HitPoints}");
    Console.WriteLine($" MP: {hero.ManaPoints}");
}

//Heroes Class
public class Hero
{
    public string Name { get; set; }
    public int HitPoints { get; set; }
    public int ManaPoints { get; set; }

    public Hero(string name, int hitPoints, int manaPoints)
    {
        Name = name;
        HitPoints = hitPoints;
        ManaPoints = manaPoints;
    }
}