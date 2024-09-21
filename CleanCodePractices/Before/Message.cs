namespace CleanCodePractices.Before;
public class Message
{
    public string GetMessage(object obj)
{
    if (obj is string str)
    {
        return $"String: {str}";
    }
    if (obj is int number)
    {
        return $"Number: {number}";
    }
    return "Unknown type";
}

}
