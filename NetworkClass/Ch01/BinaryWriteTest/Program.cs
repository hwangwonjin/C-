using System.Net;
using System.Net.Sockets;

namespace BinaryWriteTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Any, 3000);
            tcpListener.Start();

            TcpClient tcpClient = tcpListener.AcceptTcpClient();
            NetworkStream networkStream = tcpClient.GetStream();
            using (BinaryWriter bw = new BinaryWriter(networkStream))
            {
                bool YesNo = true;
                int Number = 12;
                float pi = 3.14f;
                string Message = "Hello world";

                bw.Write(YesNo);
                bw.Write(Number);
                bw.Write(pi);
                bw.Write(Message);
            }
            networkStream.Close();
            tcpClient.Close();
            tcpListener.Stop();
        }
    }
}