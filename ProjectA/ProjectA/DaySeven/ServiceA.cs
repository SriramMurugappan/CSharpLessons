/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.DaySeven
{
    class ServiceA
    {
        int x = 0;
        public void DoTaskA()
        {
            //Monitor.Enter(this);
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("Inside DoTaskA");
            Console.WriteLine("\t Thread ID: " + id);
            //int x = 0;
            for (int icount = 0; icount <= 5; icount++)
            {
                x += icount;
                Console.WriteLine("\t ID=" + id + ": X=" + x + "icount=" + icount);
                Thread.Sleep(1000);
            }
        }
        public static void DemoA()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTH ID" + id);
            ServiceA a1 = new ServiceA();
            a1.DoTaskA();
        }
        public static void DemoB()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID"+id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);
            t1.Start();
            a1.DoTaskA();
            Console.WriteLine("------------------End of DemoB---------------------");
            /*try
            {
                for(int icount = 0; icount <= 5; icount++)
                {
                    x += icount;
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {

            }

        }
        public static void DemoB2() 
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID" + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);
            Console.WriteLine(t1.ManagedThreadId + "T1 state" + t1.ThreadState);
            t1.Start();
            Console.WriteLine(t1.ManagedThreadId + "State after start" + t1.ThreadState);
            Thread Sleep(6000);
            Console.WriteLine(t1.ManagedThreadId + "T1 state after Sleep" + t1.ThreadState);
            Console.WriteLine("------------------End of DemoB---------------------");
        }
        public static void DemoC()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTH ID: " + id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTaskA;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();
            t1.Join(7000);
            if (t1.IsAlive) t1.Abort();
            t2.Join(7000);
            if(t2.IsAlive) t2.Abort();
            Console.WriteLine("------------------End of DemoC---------------------");

        }

    }
}*/
