namespace DartCalc;

public class Score
{
    public static int Calc(string a)
    {
        int b = 0;
        int f = 0;
        for (int c = 0; c < a.Split().Length; c++)
        {
            string d = a.Split()[c];
            if (c == 0 && d != "")
            {
                f = Int32.Parse(d);
            }
            else
            {
                if (c == 1)
                {
                    b = b + f * Int32.Parse(d);
                }
                else
                {
                    if (c == 2)
                    {
                        f = Int32.Parse(d);
                    }
                    else
                    {
                        if (c == 3)
                        {
                            b = b + f * Int32.Parse(d);
                        }
                        else
                        {
                            if (c == 4)
                            {
                                f = Int32.Parse(d);
                            }
                            else
                            {
                                if (c == 5)
                                {
                                    b = b + f * Int32.Parse(d);
                                }
                            }
                        }
                    }
                }
            }
        }
        return b;
    }

    public static string Checkout(int a)
    {
        int b = 0x1f5 - a;
        if ((b & 1) == 0)
        {
            if ((b >> 1) > 0)
            {
                if ((b >> 1) <= 0x14)
                {
                    return 0b10 + " " + (b >> 1);
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
        else
        {
            return "";
        }
    }
}
