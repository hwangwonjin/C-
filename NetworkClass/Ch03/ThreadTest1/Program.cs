namespace ThreadTest1
{
    internal class Program
    {
        static void Func1()
        {
            Console.WriteLine("스레드 1 호출");
        }

        static void Func2() 
        {
            Console.WriteLine("스레드 2 호출");
        }

        static void Main(string[] args)
        {
            Thread th1 = new Thread(Func1); 
            Thread th2 = new Thread(Func2); 
            th1.Start();
            th2.Start();
            Console.WriteLine("메인 종료");
            Console.ReadLine();
        }
    }
}