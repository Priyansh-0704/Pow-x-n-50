public class Solution {
    public double MyPow(double x, int n) {
        long binForm = n;
        if(binForm < 0) // checking if the power is negative
        {
            x = 1/x; // reverse the base
            binForm = -binForm; // make the power positive
        }
        double ans = 1;
        while(binForm > 0)
        {
            if(binForm % 2 == 1)
            {
                ans *= x; // if last digit of the exponent is 1, then multiply
            }
            x *= x; // square every time
            binForm /= 2;
        }
        return ans;
    }
}
