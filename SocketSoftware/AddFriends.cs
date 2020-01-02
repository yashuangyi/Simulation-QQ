using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SocketSoftware
{
    public partial class AddFriends : Form
    {
        private InfoList me_Info;
        private static AddFriends _instance;
        public static AddFriends Instance { get => _instance; set => _instance = value; }
        public AddFriends(InfoList m_infoList)
        {
            InitializeComponent();
            _instance = this;
            me_Info = m_infoList;
        }
        public static AddFriends CreateInstance(InfoList m_infoList)
        {
            if (Instance == null || Instance.IsDisposed) return new AddFriends(m_infoList);
            else return Instance;
        }
      

        /// <summary>
        /// 点击搜索事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinPictureBox_search_Click(object sender, EventArgs e)
        {
            skinFlowLayoutPanel_SearchList.Visible = false;
            //从数据库导出账号列表
            string searchId = skinWaterTextBox_search.Text; //获取到输入的内容
            SearchIdOnMySQL(searchId);
            bool isFind = true;
            if (isFind) //找得到，显示列表
            {
                skinFlowLayoutPanel_SearchList.Visible = true;//再次搜索时设置不可见
                UserData.searchId = searchId;
            }
            else  //找不到，返回搜索失败提示
            {
                Lab_NoSearchMention.Visible = true;//再次点击搜索框时设置不可见。
            }

        }

        private void SearchIdOnMySQL(string m_id)
        {
            MySqlConnection con = new MySqlConnection(UserData.conStr);
            con.Open();
            string sql = "select * from user where id='"+m_id+"'";
            MySqlCommand cmd = new MySqlCommand(sql,con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            while (mdr.Read())
            {
                string[] tempArray = new string[5];
                tempArray[0] = "id: "+mdr.GetString("id");
                tempArray[1] = "name: "+mdr.GetString("name");
                tempArray[2] = "age: " + mdr.GetString("age");
                tempArray[3] = "sign: " + mdr.GetString("sign");
                tempArray[4] = "address: "+mdr.GetString("address");
                skinWaterTextBox_AllInfo.Lines = tempArray;
            }
            con.Close();
            cmd.Dispose();
        }
       

        /// <summary>
        /// 添加好友按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bu_Add_Click(object sender, EventArgs e)
        {
            //把好友放到自己的列表
            //更新数据库
            // MessageBox.Show("Success to add friends!", "Mention:", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //暂时放这里
            Msg_IfAddFriend m_msg = Msg_IfAddFriend.CreateInstance(me_Info);
            m_msg.Show();
        }

        /// <summary>
        /// 点击搜索框触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkinWaterTextBox1_Click(object sender, EventArgs e)
        {
            skinFlowLayoutPanel_SearchList.Visible = false;
            Lab_NoSearchMention.Visible = false;
        }

        private void AddFriends_Load(object sender, EventArgs e)
        {

        }
    }
}
