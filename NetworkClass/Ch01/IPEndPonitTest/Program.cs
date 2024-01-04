using System.Net;

namespace IPEndPonitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPAddress ipInfo = IPAddress.Parse("127.0.0.1");
            int port = 13;
            IPEndPoint EndPointInfo = new IPEndPoint(ipInfo, port);
            Console.WriteLine("ip : {0} port : {1}", EndPointInfo.Address, EndPointInfo.Port);
            Console.WriteLine(EndPointInfo.ToString());
            Console.ReadKey();
        }
    }
}