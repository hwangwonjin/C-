using System.Net.Sockets;

namespace StreamWriterTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpListener tcpListener = new TcpListener(3000);
            tcpListener.Start();
            TcpClient tcpClient = tcpListener.AcceptTcpClient();

            bool YesNo = false;
            int val1 = 12;
            float pi = 3.14f;
            string Message = "Hello World";

            NetworkStream ns = tcpClient.GetStream();
            using (StreamWriter sw = new StreamWriter(ns))
            {
                sw.AutoFlush = true;
                sw.WriteLine(YesNo);
                sw.WriteLine(val1);
                sw.WriteLine(pi);
                sw.WriteLine(Message);
            }
            ns.Close();
            tcpClient.Close();
            tcpListener.Stop();
        }
    }
}