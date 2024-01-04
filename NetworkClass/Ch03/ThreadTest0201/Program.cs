namespace ThreadTest0201
{
    internal class Program
    {

        static void ThreadProc()
        {
            Console.WriteLine("스레드 id : {0}", Thread.CurrentThread.GetHashCode());
        }
        static void Main(string[] args)
        {
            Thread th = new Thread(new ThreadStart(ThreadProc));
            th.Start();
            Console.WriteLine("main 스레드 id : {0}", Thread.CurrentThread.GetHashCode());
        }
    }
}