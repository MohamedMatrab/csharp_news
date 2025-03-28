namespace csharp_11.Features;

public class DynamicAttribute
{
    [GenericAttribute<string>()]
    public string TestMethod() => default;

    //[GenericAttribute<T>()] // Not allowed! generic attributes must be fully constructed types.
    //public string Method() => default;
}

public class GenericAttribute<T> : Attribute { }

