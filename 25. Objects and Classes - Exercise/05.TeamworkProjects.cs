using System.Net.NetworkInformation;
using System.Reflection.Metadata;

//INPUT
List<Team> teams = new List<Team>();

//OUTPUT
InitializeTeams(teams);
JoinTeams(teams);
PrintValidTeams(teams);
PrintTeamsToDisband(teams);

//ACTION
//Print Valid Teams
static void PrintValidTeams(List<Team> teams)
{
    List<Team> teamsWithMembers = teams
    .Where(t => t.Members.Count > 0)
    .OrderByDescending(t => t.Members.Count)
    .ThenBy(t => t.Name)
    .ToList();

    foreach (Team team in teamsWithMembers)
    {
        Console.WriteLine($"{team.Name}");
        Console.WriteLine($"- {team.Creator}");
        foreach (string member in team.Members.OrderBy(m => m))
        {
            Console.WriteLine($"-- {member}");
        }
    }
}

//Print Teams to Disband
static void PrintTeamsToDisband(List<Team> teams)
{
    List<Team> teamsToDisband = teams
    .Where(t => t.Members.Count == 0)
    .OrderBy(t => t.Name)
    .ToList();

    Console.WriteLine("Teams to disband:");
    foreach (Team disbandTeam in teamsToDisband)
    {
        Console.WriteLine(disbandTeam.Name);
    }
}

//Creating a Team
static void InitializeTeams(List<Team> teams)
{
    //INPUT
    int teamsCount = int.Parse(Console.ReadLine());

    //ACTION
    for (int i = 0; i < teamsCount; i++)
    {
        string[] teamArgs = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();

        string creator = teamArgs[0];
        string teamName = teamArgs[1];

        //Existing Team Output
        if (TeamExists(teams, teamName))
        {
            Console.WriteLine($"Team {teamName} was already created!");
        }
        //Existing Creator Output
        else if (AlreadyCreatedATeam(teams, creator))
        {
            Console.WriteLine($"{creator} cannot create another team!");
        }
        else
        {
            Team newTeam = new Team(teamName, creator);
            teams.Add(newTeam);
            Console.WriteLine($"Team {teamName} has been created by {creator}!");
        }
    }
}
//Entering a Team
static void JoinTeams(List<Team> teams)
{
    String command = String.Empty;

    while ((command = Console.ReadLine()) != "end of assignment")
    {
        string[] commandArgs = command.Split("->", StringSplitOptions.RemoveEmptyEntries);
        string user = commandArgs[0];
        string teamName = commandArgs[1];

        //Existing Team Output
        if (!TeamExists(teams, teamName))
        {
            Console.WriteLine($"Team {teamName} does not exist!");
        }
        //Existing Member Output
        else if (AlreadyAMemberOfATeam(teams, user))
        {
            Console.WriteLine($"Member {user} cannot join team {teamName}!");
        }
        else
        {
            Team teamToJoin = teams.First(t => t.Name == teamName);
            teamToJoin.AddMember(user);
        }
    }
}

//CHECKERS

//Already a Member of Another Team Checker
static bool AlreadyAMemberOfATeam(List<Team> teams, string user)
{
    return teams.Any(t => t.Members.Contains(user)) || teams.Any(t => t.Creator == user);
}

//Existing Team Checker
static bool TeamExists (List<Team> teams, string teamName)
{
    return teams.Any (t => t.Name == teamName);
}

//Existing Creator Checker
static bool AlreadyCreatedATeam(List<Team> teams, string creator)
{
    return teams.Any(t => t.Creator == creator);
}

//Team Class
public class Team
{
    public Team(string name, string creator)
    {
        this.Name = name;
        this.Creator = creator;
        this.members = new List<string>();
    }
    public string Name { get; private set; }
    public string Creator { get; private set; }

    //Reading the list of members
    public List<string> Members => this.members;
    private readonly List<string> members;

    //Method for adding a member
    public void AddMember(string memberName)
    {
        this.Members.Add(memberName);
    }
}