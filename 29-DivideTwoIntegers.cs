// https://leetcode.com/problems/divide-two-integers/

public class DivideTwoIntegers
{
    public int Divider(int dividend, int divisor)
    {
        int result = 0;
        bool negative = false;

        if (IsNegative(dividend) && !IsNegative(divisor) || !IsNegative(dividend) && IsNegative(divisor))
        {
            negative = true;
        }

        long dividendPos = Math.Abs((long)dividend);
        long divisorPos = Math.Abs((long)divisor);

        if (dividend == int.MaxValue && (divisor == 1 || divisor == -1))
        {
            return int.MaxValue;
        }

        if (dividend == int.MinValue && (divisor == 1 || divisor == -1))
        {
            if (negative == false)
            {
                return int.MaxValue;

            }
            return int.MinValue;
        }

        for (int i = 1; dividendPos >= divisorPos; i++)
        {
            dividendPos = dividendPos - divisorPos;

            result = i;
        }

        if (negative)
        {
            result = result *= -1;
        }

        return result;
    }

    bool IsNegative(int number)
    {
        if (number < 0)
        {
            return true;
        }

        return false;
    }
}
