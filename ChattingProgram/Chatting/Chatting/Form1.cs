using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Chatting
{
    public partial class Form1 : Form
    {
        Socket socket;
        EndPoint ep_my, ep_other;
        public const int MessageSize = 1024;
        byte[] byteMessage;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

                //폼 로드되면 내 IP주소 가져오기
                tb_myIP.Text = getMyIPAddress();
                tb_otherIP.Text = getMyIPAddress();
                tb_myName.Text = getMyIPAddress();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }

        }

        public string getMyIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            throw new Exception("Ipv4주소 없습니다.");
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            ep_my = new IPEndPoint(IPAddress.Parse(tb_myIP.Text), Convert.ToInt32(tb_myPort.Text));
            socket.Bind(ep_my);

            ep_other = new IPEndPoint(IPAddress.Parse(tb_otherIP.Text), Convert.ToInt32(tb_otherPort.Text));
            socket.Connect(ep_other);


            byteMessage = new byte[MessageSize];
            socket.BeginReceiveFrom(byteMessage, 0, byteMessage.Length, SocketFlags.None, ref ep_other, new AsyncCallback(MessageCallBack), byteMessage);

        }
        
        private void MessageCallBack(IAsyncResult result)
        {
            try
            {
                byte[] receivedData = new byte[MessageSize];//고치슝
                receivedData = (byte[])result.AsyncState;
                ASCIIEncoding encoding = new ASCIIEncoding();

                string receivedMessage = encoding.GetString(receivedData);

                //add listbox
                lb_chat.Items.Add(" : " + receivedMessage);

                byteMessage = new byte[MessageSize];
                socket.BeginReceiveFrom(byteMessage, 0, byteMessage.Length, SocketFlags.None, ref ep_other, new AsyncCallback(MessageCallBack), byteMessage);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ReceiveData Error: " + ex.Message);
            }
           
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            //string->byte
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] sendingName = new byte[100];
            sendingName = encoding.GetBytes(tb_myName.Text);

            byte[] sendingMessage = new byte[MessageSize];
            sendingMessage = encoding.GetBytes(tb_send.Text);

            byte[] sendingBytes = new byte[sendingName.Length + sendingMessage.Length];
            socket.Send(sendingBytes);


            lb_chat.Items.Add(tb_myName.Text + " : " + tb_send.Text);
            tb_send.Text = "";
        }

       
    }
}
