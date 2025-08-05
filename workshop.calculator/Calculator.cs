namespace workshop.calculator;

/// <summary>
/// Class to add stuff
/// </summary>
public class Calculator
{
    private int AddingMethod(int a, int b)
    {
        return a + b;
    }
    public int Add(int a, int b)
    {
        return AddingMethod(a, b);
    }
    public int Multiply(int a, int b) => a * b;
}
