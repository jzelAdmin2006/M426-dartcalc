namespace DartCalc;

public class Score
{
    public static int Calc(string throwsInput)
    {
        List<int> throws = throwsInput.Split()
                                    .Where(@throw => !string.IsNullOrEmpty(@throw))
                                    .Select(int.Parse)
                                    .ToList();
        return Enumerable.Range(0, throws.Count / 2)
                         .Sum(i => throws[i * 2] * throws[i * 2 + 1]);
    }

    public static string Checkout(int achievedPoints)
    {
        int remainingPoints = 501 - achievedPoints;
        int halfRemainingPoints = remainingPoints / 2;
        return isEven(remainingPoints) && IsBetween(halfRemainingPoints, 1, 20) ? "2 " + halfRemainingPoints : "";
    }

    private static bool isEven(int num)
    {
        return num % 2 == 0;
    }

    private static bool IsBetween(int num, int lower, int upper)
    {
        return lower <= num && num <= upper;
    }
}
