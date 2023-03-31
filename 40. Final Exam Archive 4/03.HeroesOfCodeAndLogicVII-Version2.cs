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
