namespace CleanCodePractices.After;
public class Message
{
    public string GetMessage(object obj) => obj switch
    {
        string str => $"String: {str}",
        int number => $"Number: {number}",
        _ => "Unknown type"
    };


}
