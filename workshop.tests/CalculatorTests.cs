using workshop.calculator;

namespace workshop.tests;

public class Tests
{
    
    [Test]
    public void AddTwoPlusOneEqualsThree()
    {
        Calculator calculator = new Calculator();

        int result = calculator.Add(1, 2);

        Assert.That(result,Is.EqualTo(3));
    }
}
