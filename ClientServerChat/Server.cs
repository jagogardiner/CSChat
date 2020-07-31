using System;
using System.Collections;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace ClientServerChat
{
    public class Server
    {
        /* The configuration struct holds the address, port and message delay information for the server */
        public struct Configuration
        {
            public string address;
            public int port;
            public int delay;
        }
        /* Make the server configuration static so it is applicable within the Server class. */
        static Configuration config = new Configuration();

        private struct ServerInstance
        {
            /* Networking and instance stuff */
            public TcpListener server;
            public Hashtable clients;
            public NetworkStream nwStream;

            /* Any data that is useful */
            public bool alive;
            public int users;
        }
        static ServerInstance instance = new ServerInstance();

        /* Launch() is responsible for performing actions upon the user selecting the server mode, such as launching a Server instance */
        public static void Launch()
        {
            ServerForm serverForm = new ServerForm();
            serverForm.Show(); // make sure we're visible!

            /* Set some default configuration values */
            config.address = "localhost";
            config.port = 8000;
            config.delay = 0;

            OpenInstance(); // open server instance
        }

        /* SendRestart() is the userspace method for sending a clean Server instance restart. */
        public static void SendRestart()
        {
            instance.alive = false;
            if(instance.server == null) { OpenInstance(); };
        }

        /* SetConfiguration() takes passed configuration parameters and updates them within the configuration struct, config */
        public static void SetConfiguration(string addressToUpdate, int portToUpdate, int delayToUpdate)
        {
            Debug.WriteLine("Old address: {0}\nOld port: {1}\nOld delay: {2}", config.address, config.port, config.delay);
            config.address = addressToUpdate;
            config.port = portToUpdate;
            config.delay = delayToUpdate;
            Debug.WriteLine("New address: {0}\nNew port: {1}\nNew delay: {2}", config.address, config.port, config.delay);
            SendRestart(); // Make sure we restart the Server with the new configuration.
        }

        /* GetConfiguration() returns the current Server config in the form of the Configuration struct */
        public static Configuration GetConfiguration()
        {
            return config;
        }
        
        /* OpenInstance() is responsible for opening a Server based the configuration within the Configuration struct */
        private static void OpenInstance()
        {
            /* Make sure instance is alive and is properly initiated. */
            instance.alive = true;
            instance.server = new TcpListener(IPAddress.Parse(config.address), config.port);
            instance.server.Start();

            Byte[] bytes = new Byte[1024];
            String data = null;

            while (instance.alive)
            {
                TcpClient client = instance.server.AcceptTcpClient();
                instance.users++;

                instance.nwStream = client.GetStream();
                instance.nwStream.Read(bytes, 0, (int)client.ReceiveBufferSize);
                data = System.Text.Encoding.ASCII.GetString(bytes);
                data = data.Substring(0, data.IndexOf("$")); // Split messages or names by $
                instance.clients.Add(data, client);
            }
        }
    }
}
