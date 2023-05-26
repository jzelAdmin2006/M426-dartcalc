namespace DartCalc;

public class Score {
    private const int INITIAL_POINTS = 501;
    private const int MIN_DOUBLE_RING_POINTS = 2;
    private const int MAX_DOUBLE_RING_SCORE = 40;

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
        int remainingPoints = INITIAL_POINTS - achievedPoints;
        return isEven(remainingPoints) && IsBetween(remainingPoints, MIN_DOUBLE_RING_POINTS, MAX_DOUBLE_RING_SCORE) ? "2 " + remainingPoints / 2 : "";
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
