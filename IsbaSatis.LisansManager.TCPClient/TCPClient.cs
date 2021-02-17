using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using Isbasatis.LicenseManager.LicenseInformations.Enums;
using Isbasatis.LicenseManager.LicenseInformations.Tables;
using Newtonsoft.Json;
using WatsonTcp;

namespace IsbaSatis.LisansManager.TCPClient
{
   public class TCPClient
   {
       public WatsonTcpClient client;

       public TCPClient()
       {
           client = new WatsonTcpClient("192.168.1.242",148);
           


       }

       public void ClientStart()
       {
            try
            {
                client.Start();
            }
            catch (SocketException)
            {

                MessageBox.Show("Servis Cevap Vermiyor. Program Kapatılacak");
                Application.Exit();
            }
           
        }
     

        public void SendMessage(MessageType messageType,string message)
        {
            TcpMessage msg = new TcpMessage()
            {
                MessageType = messageType,
                Message = message
            };
            client.Send(JsonConvert.SerializeObject(msg));
        }
    }
}
