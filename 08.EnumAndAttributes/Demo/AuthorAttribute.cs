using System;

[AttributeUsage(AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Field
    | AttributeTargets.Method) ]
public class AuthorAttribute : Attribute
{
    public string Name { get; set; }

    public AuthorAttribute(string name)
    {
        this.Name = name;
    }
}

