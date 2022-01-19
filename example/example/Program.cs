using System;

namespace example
{
    class Program
    {
        public void add(int i,int j,out int m,out int k)
        {
             k = i + j;
              m=i-j;

        }
        public  int addwithref(ref int i,ref int j)
        {
            int k = i + j;
            return k;
        }
        static void Main(string[] args)
        {
            //passing parameters by values
            Program p = new Program();
             p.add(10,20,out int n,out int l);
            Console.WriteLine("{0}{1}",n,l);
            Program objpr = new Program();
            int i = 40;
            int j = 20;
            objpr.addwithref(ref i, ref j);
            Console.WriteLine("Hello World!");
            Console.WriteLine();

        }
    }
}
