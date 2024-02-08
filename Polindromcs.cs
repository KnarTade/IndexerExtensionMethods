namespace Indexer
{
    public static class Polindrom
    {

        public static bool IsPolindrome(this String str)
        {
            str = str.ToLower();


            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                
                if (str[i] != str[j])
                {
                    return false;
                }


            }
            return true;

            //    for (int i = 0; i < str.Length / 2; i++)
            //    {
            //        
            //        if (str[i] != str[str.Length - i - 1])
            //        {
            //            return false;
            //        }
            //    }
            //    return true;
            //}
        }

}
}
