using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Isbasatis.LicenseManager.LicenseInformations.Enums;
using Isbasatis.LicenseManager.LicenseInformations.Tables;
using Newtonsoft.Json;
using WatsonTcp;

namespace IsbaSatis.LicenseManager.LicenseServer
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        WatsonTcpServer server;
        List<Client> clients = new List<Client>();
        public Form1()
        {
            InitializeComponent();
            server = new WatsonTcpServer("192.168.1.242",148);
            server.ClientConnected += Client_Connected;
            server.ClientDisconnected += Client_Disconnected;
            server.MessageReceived += Message_Received;
            
            gridControl1.DataSource = clients;
            
        }

        private void Message_Received(object sender, MessageReceivedFromClientEventArgs e)
        {
            TcpMessage msg = JsonConvert.DeserializeObject<TcpMessage>(Encoding.UTF8.GetString(e.Data));
            switch (msg.MessageType)
            {
                case MessageType.Message:
                    memoEdit1.Invoke((MethodInvoker)delegate
                    {
                        memoEdit1.Text += e.IpPort + " : " + msg.Message + System.Environment.NewLine;
                    });
                    break;
                case MessageType.SendUserName:
                   var Client=clients.SingleOrDefault(c => c.IpAddress == e.IpPort);
                   Client.UserName = msg.Message;
                   gridView1.RefreshData();
                    break;



            }
           
        }

        private void Client_Disconnected(object sender, ClientDisconnectedEventArgs e)
        {
            var disconnectedClient = clients.SingleOrDefault(c => c.IpAddress == e.IpPort);
            clients.Remove(disconnectedClient);
            gridView1.RefreshData();
        }

       

       

        private void Client_Connected(object sender, ClientConnectedEventArgs e)
        {
            clients.Add(new Client
            {
                IpAddress = e.IpPort,
                Time = DateTime.Now

            });
            gridView1.RefreshData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            server.Start();
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Client row = (Client) gridView1.GetFocusedRow();
            SendMessage(row.IpAddress,MessageType.Message,textEdit1.Text);
        }

        private void SendMessage(string ipAdress, MessageType messageType, string message)
        {
            TcpMessage msg = new TcpMessage()
            {
                MessageType = messageType,
                Message = message
            };
            server.Send(ipAdress, JsonConvert.SerializeObject(msg));
        }
    }
}
