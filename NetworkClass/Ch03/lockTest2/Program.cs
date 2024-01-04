namespace lockTest2
{
    class Test
    {
        static object obj = new object();
        static int count;

        public void ThreadProc()
        {
            lock (obj) 
            { 
                for (int i = 0; i < 10; i++)
                {
                    count++;
                    Console.WriteLine("Thread ID : {0} result : {1}", Thread.CurrentThread.GetHashCode(), count);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Thread th1 = new Thread(new ThreadStart(test.ThreadProc));
            Thread th2 = new Thread(new ThreadStart(test.ThreadProc));
            th1.Start();
            th2.Start();
        }
    }
}