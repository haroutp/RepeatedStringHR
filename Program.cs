using System;

namespace RepeatingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine(long.MaxValue);
            Console.WriteLine(repeatedString("kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm", 736778906400));
        }

        static long repeatedString(string s, long n) {

            long remainder = n % s.Length;
            long perfectDivide = (n / s.Length);
            long found = 0;

            if(s.Length == 1 && s == "a"){
                return n;
            }

            foreach (var item in s)
            {
                if(item == 'a'){
                    found++;
                }
            }
            long total = found * perfectDivide;
            if (remainder == 0)
            {
                return total;
            }
            else 
            {
                string part = s.Substring(0, (int)remainder);
                foreach (var item in part.ToCharArray())
                {
                    if(item == 'a')
                    {
                        total++;
                    }
                }
            }
            return total;

        }
    }
}
