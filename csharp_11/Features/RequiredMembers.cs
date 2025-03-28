using System.Diagnostics.CodeAnalysis;

namespace csharp_11.Features;

public class RequiredMembers
{
    public void Test()
    {
        var person = new Person() {
            //required Attribute
            FirstName = "ddd"
        };
    }
}

public class Person
{
    public Person() { }

    [SetsRequiredMembers]
    public Person(string firstName) => FirstName = firstName;

    public required string FirstName { get; init; }

}