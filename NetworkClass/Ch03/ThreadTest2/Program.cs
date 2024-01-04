namespace ThreadTest2
{
    internal class Program
    {

        static void Func()
        {
            int i = 0;
            while (true) 
            {
                Console.WriteLine("{0}", i++);
                Thread.Sleep(300);
            }
        }
        static void Main(string[] args)
        {
            Thread th = new Thread(new ThreadStart(Func));
            th.Start();
            Console.WriteLine("Main 종료");
        }
    }
}