namespace CleanCodePractices.After;
// Define a custom attribute
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class MyCustomAttribute : Attribute
{
    public string Description { get; }

    public MyCustomAttribute(string description = "Custom attribute description")
    {
        Description = description;
    }
}
