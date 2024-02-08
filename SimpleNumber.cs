using System.Text;

namespace Indexer
{
    public static class SimpleNumber

       
    {
        public static bool IsSimpleNumber(this StringBuilder y)
        {
            int number;
            if (int.TryParse(y.ToString(), out number))
            {
                // Check for special cases
                if (number <= 1)
                    return false;
                if (number == 2)
                    return true;
                if (number % 2 == 0)
                    return false;

                
                for (int i = 3; i <= Math.Sqrt(number); i += 2)
                {
                    if (number % i == 0)
                        return false;
                }

                return true;
            }

            else
            {
                return false;
            }

        }
        
}
}
