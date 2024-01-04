namespace MutexTest1
{
    class ThisLock
    {
        public void IncreaseCount(ref int count)
        {
            count++;
        }
    }
    class Test
    {
        ThisLock lockObject = new ThisLock();
        Mutex mut = new Mutex();
        int count = 0;

        public void ThreadProc()
        {
            mut.WaitOne();

            for (int i = 0; i < 3; i++)
            {
                lockObject.IncreaseCount(ref count);
                Console.WriteLine("Thread ID : {0} result : {1}", Thread.CurrentThread.GetHashCode(), count);
            }
            
            mut.ReleaseMutex(); 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Thread[] threads = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                threads[i] = new Thread(new ThreadStart(test.ThreadProc));
            }

            for (int i = 0; i < 3; i++)
            {
                threads[i].Start();
            }
        }
    }
}