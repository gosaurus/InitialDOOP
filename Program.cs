namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who's in Initial D?");

            Console.WriteLine("Let's create some lonely drivers...");
            
            var m1 = new Member("Takumi", "86", "");
            var m2 = new Member("KT", "Mazda", "RedSuns");
            var m3 = new Member("Ryosuke", "Mazda", "Redsuns");
            var m4 = new Member("Itsuki", "Levin", "SpeedStars");
            var m5 = new Member("Bunta", "86", "");
            
            //https://dzone.com/articles/different-ways-of-creating-list-of-objects-in-c
            List<Member> redSunsMembers = [];
            redSunsMembers.AddRange([m2, m3]);

            //check that members list exists
            foreach (var member in redSunsMembers)
            {
                Console.WriteLine(member);
            }

            var RedSunsTeam = new Team("RedSuns", "Akagi Pass", redSunsMembers);

            //check that the Team exists(displays team member count)
            Console.WriteLine(RedSunsTeam);

            //check the optional parameters
            Console.WriteLine("Characters who don't belong in any team:");
            Console.WriteLine($"{m1}, {m5}");
        }

    }
}