using System.Dynamic;

public class Team {

    //private properties, using shorthand getters
    public string TeamName { get; }
    public List<Member>? Members = new List<Member>(); //https://stackoverflow.com/questions/4462921/how-to-create-a-property-for-a-listt
    public int? MemberCount { 
        get {
            return Members.Count;
        }
    } 
    public string? HomeCourse { get; }

    //constructor
    public Team(string teamname, string? homeCourse)
    {
        TeamName = teamname;
        if (homeCourse != null) {  
            HomeCourse = homeCourse;
        };
    }

    public void AddMember(Member member)
    {
        Members?.Add(member);
    }

    // public override int GetHashCode()
    // {
    //     return TeamName;
    // }

    public override string ToString()
    {
        return $"Racing Team: {TeamName}; Home course: {HomeCourse}; Member count: {MemberCount}";
    }
}