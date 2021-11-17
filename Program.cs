using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPerson p = new MyPerson();
            p.FirstName = "saeed";

            MyPerson p2 = p;
            p2.FirstName = "ali";

            Console.WriteLine(p.FirstName);
            Console.WriteLine(p2.FirstName);


            //----------------------
            MyPersonStruct ps = new MyPersonStruct();
            ps.FirstName = "saeed";

            MyPersonStruct ps2 = ps;
            ps2.FirstName = "ali";

            Console.WriteLine(ps.FirstName);
            Console.WriteLine(ps2.FirstName);


        }
    }
}
