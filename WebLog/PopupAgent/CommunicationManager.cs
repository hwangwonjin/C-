using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopupAgent
{
    public class CommunicationManager
    {
        private const string PipeName = "PopupServicePipe";

        public event EventHandler<string> CommandReceived;

        public void StartServer()
        {
            Task.Run(() =>
            {
                using (var server = new NamedPipeServerStream(PipeName))
                {
                    server.WaitForConnection();

                    using (var reader = new System.IO.StreamReader(server, Encoding.UTF8))
                    {
                        while (true)
                        {
                            string command = reader.ReadLine();
                            OnCommandReceived(command);
                        }
                    }
                }
            });
        }

        public void SendCommand(string command)
        {
            using (var client = new NamedPipeClientStream(".", PipeName, PipeDirection.Out))
            {
                client.Connect();
                using (var writer = new System.IO.StreamWriter(client, Encoding.UTF8))
                {
                    writer.WriteLine(command);
                }
            }
        }

        protected virtual void OnCommandReceived(string command)
        {
            CommandReceived?.Invoke(this, command);
        }
    }
}
