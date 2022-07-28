using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    internal static class Program
    {
        static TcpListener listener = null;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                listener = new TcpListener(IPAddress.Parse("192.168.1.1"), 8888);// (IPAddress.Parse(textBox1.Text), Convert.ToInt32(textBox2.Text));
                listener.Start();
                Task task = Task.Run(Listen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        private static void Listen()
        {
            TcpClient client = listener.AcceptTcpClient(); //blocking command

            while (true)
            {
                try
                {
                    NetworkStream networkStream = client.GetStream();
                    int size = client.ReceiveBufferSize;
                    byte[] buffer = new byte[size];
                    networkStream.Read(buffer, 0, size);
                    string message = Encoding.UTF8.GetString(buffer).Trim(new char[] { '\0' });

                    switch (message) 
                    {
                        case "Room":
                            //send to user CinemaRoom from dB
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\r" + ex.StackTrace);
                }
            }
        }
    }
}
