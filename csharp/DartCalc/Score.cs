namespace DartCalc;

public class Score {
    private const int INITIAL_POINTS = 501;
    private const int MIN_DOUBLE_RING_SCORE = 2;
    private const int DOUBLE_BULLSEYE_SCORE = 50;

    public static int Calc(string throwsInput)
    {
        List<int> throws = throwsInput.Split()
                                    .Where(@throw => !string.IsNullOrEmpty(@throw))
                                    .Select(int.Parse)
                                    .ToList();
        return Enumerable.Range(0, throws.Count / 2)
                         .Sum(i => throws[i * 2] * throws[i * 2 + 1]);
    }

    public static string Checkout(int achievedScore)
    {
        int remainingPoints = INITIAL_POINTS - achievedScore;
        return checkoutIsPossible(remainingPoints) ? "2 " + remainingPoints / 2 : string.Empty;
    }

    private static bool checkoutIsPossible(int remainingPoints)
    {
        return isEven(remainingPoints) && IsBetween(remainingPoints, MIN_DOUBLE_RING_SCORE, DOUBLE_BULLSEYE_SCORE);
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
