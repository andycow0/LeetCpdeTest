namespace src.Questions.Numers
{
    public class PowerOfThree_326
    {
        public static bool IsPowerOfThree(int n)
        {
            if (n < 1)
            {
                return false;
            }
            
            while (n % 3 == 0)
            {
                n = n / 3;
            }

            return n == 1;
        }
    }
}