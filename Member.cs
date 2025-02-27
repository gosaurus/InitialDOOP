public class Member
{
    public string Name { get; }
    public string Car { get; }
    public string? TeamName { get; }

    public Member (string name, string car, string team="")
    {
        Name = name;
        Car = car;
        TeamName = "";
    }

    public override string ToString()
    {
        return $"{Name} of {TeamName} drives a {Car}.";
    }

}