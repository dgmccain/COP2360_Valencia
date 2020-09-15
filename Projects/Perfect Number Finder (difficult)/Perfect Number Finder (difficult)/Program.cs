using static System.Console;
class Perfect
{
    static void Main()
    {
        /* expected ouput numbers: 6, 28, 496, 8128 */

        /* expression for finding perfect numbers: 2^(p-1) * (2^p - 1)
        p must be (Mersenne) prime number for expression to work */

        int p = 2; //p cannot start at 0 or 1 because they are not prime numbers
        const int LIMIT = 10000; //maximum result allowed for program to continue
        double equation1 = 0;
        double preEquation1 = 0;
        double postEquation2 = 0;
        double equation2 = 0;
        double result;

        do
        {
            int primeChecker = 0; //resets variable for checking prime numbers

            preEquation1 = p - 1; //part of finding 2^(p-1)
            equation1 = System.Math.Pow(2, preEquation1); //part of finding 2^(p-1)

            equation2 = System.Math.Pow(2, p); //part of finding (2^p - 1)
            postEquation2 = equation2 - 1;//part of finding (2^p - 1)

            result = equation1 * postEquation2; //finds expression by combining equations

            for (int i = 1; i <= p; i++) //checks if p is prime
            {
                if (p % i == 0)
                {
                    primeChecker++;
                }
            }

            if (result < LIMIT && primeChecker == 2) //result of 10,000 is the limit
            {
                WriteLine(result);
            }
            p++;
        } while (result < LIMIT);
        ReadLine(); //pause for user
    }
}