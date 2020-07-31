using System.Diagnostics;

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

        }

        /* CloseInstance() is responsible for closing any open Servers that are listening */
        private static void CloseInstance()
        {

        }
    }
}
