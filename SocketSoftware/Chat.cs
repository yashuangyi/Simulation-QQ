using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CCWin.SkinControl;
using MySql.Data.MySqlClient;

namespace SocketSoftware
{
    public delegate void ReceivedBitmapHandler(Bitmap bitmap);
    public partial class Chat : Form
    {
        string m_id = "";

        public static Chat CreateOrOpenChatById(ref Dictionary<string, Chat> dic, string id)
        {
            if (dic.ContainsKey(id))
            {
                if (dic[id].IsDisposed)
                {
                    dic[id] = new Chat(id);
                }
                return dic[id];
            }
            else
            {
                dic.Add(id, new Chat(id));
                return dic[id];
            }

        }
        public Chat(string id)
        {
            if (MyOperation.JudgeIfServer(MyOperation.MyId))
            {
                if (!MyOperation.JudgeIfServer2(id))
                {
                    goServer();
                    // UserData.isClient = true;
                }
            }
            else
            {
                if (MyOperation.JudgeIfServer2(id))
                {
                    goClient();
                    // UserData.isClient = true;
                }
            }
            m_id = id;
            InitializeComponent();
            scanner.Focus();
            #region 数据库读取信息
            MySqlConnection con = new MySqlConnection(UserData.conStr);
            con.Open();
            string sql = "select * from user where id='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            while (mdr.Read())
            {
                lab_Name.Text = mdr.GetString("name");
                this.Text = "与" + mdr.GetString("name") + "的聊天";
                picture.Image = MyOperation.LoadImage(mdr.GetString("photoPath").ToString());
                lab_sign.Text += mdr.GetString("sign");
            }
            con.Close();
            cmd.Dispose();
            #endregion
        }


        private ChatListSubItem TurnChatToSubItem(string msg)
        {
            ChatListSubItem sub = new ChatListSubItem();
            MySqlConnection con = new MySqlConnection(UserData.conStr);
            con.Open();
            string sql = "select * from user where id='" + this.m_id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            while (mdr.Read())
            {
                sub.DisplayName = mdr.GetString("name");
                sub.ID = Convert.ToUInt32(mdr.GetString("id"));
                sub.HeadImage = MyOperation.LoadImage(mdr.GetString("photoPath").ToString());
                sub.PersonalMsg = msg;//这里显示最近聊天内容
                sub.IsTwinkle = true;
            }
            con.Close();
            cmd.Dispose();
            return sub;
        }

