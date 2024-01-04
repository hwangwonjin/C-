namespace MonitorTest
{
    // lock과 동일하게 private object obj = new object()를 사용하여 동기화를 하는 예이다.
    class Test
    {
        object obj = new object();
        int count;

        public void IncreaseCount()
        {
            Monitor.Enter(obj);
            for (int i = 0; i < 5; i++)
            {
                count++;
                Console.WriteLine("Thread id : {0} Count : {1}", Thread.CurrentThread.GetHashCode(), count);

            }
            Monitor.Exit(obj);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Test test = new Test();
                Thread th1 = new Thread(new ThreadStart(test.IncreaseCount));
                Thread th2 = new Thread(new ThreadStart(test.IncreaseCount));
                th1.Start();
                th2.Start();
            }
        }
    }
}