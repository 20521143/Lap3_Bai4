using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap3_Bai4
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }
        /// <summary>
        /// Nút gửi thông điệp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_Mesage.Text != string.Empty)
                {
                    Send();
                    txb_Mesage.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Thông điệp bị lỗi", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        IPEndPoint ip;
        Socket client;
        /// <summary>
        /// Thiết lập kết nối với sever
        /// </summary>
        public void Connect()
        {
            ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                ProtocolType.IP);

            try
            {
                client.Connect(ip);
            }
            catch
            {
                MessageBox.Show("Không kết nối được với máy chủ", "Cảnh báo",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Thread listener = new Thread(Receive);
            listener.IsBackground = true;
            listener.Start();
 
        }
        /// <summary>
        /// Gửi thông điệp
        /// </summary>
        public void Send()
        {
           
            client.Send(sercilize(txb_Name.Text+ ":" +txb_Mesage.Text));
            AddMessage(txb_Name.Text + ":" + txb_Mesage.Text);
        }
        /// <summary>
        /// Luôn lắng nghe thông điệp từ sever 
        /// </summary>
        public void Receive()
        {
            try
            {
                while (true)//luôn lắng nghe
                {
                    byte[] revMessage = new byte[1024 * 1000];
                    client.Receive(revMessage);
                    string data = (string) Desercilize(revMessage);
                    AddMessage(data);
                }
            }
            catch
            {
                client.Close();
            }
        }

        void AddMessage(string a)
        {
            listView_Message.Items.Add(new ListViewItem() { Text = a });
        }
        /// <summary>
        /// Đóng kết nối
        /// </summary>
        public void Close ()
        {
            client.Close();
        }
        /// <summary>
        /// Phân mảnh giữ liệu thành byte
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        byte[] sercilize(object o)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter fomatter = new BinaryFormatter();
            fomatter.Serialize(stream, o);

            return stream.ToArray();
        }
        /// <summary>
        /// Tổng hợp mảnh dữ liệu từ byte
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        object Desercilize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);

        }
    }
}
