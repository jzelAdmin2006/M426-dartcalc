namespace DartCalc.Tests;

public class ScoreTest
{
    [Theory]
    [InlineData("", 0)]
    [InlineData("1 17", 17)]
    [InlineData("1 17 1 3", 20)]
    [InlineData("1 17 1 3 1 10", 30)]
    [InlineData("2 17 1 3 1 10", 47)]
    public void TestCalc(string entered, int expected)
    {
        Assert.Equal(expected, Score.Calc(entered));
    }

    [Theory]
    [InlineData(500, "")]    
    [InlineData(499, "2 1")]    
    [InlineData(461, "2 20")]    
    [InlineData(467, "2 17")]    
    [InlineData(489, "2 6")]    
    [InlineData(301, "")]    
    public void TestCheckout(int score, string expected)
    {
        Assert.Equal(expected, Score.Checkout(score));
    }
}