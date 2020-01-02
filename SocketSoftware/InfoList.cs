using CCWin.SkinControl;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SocketSoftware
{
    public partial class InfoList : Form
    {
        #region 单例实现，带释放处理
        private static InfoList _instance;
        public static InfoList Instance { get => _instance; set => _instance = value; }
        public static InfoList CreateOrReadInstance()
        {
            if (Instance == null || Instance.IsDisposed ) return new InfoList();
            return Instance;
        }
        #endregion 

        //private UserData me = null;
        public InfoList()
        {
            InitializeComponent();
            // chatListBox_Friend.Items.Add(MyOperation.myChatListItem);

           // this.me = UserData.m_userData;
            lab_Name.Text = UserData.m_userData.DisplayName;
            lab_signature.Text = UserData.m_userData.PersonalSignature;
            Instance = this;
            LoadAndRenameItem();
           
            #region 加载图像
            MySqlConnection con = new MySqlConnection(UserData.conStr);
            con.Open();
            string sql = "select photoPath from user where id='"+UserData.m_userData.UserAccount+"'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            while (mdr.Read())
            {
                if (mdr.GetString("photoPath").Equals(""))
                {
                    break;
                }
                else
                {
                    skinPictureBox_head.Image = MyOperation.LoadImage(mdr.GetString("photoPath").ToString());
                }
                break;
            }
            con.Close();
            cmd.Dispose();//释放cmd
            #endregion
        }

        #region 打开编辑资料框（右击头像编辑个人资料）
        private void 编辑个人资料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           PersonalInfo.CreateInstance(UserData.m_userData.UserAccount).Show();            
        }
        #endregion

        #region 切换不同的3个chatListBox
        /// <summary>
        /// 点消息按钮，切换到消息列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 消息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chatListBox_Message.Visible = true;
            chatListBox_Friend.Visible = false;
            chatListBox_newFriends.Visible = false;
        }

        bool ifHandleIt = false;
        /// <summary>
        /// 点好友按钮，切换到好友列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 好友ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chatListBox_Message.Visible = false;
            chatListBox_Friend.Visible = true;
            chatListBox_newFriends.Visible = false;
            if (ifHandleIt == false)
            {
                HandleIt();
                ifHandleIt = true;
            }
            
        }
        /// <summary>
        /// 点新的好友按钮，处理新添加的好友
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 新的好友ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chatListBox_Message.Visible = false;
            chatListBox_Friend.Visible = false;
            chatListBox_newFriends.Visible = true;
        }
        #endregion

        #region 下拉隐藏功能
        bool isGuide = false; // 窗体是否引导
        bool isShrink = false; // 窗体是否隐藏
        const int GUIDE_DISTANCE = 15;  // 窗体引导距离
        const int BULGE_DISTANCE = 3; // 窗体靠边凸出部分距离
        /// <summary>
        /// 引导窗体
        /// </summary>
        private void GuideFrm()
        {
            /* 判断窗体边缘是否进入引导距离
             * true     靠边，“isGuide = false;”，窗体已引导
             * false    “isGuide = false;”，窗体未引导
             */
            if (this.Left < GUIDE_DISTANCE && this.Left > -GUIDE_DISTANCE)
            {
                this.Left = 0;
                isGuide = true;
            }
            else if (this.Top < GUIDE_DISTANCE && this.Top > -GUIDE_DISTANCE)
            {
                this.Top = 0;
                isGuide = true;
            }
            else if (this.Right < (Screen.GetWorkingArea(this).Width + GUIDE_DISTANCE) && this.Right > (Screen.GetWorkingArea(this).Width - GUIDE_DISTANCE))
            {
                this.Left = Screen.GetWorkingArea(this).Width - this.Width;
                isGuide = true;
            }
            else
            {
                isGuide = false;
            }
        }
        /// <summary>
        /// 隐藏窗体
        /// </summary>
        private void HideFrm()
        {
            /* 窗体是否靠边
             * true     窗体隐藏
             * false    
             */
            if (this.Left == 0)
            {
                this.Left = -(this.Width - BULGE_DISTANCE);
            }
            else if (this.Top == 0)
            {
                this.Top = -(this.Height - BULGE_DISTANCE);
            }
            else if (this.Right == (Screen.GetWorkingArea(this).Width))
            {
                this.Left = Screen.GetWorkingArea(this).Width - BULGE_DISTANCE;
            }
            // 窗体已隐藏
            isShrink = true;
            // 窗体引导关闭
            isGuide = false;


            // 窗体置顶
            this.TopMost = true;
            // 在Windows任务栏中不显示窗体
            this.ShowInTaskbar = false;
        }
        /// <summary>
        /// 显示窗体
        /// </summary>
        private void ShowFrm()
        {
            // 窗体是否靠边
            if (this.Left == -(this.Width - BULGE_DISTANCE))
            {
                this.Left = 0;
            }
            else if (this.Top == -(this.Height - BULGE_DISTANCE))
            {
                this.Top = 0;
            }
            else if (this.Right == Screen.GetWorkingArea(this).Width + this.Width - BULGE_DISTANCE)
            {
                this.Left = Screen.GetWorkingArea(this).Width - this.Width;
            }
            // 窗体未隐藏
            isShrink = false;


            // 窗口不置顶
            this.TopMost = false;
            // 在Windows任务栏中显示窗体
            this.ShowInTaskbar = true;
        }
        /// <summary>
        /// 窗体缩放
        /// </summary>
        private void ZoomFrm()
        {
            // 获取鼠标位置
            int mouseX = MousePosition.X;
            int mouseY = MousePosition.Y;
            // 获取窗体位置
            int frmX = this.Location.X;
            int frmY = this.Location.Y;


            /* 鼠标是否在窗体内
             * true     显示窗体
             * false    隐藏窗体
             */
            if (mouseX > frmX - 1 && mouseX < frmX + this.Width + 1 && mouseY > frmY - 1 && mouseY < frmY + this.Height + 1)
            {
                // 窗体隐藏时才显示窗体
                if (isShrink)
                {
                    ShowFrm();
                }
            }
            else
            {
                // 窗体引导时才隐藏窗体
                if (isGuide)
                {
                    HideFrm();
                }
            }
        }
        private void InfoList_Move(object sender, EventArgs e)
        {
            GuideFrm();
        }
        /// <summary>
        /// 窗体缩放事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
              ZoomFrm(); // 缩放窗体
        }
        #endregion

        #region 窗体加载和关闭
        /// <summary>
        /// 窗体关闭事件。（为了把隐藏的登录界面也关掉
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoList_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyOperation.RemoveIfServerFromSQL(MyOperation.MyId);
            SaveLoactionToSQL();
            
            Login ins = Login.CreateInstance();
            ins.Close();
        }
        /// <summary>
        /// 加载该窗体时,设置下拉timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoList_Load(object sender, EventArgs e)
        {
            // 设置500毫秒检查一次窗体是否需要缩放
            this.timZoom.Interval = 500;
            // 启动窗体缩放事件
            this.timZoom.Enabled = true;
            skinMenuStrip_Main3.Focus();
          
        }
        #endregion
        
        # region 下端的两个按钮事件
        /// <summary>
        /// 添加好友按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripButton_AddFriends_Click(object sender, EventArgs e)
        {
            AddFriends ins = AddFriends.CreateInstance(this);
            ins.Show();
        }

        private bool isPanelVisible = false;
        /// <summary>
        /// 最下端列表item的单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripButton_list_Click(object sender, EventArgs e)
        {
            if (isPanelVisible == false)
            {
                skinPanel_list.Visible = true;
                isPanelVisible = true;
            }
            else
            {
                skinPanel_list.Visible = false;
                isPanelVisible = false;
            }
           
        }
        #endregion

        #region 最下端列表的三个按钮的点击事件，设置和帮助的逻辑暂时是MessageBox
        /// <summary>
        /// 设置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinButton_set_Click(object sender, EventArgs e)
        {
            skinPanel_list.Visible = false;
            //弹出设置框，设置各种属性,比如设置背景色。。。。水他！
            MessageBox.Show("想要获取设置功能请充值VIP！","您未充值！",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// 帮助按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinButton_help_Click(object sender, EventArgs e)
        {
            skinPanel_list.Visible = false;
            //弹出一堆吹水的东西
            MessageBox.Show("详情请咨询开发者，微信pis272438442", "help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 切换按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinButton_shiftId_Click(object sender, EventArgs e)
        {
            skinPanel_list.Visible = false;
            Login ins = Login.CreateInstance();
            ins.Show();
            SaveLoactionToSQL();
            this.Dispose();
        }
        #endregion

        #region 更改头像，包含了保存路径到数据库和保存图片到磁盘的方法
        private void 更改头像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //用户选择一张图片打开
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "open";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                skinPictureBox_head.Load(openFileDialog.FileName);
                SavePhotoToDisk_WritePhotoPathToMySqlDBS(UserData.m_userData.UserAccount); //放到用户文件夹的路径中并更新数据库
            }
            openFileDialog.Dispose();//释放对象！
        }
        public  void SavePhotoToDisk_WritePhotoPathToMySqlDBS(string userName)
        {
            string currentTime = DateTime.Now.ToString("yyMMddhhmmss");
            string photoPath = @".\headPhotos\" + userName;
            Directory.CreateDirectory(photoPath);
            FileInfo fi = new FileInfo(@".\headPhotos\" + userName + "\\" + currentTime + ".png");
            Bitmap bmp = new Bitmap(skinPictureBox_head.Image);
            bmp.Save(fi.FullName, skinPictureBox_head.Image.RawFormat);

            string spe = @"./headPhotos/" + userName + "/" + currentTime + ".png";
            MySqlConnection con = new MySqlConnection(UserData.conStr);
            con.Open();
            string sql = "update user set photoPath='" +spe + "'where id='" + userName + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            bmp.Dispose();//释放！
        }
        #endregion

        #region  字典和聊天窗口的处理
        /// <summary>
        /// 最近信息列表的 点击对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="es"></param>
        private void ChatListBox_Message_DoubleClickSubItem(object sender, CCWin.SkinControl.ChatListEventArgs e, MouseEventArgs es)
        {
            Chat CommunicateDialog = Chat.CreateOrOpenChatById(ref idDic, e.SelectSubItem.ID.ToString().Trim());
            CommunicateDialog.Show();
        }
        /// <summary>
        /// 好友列表的点击对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="es"></param>
        private void ChatListBox_Friend_DoubleClickSubItem(object sender, CCWin.SkinControl.ChatListEventArgs e, MouseEventArgs es)
        {
            Chat CommunicateDialog = Chat.CreateOrOpenChatById(ref idDic, e.SelectSubItem.ID.ToString().Trim());
            CommunicateDialog.Show();
        }
        private void ChatListBox_newFriends_DoubleClickSubItem(object sender, ChatListEventArgs e, MouseEventArgs es)
        {
            Chat CommunicateDialog = Chat.CreateOrOpenChatById(ref idDic, e.SelectSubItem.ID.ToString().Trim());
            CommunicateDialog.Show();
        }
        private Dictionary<string,Chat> idDic = new Dictionary<string, Chat>();
        #endregion

        #region 列表更新算法
        /// <summary>
        ///从数据库中取出和处理要添加的subitem
        /// </summary>
        private void HandleIt()
        {
            for (int i = 0; i < 4; i++)
            {
                #region  把登录的特定用户的好友分类，相同index的放到list里
                List<string> friendList = new List<string>();
                MySqlConnection con = new MySqlConnection(UserData.conStr);
                con.Open();
                string sql = "select * from connection where userId='" + MyOperation.MyId + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader mdr = cmd.ExecuteReader();
                while (mdr.Read())
                {
                    if(mdr.GetString("index")==i.ToString())
                    friendList.Add(mdr.GetString("friendId"));
                }
                LoadConnectionFromList(i, friendList);
                con.Close();
                cmd.Dispose();
                #endregion
            
            }
        }
        /// <summary>
        ///  从list里读取添加subItem到Item[index]
        /// </summary>
        /// <param name="index"></param>
        /// <param name="friendList"></param>
        private void LoadConnectionFromList(int index,List<string> friendList)
        {
           
            for (int i = 0; i < friendList.Count; i++)
            {
                ChatListSubItem sub = new ChatListSubItem();
                MySqlConnection con = new MySqlConnection(UserData.conStr);
                con.Open();
                string sql = "select * from user where id='" + friendList[i] + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader mdr = cmd.ExecuteReader();
                while (mdr.Read())
                {
                    sub.DisplayName = mdr.GetString("name");
                    sub.ID = Convert.ToUInt32(mdr.GetString("id"));
                    sub.HeadImage = MyOperation.LoadImage(mdr.GetString("photoPath").ToString());
                    sub.PersonalMsg = mdr.GetString("sign");
                }
                chatListBox_Friend.Items[index].SubItems.Add(sub);
                con.Close();
                cmd.Dispose();
            }
          
        }

        /// <summary>
        /// 关闭窗体时保存item项
        /// </summary>
        private void SaveLoactionToSQL()
        {
            #region 先清空该用户在数据库的信息
            ClearUserIdInSql();
            #endregion
            #region 读取item，保存subItem到字典
            int i = 0;
            Dictionary<int, List<string>> dic = new Dictionary<int, List<string>>();
            foreach (ChatListItem item in chatListBox_Friend.Items)
            {
                dic.Add(i, new List<string>());
                foreach (ChatListSubItem subItem in item.SubItems)
                {
                    dic[i].Add(subItem.ID.ToString());
                }
                i++;
            }
            #endregion
            #region  遍历字典，将该用户的好友关心重新插入数据库
            foreach (KeyValuePair<int, List<string>> kvp in dic)
            {
                for (int j = 0; j < kvp.Value.Count; j++)
                {
                    MySqlConnection con = new MySqlConnection(UserData.conStr);
                    con.Open();
                    string sql = "insert into connection values('" + MyOperation.MyId + "','" + kvp.Value[j] + "','"+kvp.Key.ToString()+"')";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    cmd.Dispose();
                }
            }
            #endregion
        }

        /// <summary>
        /// 加载窗体时加载item项
        /// </summary>
        private void LoadAndRenameItem()
        {
            chatListBox_Friend.Items.Clear();
            for (int i = 0; i < 4; i++)
            {
                ChatListItem temp = new ChatListItem();
                chatListBox_Friend.Items.Add(temp);
            }
          chatListBox_Friend.Items[0].Text = "家人";
          chatListBox_Friend.Items[1].Text = "朋友";
          chatListBox_Friend.Items[2].Text = "新朋友";
          chatListBox_Friend.Items[3].Text = "黑名单";
        }

        /// <summary>
        /// 防止重复问题
        /// </summary>
        private void ClearUserIdInSql()
        {
            MySqlConnection con = new MySqlConnection(UserData.conStr);
            con.Open();
            string sql = "delete from connection where userId='"+ MyOperation.MyId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }
        #endregion

    }




}
