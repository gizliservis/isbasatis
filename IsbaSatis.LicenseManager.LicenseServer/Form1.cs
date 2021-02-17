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
using Isbasatis.LicenseManger.LicenseInformations.Manager;
using Newtonsoft.Json;
using WatsonTcp;

namespace IsbaSatis.LicenseManager.LicenseServer
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        WatsonTcpServer server;
        List<Client> clients = new List<Client>();
        LicenseConfirmation licenseConfirm = new LicenseConfirmation();
        private int licCount = 0;
        public Form1()
        {
            
            InitializeComponent();
            server = new WatsonTcpServer("192.168.1.242",148);
            server.ClientConnected += Client_Connected;
            server.ClientDisconnected += Client_Disconnected;
            server.MessageReceived += Message_Received;
            gridControl1.DataSource = clients;
            GetLicenseInfo();
            
            
        }
        private void GetLicenseInfo()
        {
            LicenseInfo info = licenseConfirm.GetLicenseInfo();
            txtKullaniciAdi.Text = info.UserName;
            txtSirketAdi.Text = info.Company;
            txtLisansSayisi.Text = info.LicenseCount.ToString();
            licCount = info.LicenseCount;

        }

        private void Message_Received(object sender, MessageReceivedFromClientEventArgs e)
        {
            TcpMessage msg = JsonConvert.DeserializeObject<TcpMessage>(Encoding.UTF8.GetString(e.Data));
            Client clientName = clients.FirstOrDefault(c => c.IpAddress == e.IpPort);
            switch (msg.MessageType)
            {
                case MessageType.Message:
                    memoEdit1.Invoke((MethodInvoker)delegate
                    {
                        memoEdit1.Text += clientName.UserName + " : " + msg.Message + System.Environment.NewLine;
                    });
                    break;
                case MessageType.SendUserName:
                   var Client=clients.SingleOrDefault(c => c.IpAddress == e.IpPort);
                    if (Client!=null)
                    {
                        Client.UserName = msg.Message;
                        gridView1.RefreshData();

                    }
                  
                    break;



            }
           
        }

        private void Client_Disconnected(object sender, ClientDisconnectedEventArgs e)
        {
            var disconnectedClient = clients.SingleOrDefault(c => c.IpAddress == e.IpPort);
            clients.Remove(disconnectedClient);
            gridView1.RefreshData();
            txtLisansSayisi.Invoke((MethodInvoker)delegate
            {
                txtLisansSayisi.Text = gridView1.RowCount + "/" + licCount;
            });
        }

       

       

        private void Client_Connected(object sender, ClientConnectedEventArgs e)
        {
            if (gridView1.RowCount>=licCount)
            {
                SendMessage(e.IpPort, MessageType.ServerRejection, "Maksimum Kullanıcı Sayısı Aşıldı");
                return;
            }

            clients.Add(new Client
            {
                IpAddress = e.IpPort,
                Time = DateTime.Now

            });
            gridView1.RefreshData();
            txtLisansSayisi.Invoke((MethodInvoker)delegate
            {
                txtLisansSayisi.Text = gridView1.RowCount + "/" + licCount;
            });
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            server.Start();
            txtServerDurumu.Appearance.ForeColor = Color.Green;
            txtServerDurumu.Text = "Başlatıldı";
            
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Client row = (Client) gridView1.GetFocusedRow();
            if (row != null)
            {
                memoEdit1.Text += "Server : " + textEdit1.Text + System.Environment.NewLine;
                SendMessage(row.IpAddress, MessageType.Message, textEdit1.Text);
                textEdit1.Text = "";
            }
            else
            {
                MessageBox.Show("Seçili Bir Kullanıcı Bulunamadı");
            }
            
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var client in clients)
            {
                SendMessage(client.IpAddress, MessageType.ServerClosed, "Server Kapatıldı Bu Yüzden uygulama Kapatılacak");

            }
            System.Threading.Thread.Sleep(1000);
        }
    }
}
