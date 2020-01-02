using CCWin.SkinControl;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketSoftware
{
    public partial class Msg_IfAddFriend : Form
    {
        private InfoList me_info;
       
        public Msg_IfAddFriend(InfoList m_infoList)
        {
            InitializeComponent();
            me_info = m_infoList;
            Instance = this;
           
        }
        //单例模式
        #region
        private static Msg_IfAddFriend _instance;
        public static Msg_IfAddFriend Instance { get => _instance; set => _instance = value; }
        public static Msg_IfAddFriend CreateInstance(InfoList m_infoList)
        {
            if (Instance == null || Instance.IsDisposed) return new Msg_IfAddFriend(m_infoList);
             return Instance;
        }
        #endregion

        /// <summary>
        /// 添加了该好友的话
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bu_Add_Click(object sender, EventArgs e)
        {
            //自己和对方的列表都要更新该好友。。。
            //以下模拟点击添加好友
            string theId = UserData.searchId;//这里要改，不然只能添加该人
            //先判断能不能添加（重复）
            bool canAdd = true;
           for(int i=0;i<me_info.chatListBox_Friend.Items.Count;i++)
           {
                foreach (ChatListSubItem item in me_info.chatListBox_Friend.Items[i].SubItems)
                {
                    if (item.ID.ToString().Trim() == theId.ToString().Trim())//注意，数据库某些用户名字不等于id，是判断不出重复的
                    {
                        canAdd = false;
                        break;
                    }
                }
           }
            if (canAdd)
            {
                AddFriendById(theId);
                MyOperation.LinkConnection(MyOperation.MyId, UserData.searchId);//让别人加上你
            }
            else
            {
                MessageBox.Show("该好友已经在列表里", "mention:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }

        }

        /// <summary>
        /// 从数据库中读取该好友信息，添加好友到chatListBox
        /// </summary>
        /// <param name="theId"></param>
        private void AddFriendById(string theId)
        {

            ChatListItem item = me_info.chatListBox_Friend.Items[2];
            ChatListSubItem sub = new ChatListSubItem();
            MySqlConnection con = new MySqlConnection(UserData.conStr);
            con.Open();
            string sql = "select * from user where id='" + theId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            while (mdr.Read())
            {
                //更新要添加的组件的信息
                sub.DisplayName = mdr.GetString("name");
                sub.NicName = "null";
                sub.PersonalMsg = mdr.GetString("sign");
                sub.HeadImage = MyOperation.LoadImage(mdr.GetString("photoPath").ToString());
                sub.ID=Convert.ToUInt32( mdr.GetString("id"));
            }
            con.Close();
            cmd.Dispose();
            item.SubItems.Add(sub);
            this.Dispose();
        }   
        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinButton_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Msg_IfAddFriend_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(UserData.conStr);
            con.Open();
            string sql = "select * from user where id='" + me_info.lab_Name + "'";//注意，数据库里名字id不一致的用户会有问题
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            while (mdr.Read())
            {
                //更新界面
                string[] tempArray = new string[5];
                tempArray[0] = "id: " + mdr.GetString("id");
                tempArray[1] = "name: " + mdr.GetString("name");
                tempArray[2] = "age: " + mdr.GetString("age");
                tempArray[3] = "sign: " + mdr.GetString("sign");
                tempArray[4] = "address: " + mdr.GetString("address");
                skinWaterTextBox_info.Lines = tempArray;

            }
            con.Close();
            cmd.Dispose();
        }
    }
}
