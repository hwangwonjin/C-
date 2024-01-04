using System.Net;

namespace DNSTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPAddress[] IP = Dns.GetHostAddresses("www.naver.com");
            foreach (IPAddress HostIp in IP)
            {
                Console.WriteLine("{0}", HostIp);
            }
        }
    }
}