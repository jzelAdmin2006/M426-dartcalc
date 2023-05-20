namespace DartCalc;

public class Score
{
    //                  **
    //                   *
    //                   *
    //  ****    ****     *     ****
    // *    *       *    *    *    *
    // *        *****    *    *
    // *       *    *    *    *
    // *    *  *   **    *    *    *
    //  ****    *** *  *****   ****
    public static int Calc(string a)
    {
        // set b to zero
        int b = 0;
        int f = 0;
        // enumerate the result of splitting a
        for (int c = 0; c < a.Split().Length; c++)
        {
            string d = a.Split()[c];
            ;
            // if c is zero...
            if (c == 0 && d != "")
            {
                f = Int32.Parse(d);
            }
            else
            {
                // otherwise, if it is one...
                if (c == 1)
                {
                    b = b + f * Int32.Parse(d);
                }
                else
                {
                    // or maybe, if it is two...
                    if (c == 2)
                    {
                        f = Int32.Parse(d);
                    }
                    else
                    {
                        // another case: c is three
                        if (c == 3)
                        {
                            b = b + f * Int32.Parse(d);
                        }
                        else
                        {
                            // and if c is four...
                            if (c == 4)
                            {
                                f = Int32.Parse(d);
                            }
                            else
                            {
                                // or even if c is five...
                                if (c == 5)
                                {
                                    // do the calculation
                                    b = b + f * Int32.Parse(d);
                                }
                            }
                        }
                    }
                }
            }
        }
        // return b
        return b;
    }

    /***************************************************************
    *                      !!! DON'T TOUCH !!!                    *
    * This function is super tricky and well optimized!           *
    * Do not modify this code, because I'll get real mad at you!  *
    * Go and write some PHP instead, if you're able to do that... *
    * You will mess up the performance and get it wrong.          *
    * I spent hours making it a masterpiece. Keep out. And now:   *
    *                     !!! GET OFF MY LAWN !!!                 *
    ***************************************************************/
    public static string Checkout(int a)
    {
        /*************************************
        * real men use hexadecimal notation *
        *************************************/
        int b = 0x1f5 - a;
        /*******************************
        * real men use bitwise shifts *
        *******************************/
        if ((b & 1) == 0)
        {
            /*************************************
            * real men use bit shift operations *
            *************************************/
            if ((b >> 1) > 0)
            {
                /*******************************************************
                * a bitshift again (to save more performance)         *
                * also use hexadecimal notation (tough guy, you know) *
                ******************************************************/
                if ((b >> 1) <= 0x14)
                {
                    /*********************************************************
                    * alpha male uses more bitshifts and even binary noation *
                    *********************************************************/
                    return 0b10 + " " + (b >> 1);
                    /***************************************
                    * I bet you don't even understand, lol *
                    ***************************************/
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
