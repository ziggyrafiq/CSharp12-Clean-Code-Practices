namespace CleanCodePractices.After;

public static class Shape
{
    // Apply the custom attribute to a method
    [MyCustomAttribute("We are using Custom Attribute Now")]
    public static int Square(int x)
    {
        return x * x;
    }
}
