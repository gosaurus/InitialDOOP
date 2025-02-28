using System.Runtime.CompilerServices;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who's in Initial D?");

            Console.WriteLine("Let's create some lonely drivers...");
            
            List<Member> allMembers = [
                new Member(name: "Takumi", car: "Toyota AE86 Trueno", team: "Fujiwara Tofu"),
                new Member("KT", "Mazda", "RedSuns"),
                new Member("Ryosuke", "Mazda", "Redsuns"),
                new Member("Itsuki", "Levin", "SpeedStars"),
                new Member("Bunta", "Toyota AE86 Trueno", "Fujiwara Tofu"),
                new Member("Nakazato", "Nissan Skyline", "NightKids"),
                new Member("Shingo Shinsuke", "Honda Civic", "NightKids"),
                new Member("Sudo Kyoichi", "LanEvo", "Emperors"),
                new Member("Mako Sako", "Sileighty", "Impact Blue"),
            ];

            Dictionary<string , Team> teamsDict = 
                new Dictionary<string, Team>();
                
            foreach (var member in allMembers)
            {
                if (!teamsDict.ContainsKey(member.TeamName))
                {
                    Team team = new Team(teamname: member.TeamName, homeCourse: null);
                    teamsDict.Add(member.TeamName, team);
                    team.AddMember(member);
                }
                else 
                {
                    var team = teamsDict[member.TeamName];
                    team.AddMember(member);
                }
            }
            Console.WriteLine("Outputting the teams dictionary");
            foreach (KeyValuePair<string, Team> kvp in teamsDict)
            {
                Console.WriteLine($"Team {kvp.Key}");
                foreach (var member in kvp.Value.Members)
                {
                    Console.WriteLine($"\t{member}");
                }
            }
        }
    }
}
