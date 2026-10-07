namespace CollectionGenericsDemo.Utilities;

public static class DisplayHelper
{
    public static void Display<T>(T value)
    {
        Console.WriteLine(value);
    }
}