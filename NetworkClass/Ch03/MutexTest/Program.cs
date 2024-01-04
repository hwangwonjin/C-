using static System.Net.Mime.MediaTypeNames;

namespace MutexTest
{
    internal class Program
    {
        static Mutex mut = new Mutex();
        static int count;

        static public void ThreadProc()
        {
            mut.WaitOne();
            for (int i = 0; i < 5; i++)
            {
                count++;
                Console.WriteLine("Thread ID : {0} result : {1}", Thread.CurrentThread.GetHashCode(), count);
            }
            mut.ReleaseMutex();
        }
        static void Main(string[] args)
        {
            Thread th1 = new Thread(new ThreadStart(ThreadProc));
            Thread th2 = new Thread(new ThreadStart(ThreadProc));
            th1.Start();
            th2.Start();
        }
    }
}