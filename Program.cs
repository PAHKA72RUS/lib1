using System;

namespace lab1
{
    class Lib1
    {
         public string stpow(string a, int b)
        {

        string strPOW = "";

            for (int i = 0; i<b; i++)
            {
                strPOW += a;
            }
            return strPOW;


        }
        public string rev(string a)
        {
            string strREV = "";

            for (int i = a.Length - 1; i >= 0; i--)
            {
                strREV += a[i];
            }
            return strREV;
        }
       

         public string remov(string str, string s)
        {
            return str.Replace(s, "");
        }
        public int leng(string str)
        {
            return str.Length;
        }

    }
    class rezult
    {
        static void Main(string[] args)
        { 
        Lib1 l = new Lib1();
        Console.WriteLine(l.stpow("hoho/", 4));
            Console.WriteLine(l.rev("loperamid"));
            Console.WriteLine(l.remov("лама пальма калодец", "а"));
            Console.WriteLine(l.leng("asl;kdfsdjfsdlkf"));
        }

    }



}
