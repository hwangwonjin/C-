using System.Net.Sockets;

namespace BinaryReadTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool YesNo;
            int Number;
            float pi;
            string Message;

            TcpClient tcpClient = new TcpClient("localhost", 3000);
            NetworkStream networkStream = tcpClient.GetStream();
            using (BinaryReader br = new BinaryReader(networkStream))
            {
                YesNo = br.ReadBoolean();
                Number = br.ReadInt32();
                pi = br.ReadSingle();
                Message = br.ReadString();
            }
            networkStream.Close();
            tcpClient.Close();

            Console.WriteLine(YesNo);
            Console.WriteLine(Number);
            Console.WriteLine(pi);
            Console.WriteLine(Message);
        }
    }
}