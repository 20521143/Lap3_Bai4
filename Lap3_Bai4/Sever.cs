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
    public partial class Sever : Form
    {
        public Sever()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            //Connect();   
        }

        IPEndPoint ip;
        Socket sever;
        List<Socket> Client_list;
        /// <summary>
        /// Luôn lắng nghe chấp nhận kêt nối từ các Client
        /// </summary>
        void Connect()
        {
            Client_list = new List<Socket>();
            ip = new IPEndPoint(IPAddress.Any, 9999);

            sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                ProtocolType.IP);

            sever.Bind(ip);

            Thread listen = new Thread(() =>
             {
                 try
                 {
                     while (true)
                     {
                         sever.Listen(100);//chấp nhận tối đa 100 client

                         Socket client = sever.Accept();
                         Client_list.Add(client);

                         Thread rec = new Thread(Receive);
                         rec.IsBackground = true;
                         rec.Start(client);
                     }
                 }
                 catch
                 {
                     ip = new IPEndPoint(IPAddress.Any, 9999);
                     sever = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                         ProtocolType.IP);
                     MessageBox.Show("Ket noi khong thanh cong", "Lôĩ");
                 }
             });

            listen.IsBackground = true;
            listen.Start();
        }

        void Send(Socket client)
        {
            byte[] data = new byte[1024];
            data = sercilize(txb_Message.Text);
            
            if(client !=null && txb_Message.Text !=string.Empty)
                sever.Send(data);
            
            

        }

        /// <summary>
        ///  nhận thông điệp từ các client
        /// </summary>
        /// <param name="obj"></param>
        void Receive(object obj)
        {
            Socket revMessage = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 10000];
                    revMessage.Receive(data);
                    string message = (string) Desercilize(data);

                    AddMesasage(message);
                    txb_Message.Text = message;
                    
                    foreach (var item in Client_list)
                    {
                        if (item == revMessage || item ==null  )
                            continue;
                        else
                        {
                            //gửi thông điệp đến các client còn lại.
                            item.Send(sercilize(txb_Message.Text));
                        }
                    }
                    
                    txb_Message.Clear();
                }
            }
            catch
            {
                Client_list.Remove(revMessage);
                revMessage.Close();
                MessageBox.Show("sever nhận thông điệp bị lỗi", "Lỗi");
            }
            

        }
        //In thông điệp ra màn hình
        void AddMesasage(string a)
        {
            listView_Message.Items.Add(new ListViewItem() { Text = a });
        }
        /// <summary>
        /// Tắt máy chủ
        /// </summary>
        void Close()
        {
            sever.Close();
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
