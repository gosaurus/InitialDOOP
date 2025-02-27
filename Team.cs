
public class Team {

    //private properties, using shorthand getters
    public string teamName { get; }
    public string? HomeCourse { get; }
    public List<Member>? Members = new List<Member>(); //https://stackoverflow.com/questions/4462921/how-to-create-a-property-for-a-listt
    public int? MemberCount { get; } 

    //constructor
    public Team(string teamname, string homeCourse, List<Member> members)
    {
        teamName = teamname;
        HomeCourse = homeCourse;
        Members = members;
        MemberCount= members.Count;
    }

    public override string ToString()
    {
        return $"Racing Team: {teamName}; Home course: {HomeCourse}; Member count: {MemberCount}";
    }

    

}