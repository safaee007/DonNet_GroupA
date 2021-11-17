using System;
using System.Threading;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //MyPerson p = new MyPerson();
                //p.FirstName = "saeed";

                //MyPerson p2 = p;
                //p2.FirstName = "ali";

                //Console.WriteLine(p.FirstName);
                //Console.WriteLine(p2.FirstName);


                ////----------------------
                //MyPersonStruct ps = new MyPersonStruct();
                //ps.FirstName = "saeed";

                //MyPersonStruct ps2 = ps;
                //ps2.FirstName = "ali";

                //Console.WriteLine(ps.FirstName);
                //Console.WriteLine(ps2.FirstName);
            }


            // Thread
            {
                //without thread
                {
                    foo();
                    foo();
                }

                //with old thread
                {
                    Thread th1 = new Thread(foo);
                    th1.Start();

                    Thread th2 = new Thread(foo);
                    th2.Start();

                    ////after end of all thread go to other 
                    th1.Join();
                    th2.Join();
                }

                //with thread pull OR task
                {
                    Task.Run(() => // lambda expression
                    {
                        Thread.Sleep(2000);
                    });
                    Task.Run(foo);
                    Task.Run(foo);
                }
            }


        }

        private static void foo()
        {
            Thread.Sleep(2000);
            Console.WriteLine("foo done!");
        }
    }
}
