using System.Net.Sockets;

namespace StreamReadTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] buffer = new char[100];
            TcpClient tcpClient = new TcpClient("localhost", 3000);
            NetworkStream ns = tcpClient.GetStream();
            using (StreamReader sr = new StreamReader(ns))
            {
                string str = sr.ReadLine();
                Console.WriteLine(str);
                str = sr.ReadLine();
                Console.WriteLine(str);
                str = sr.ReadLine();
                Console.WriteLine(str);
                str = sr.ReadLine();
                Console.WriteLine(str);
            }

            ns.Close();
            tcpClient.Close();
        }
    }
}