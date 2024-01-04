namespace ThreadTest3
{
    internal class Program
    {
        static void Func1()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("{0}", i);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Thread th = new Thread (new ThreadStart(Func1));
            th.Start();
            th.Join();
            Console.WriteLine("Main 종료");
        }
    }
}