        private bool IsDistinct(string changeText)
        {
            bool isSame = false;
            foreach (ChatListSubItem item in InfoList.CreateOrReadInstance().chatListBox_Message.Items[0].SubItems)
            {
                if (item.ID.ToString().Trim()== m_id.ToString().Trim())
                {
                    isSame = true;
                    item.PersonalMsg = changeText;
                    break;
                }
            }
            return isSame;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            emojiGroup.Visible = false;
            if (scanner.Text != "")
            {
                if (UserData.isClient)
                {
                    SendClient();
                }
                else
                {
                    sendServer(scanner.Text);
                }
                ChatListSubItem recentSub = TurnChatToSubItem(scanner.Text);
                if (IsDistinct(scanner.Text))
                {
                    InfoList.CreateOrReadInstance().chatListBox_Message.Items[0].SubItems.Remove(recentSub);
                }
                else
                {
                    InfoList.CreateOrReadInstance().chatListBox_Message.Items[0].SubItems.Add(recentSub);
                }
                
                scanner.Text = "";
            }
            else
            {
                MessageBox.Show("消息不能为空！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     

        #region 关闭客户端/服务端 （关闭按钮事件)
        private void close_Click(object sender, EventArgs e)
        {
            if (UserData.isClient)
            {
                StopClient();
            }
            else
            {
                StopServer();
            }
            this.Close();
        }
        #endregion


        #region 图片，文件，表情块

        #region 打字时隐藏表情组
        private void scanner_TextChanged(object sender, EventArgs e)
        {
            emojiGroup.Visible = false;
        }
        private void screen_TextChanged(object sender, EventArgs e)
        {
            emojiGroup.Visible = false;
        }
        #endregion
        private void emoji_Click(object sender, EventArgs e)
        {
            if (emojiGroup.Visible)
            {
                emojiGroup.Visible = false;
            }
            else
            {
                emojiGroup.Visible = true;
            }
        }

        private void hideEmoji(object sender, EventArgs e)
        {
            emojiGroup.Visible = false;
        }

        private void folder_Click(object sender, EventArgs e)
        {
            emojiGroup.Visible = false;
            //设置过滤条件
            open.Filter = "所有文件(*.*)|*.*";
            open.Title = "打开";
            open.FilterIndex = 2;
            if (open.ShowDialog() == DialogResult.OK)
            {
                string fileName = open.FileName;
                FileStream fs = new FileStream(fileName,FileMode.Open,FileAccess.Read);//创建文件流读取数据
                string fileN = Path.GetFileName(fileName);//提取文件名
                byte[] arrMsg = Encoding.UTF8.GetBytes(fileN);
                byte[] arrSendMsg = new byte[arrMsg.Length + 2];
                arrSendMsg[0] = 0;
                arrSendMsg[1] = 1;//表示发生文件信息
                Buffer.BlockCopy(arrMsg, 0, arrSendMsg, 2, arrMsg.Length);
                if (UserData.isClient)
                {
                    socketSendClient.Send(arrSendMsg);
                }
                else
                {
                    socketSendServer.Send(arrSendMsg);
                }
                lock (screen)
                {
                    screen.AppendTextAsRtf(UserData.m_userData.DisplayName + "  " + DateTime.Now.ToString() + "\r\n",
                             new Font(this.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Blue);
                    screen.AppendTextAsRtf("正在向对方传输文件：" + fileN + "~Please wait...\r\n",
                             new Font(screen.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Black);
                }
                byte[] arrFile = new byte[fs.Length];//缓存
                int length = fs.Read(arrFile, 0, arrFile.Length);
                byte[] SendarrFile = new byte[length + 2];
                SendarrFile[0] = 1;
                SendarrFile[1] = 1;//表示传输文件内容
                Buffer.BlockCopy(arrFile, 0, SendarrFile, 2, length);
                if (UserData.isClient)
                {
                    socketSendClient.Send(SendarrFile);
                }
                else
                {
                    socketSendServer.Send(SendarrFile);
                }
                lock (screen)
                {
                    screen.AppendTextAsRtf(UserData.m_userData.DisplayName + "  " + DateTime.Now.ToString() + "\r\n",
                             new Font(this.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Blue);
                    screen.AppendTextAsRtf("传输文件"+fileN+"完毕！\r\n",
                             new Font(screen.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Black);
                }
            }
        }

        private void photo_Click(object sender, EventArgs e)
        {
            emojiGroup.Visible = false;
            //设置对话框的过滤条件
            open.Filter = "bmp文件（*.bmp）|*.bmp|jpg 文件（*.jpg）|*.jpg|ico 文件（*.ico）|*.ico|png 文件（*.png）|*.png";
            open.Title = "打开图片";
            open.FilterIndex = 2;
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(open.FileName);//获得图片
                SendPicture(img);
            }
        }

        private void emoji0_Click(object sender, EventArgs e)
        {
            int num = 0;
            SkinPictureBox btn = (SkinPictureBox)sender;
            switch (btn.Name)
            {
                case "emoji1":
                    num = 1;
                    break;
                case "emoji2":
                    num = 2;
                    break;
                case "emoji3":
                    num = 3;
                    break;
                case "emoji4":
                    num = 4;
                    break;
                case "emoji5":
                    num = 5;
                    break;
                case "emoji6":
                    num = 6;
                    break;
                case "emoji7":
                    num = 7;
                    break;
                case "emoji8":
                    num = 8;
                    break;
                case "emoji9":
                    num = 9;
                    break;
            }
            String path = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            path = path.Substring(0, path.LastIndexOf("\\"));
            Image img = Image.FromFile(path + "\\Resources\\emoji\\" + num.ToString() + ".png");//获得图片
            SendPicture(img);
            emojiGroup.Visible = false;
        }
        #endregion

        private void Chat_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        #region 服务端
        public Socket socketSendServer;//服务器端


        public  void ListenServer(object o)
        {
            try
            {
                Socket socketWatch = o as Socket;
                while (true)
                {
                    socketSendServer = socketWatch.Accept();//等待接收客户端连接
                    Thread r_thread = new Thread(receivedServer);
                    r_thread.SetApartmentState(ApartmentState.STA);
                    r_thread.IsBackground = true;
                    r_thread.Start(socketSendServer);
                }
            }
            catch
            {
            }
        }

        public void goServer()
        {
            try
            {
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Any;
                IPEndPoint point = new IPEndPoint(ip, UserData.port);
                socketWatch.Bind(point);//绑定端口号
                socketWatch.Listen(10);
                //创建监听线程
                Thread thread = new Thread(ListenServer);
                thread.SetApartmentState(ApartmentState.STA);
                thread.IsBackground = true;
                thread.Start(socketWatch);
                MessageBox.Show("服务端开启成功！");
            }
            catch
            {
                //MessageBox.Show("服务端开启失败！");
            }
        }


        //服务器端接受客户端发来的消息
        public  void receivedServer(object o)
        {
            int len = 0;
            //try
            //{
            Socket socketSend = o as Socket;
                while (true)
                {
                    byte[] recieve = new byte[1024 * 1024 * 200];

                //实际接收到的有效字节数
                try
                {
                     len = socketSend.Receive(recieve) - 2;
                }
                catch (Exception)
                {
                }
                    
                    if (len != 0)
                    {
                        //取标记
                        byte flag1 = recieve[0];
                        byte flag2 = recieve[1];
                        //去除标记
                        byte[] buffer = new byte[len];
                        for(int j = 0; j < len; j++)
                        {
                            buffer[j] = recieve[j + 2];
                        }
                        //照片
                        if (flag1 == (byte)0&& flag2 == (byte)0)
                        {
                            MemoryStream ms = new MemoryStream(buffer);
                            ms.Position = 0;
                            Image img;
                            img= Image.FromStream(ms);
                            ms.Close();
                            lock (screen)
                            {
                                screen.AppendTextAsRtf(lab_Name.Text + "  " + DateTime.Now.ToString() + "\r\n",
                                     new Font(this.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Green);
                                screen.ReadOnly = false;
                                screen.InsertImage(img);
                                screen.ReadOnly = true;
                                screen.AppendTextAsRtf("\r\n",
                                         new Font(screen.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Black);
                            }
                         
                        }
                        //文件名
                        else if (flag1 == (byte)0 && flag2 == (byte)1)
                        {
                            string fileName = Encoding.UTF8.GetString(buffer,0,len);
                            UserData.fileName = fileName;
                            lock (screen)
                            {
                                screen.AppendTextAsRtf(lab_Name.Text + "  " + DateTime.Now.ToString() + "\r\n",
                             new Font(this.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Green);
                                screen.AppendTextAsRtf("正在接收文件：" + fileName + "~ Please wait...\r\n",
                                         new Font(screen.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Black);
                            }
                        }
                        //文本
                        else if (flag1 == (byte)1 && flag2 == (byte)0)
                        {
                            //客户端连接服务器成功后，服务器接收客户端发送的消息
                            string str = Encoding.UTF8.GetString(buffer, 0, len);
                            screen.AppendTextAsRtf(lab_Name.Text + "  " + DateTime.Now.ToString() + "\r\n",
                                 new Font(this.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Green);
                            screen.AppendTextAsRtf(str + "\r\n",
                                 new Font(screen.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Black);
                            
                        }
                        //文件内容
                        else if (flag1 == (byte)1 && flag2 == (byte)1)
                        {
                            SaveFileDialog save = new SaveFileDialog();
                            string fullPath = Path.Combine(UserData.spath, UserData.fileName);
                            FileStream filesave = new FileStream(fullPath, FileMode.Create, FileAccess.Write);
                            filesave.Write(buffer, 0, len);
                            lock (screen)
                            {
                                screen.AppendTextAsRtf(lab_Name.Text + "  " + DateTime.Now.ToString() + "\r\n",
                             new Font(this.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Green);
                                screen.AppendTextAsRtf("接收文件：" + UserData.fileName + "完毕！请在桌面查收~\r\n",
                                         new Font(screen.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Black);
                            }
                        filesave.Close();
                    }
                    }
                }
            //}
            //catch
            //{
            //    MessageBox.Show("无法收到客户端消息！");
            //}
        }

        public void sendServer(string str)
        {
            byte[] text = Encoding.UTF8.GetBytes(str);
            //将10作为标记文本
            byte[] flag = { (byte)1, (byte)0 };
            byte[] buffer = new byte[flag.Length + text.Length];
            flag.CopyTo(buffer, 0);
            text.CopyTo(buffer, flag.Length);
            socketSendServer.Send(buffer);
            screen.AppendTextAsRtf(UserData.m_userData.DisplayName + "  " + DateTime.Now.ToString() + "\r\n",
                         new Font(this.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Blue);
            screen.AppendTextAsRtf(str + "\r\n",
                 new Font(screen.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Black);
        }

       

        public void SendPicture(Image img)
        {
            MemoryStream stream = new MemoryStream();
            img.Save(stream, ImageFormat.Bmp);//转成流
            BinaryReader br = new BinaryReader(stream);
            byte[] photo;
            //将00作为标记照片
            byte[] flag = {(byte)0, (byte)0 };
            photo = stream.ToArray();
            byte[] buffer = new byte[flag.Length + photo.Length];
            flag.CopyTo(buffer,0);
            photo.CopyTo(buffer, flag.Length);
            if (UserData.isClient)
            {
                socketSendClient.Send(buffer);
            }
            else
            {
                socketSendServer.Send(buffer);
            }
            stream.Close();

            lock(screen){
                screen.AppendTextAsRtf(UserData.m_userData.DisplayName + "  " + DateTime.Now.ToString() + "\r\n",
                         new Font(this.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Blue);
                screen.ReadOnly = false;
                screen.InsertImage(img);
                screen.ReadOnly = true;
                screen.AppendTextAsRtf("\r\n",
                         new Font(screen.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Black);
            }
           
        }

        public void StopServer()
        {
            if (socketSendServer != null)
                socketSendServer.Close();
            MessageBox.Show("服务端关闭成功！");
        }
        #endregion

        #region 客户端
        public Socket socketSendClient;
        public void goClient()
        {
            //try
            //{
                socketSendClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(UserData.ip);
                //IPAddress ip = IPAddress.Parse("172.16.30.91");
                IPEndPoint point = new IPEndPoint(ip, UserData.port);
                socketSendClient.Connect(point);
                Thread c_thread = new Thread(receivedClient);
                c_thread.SetApartmentState(ApartmentState.STA);
                c_thread.Start();
                MessageBox.Show("客户端开启成功！");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("请确保已打开服务端监听！");
            //}
        }

        //接收服务端返回的消息

        public void receivedClient()
        {
            int len=0;
            while (true)
            {
                try
                {
                    byte[] recieve = new byte[1024 * 1024 * 200];
                    //实际接收到的有效字节数
                    try
                    {
                         len = socketSendClient.Receive(recieve) - 2;
                    }
                    catch (Exception ex)
                    {
                        break;
                    }
                   
                    if (len != 0)
                    {
                        //取标记
                        byte flag1 = recieve[0];
                        byte flag2 = recieve[1];
                        //去除标记
                        byte[] buffer = new byte[len];
                        for (int j = 0; j < len; j++)
                        {
                            buffer[j] = recieve[j + 2];
                        }
                        //00照片
                        if (flag1 == (byte)0&& flag2 == (byte)0)
                        {
                            MemoryStream ms = new MemoryStream(buffer);
                            ms.Position = 0;
                            Image img = Image.FromStream(ms);
                            lock (screen)
                            {
                                screen.AppendTextAsRtf(lab_Name.Text + "  " + DateTime.Now.ToString() + "\r\n",
                                     new Font(this.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Green);
                                screen.ReadOnly = false;
                                screen.InsertImage(img);
                                screen.ReadOnly = true;
                                screen.AppendTextAsRtf("\r\n",
                                         new Font(screen.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Black);
                            }
                            ms.Close();
                        

                        }
                        //01文件信息
                        else if (flag1 == (byte)0 && flag2 == (byte)1)
                        {
                            string fileName = Encoding.UTF8.GetString(buffer, 0, len);
                            UserData.fileName = fileName;
                            lock (screen)
                            {
                                screen.AppendTextAsRtf(lab_Name.Text + "  " + DateTime.Now.ToString() + "\r\n",
                             new Font(this.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Green);
                                screen.AppendTextAsRtf("正在接收文件：" + fileName + "~ Please wait...\r\n",
                                         new Font(screen.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Black);
                            }
                        }
                        //10文本
                        else if (flag1 == (byte)1 && flag2 == (byte)0)
                        {
                            //客户端连接服务器成功后，服务器接收客户端发送的消息
                            string str = Encoding.UTF8.GetString(buffer, 0, len);
                            //screen.Text += str;
                            screen.AppendTextAsRtf(lab_Name.Text + "  " + DateTime.Now.ToString() + "\r\n",
                                 new Font(this.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Green);
                            screen.AppendTextAsRtf(str + "\r\n",
                                 new Font(screen.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Black);
               
                        }
                        //文件内容
                        else if (flag1 == (byte)1 && flag2 == (byte)1)
                        {
                            SaveFileDialog save = new SaveFileDialog();
                            string fullPath = Path.Combine(UserData.spath, UserData.fileName);
                            FileStream filesave = new FileStream(fullPath, FileMode.Create, FileAccess.Write);
                            filesave.Write(buffer, 0, len);
                            filesave.Close();
                            lock (screen)
                            {
                                screen.AppendTextAsRtf(lab_Name.Text + "  " + DateTime.Now.ToString() + "\r\n",
                             new Font(this.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Green);
                                screen.AppendTextAsRtf("接收文件：" + UserData.fileName + "完毕！请在桌面查收~\r\n",
                                         new Font(screen.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Black);
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("无法收到服务端消息！");
                    break;
                }
            }
        }

        public void SendClient()
        {
            try
            {
                string msg = scanner.Text;
                byte[] text = Encoding.UTF8.GetBytes(msg);
                //将10作为标记文本
                byte[] flag = { (byte)1, (byte)0 };
                byte[] buffer = new byte[flag.Length + text.Length];
                flag.CopyTo(buffer, 0);
                text.CopyTo(buffer, flag.Length);
                socketSendClient.Send(buffer);
                screen.AppendTextAsRtf(UserData.m_userData.DisplayName + "  " + DateTime.Now.ToString() + "\r\n",
                         new Font(this.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Blue);
                screen.AppendTextAsRtf(msg + "\r\n",
                     new Font(screen.Font, FontStyle.Regular), RtfRichTextBox.RtfColor.Black);
            }
            catch
            {

            }
        }

        //断开连接
        public void StopClient()
        {
            if(socketSendClient!=null)
            socketSendClient.Close();
            MessageBox.Show("客户端关闭成功！");
        }

        #endregion
    }
}
