using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCWin.SkinControl;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace SocketSoftware
{
    class MyOperation
    {
       // public static string conStr_connection = "server=localhost;port=3306;database=m_dbs;user=root;password=DOTALOVE1314;";
       // public static List<string> FriendList = new List<string>();
      //  public static ChatListItem myChatListItem = new ChatListItem();
        public static string MyId="";
        /// <summary>
        /// 建立连接
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="friendId"></param>
        public static void LinkConnection(string userId,string friendId)
        {
            MySqlConnection con = new MySqlConnection(UserData.conStr);
            con.Open();
            //string sql = "insert into connection values('" + userId + "','" + friendId + "')";
            string sql = "insert into connection values('" + userId + "','" + friendId + "','" + "2" + "')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
            //自动把对方也加上
            MySqlConnection con_other = new MySqlConnection(UserData.conStr);
            con_other.Open();
            string sql_other = "insert into connection values('" + friendId + "','" + userId + "','"+"2"+"')";
            MySqlCommand cmd_other= new MySqlCommand(sql_other, con_other);
            cmd_other.ExecuteNonQuery();
            con_other.Close();
            cmd_other.Dispose();
        }

        /// <summary>
        /// 加载好友关系到List里
        /// </summary>
        //public static void ReadConnectToList(string userId)
        //{
        //    MySqlConnection con = new MySqlConnection(conStr_connection);
        //    con.Open();
        //    string sql = "select friendId from connection where userId='"+userId+"'";
        //    MySqlCommand cmd = new MySqlCommand(sql, con);
        //    MySqlDataReader mdr = cmd.ExecuteReader();
        //    while (mdr.Read())
        //    {
        //        FriendList.Add(mdr.GetString("friendId"));
        //    }
        //    con.Close();
        //    cmd.Dispose();
        //}

        /// <summary>
        /// 从列表里读取好友到subitem
        /// </summary>
        //public static void LoadConnectionFromList()
        //{

        //    for (int i = 0; i < FriendList.Count; i++)
        //    {
        //        ChatListSubItem sub = new ChatListSubItem();
        //        MySqlConnection con = new MySqlConnection(conStr_connection);
        //        con.Open();
        //        string sql = "select * from user where id='" + FriendList[i] + "'";
        //        MySqlCommand cmd = new MySqlCommand(sql, con);
        //        MySqlDataReader mdr = cmd.ExecuteReader();
        //        while (mdr.Read())
        //        {
        //            sub.DisplayName = mdr.GetString("name");
        //            sub.ID =Convert.ToUInt16( mdr.GetString("id"));
        //            sub.HeadImage = LoadImage(mdr.GetString("photoPath").ToString());
        //            sub.PersonalMsg = mdr.GetString("sign");
        //        }
        //        myChatListItem.SubItems.Add(sub);
        //        con.Close();
        //        cmd.Dispose();
        //    }
        //    myChatListItem.Text = "My item";
        //}

        public static Image LoadImage(string path)
        {
            FileInfo info = new FileInfo(path);
            if (info.Exists==false)
            {
                path = @".\headPhotos\" + "default" + "\\" + "default" + ".png";
            }
            PictureBox tempPic = new PictureBox();
            tempPic.Load(path);
            return tempPic.Image;
        }

        public static void SaveIfServerToSQL(string id)
        {
            string flag = UserData.ip;
            MySqlConnection con = new MySqlConnection(UserData.conStr);
            con.Open();
            string sql = "update user set ifServer='"+ flag + "'where id='"+id+"'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }

        public static void RemoveIfServerFromSQL(string id)
        {
            string empty = " ";
            MySqlConnection con = new MySqlConnection(UserData.conStr);
            con.Open();
            string sql = "update user set ifServer='" + empty+ "'where id='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }

        public static bool JudgeIfServer(string id)
        {
            MySqlConnection con = new MySqlConnection(UserData.conStr);
            con.Open();
            string sql = "select ifServer from user where id='" + id.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            while (mdr.Read())
            {
                string str = mdr.GetString("ifServer");
                if (!str.Equals(" "))
                {
                    con.Close();
                    cmd.Dispose();
                    return true;//是服务端
                }
                else
                {
                    break;
                }
            }
            con.Close();
            cmd.Dispose();
            return false;
        }

        public static bool JudgeIfServer2(string id)
        {
            MySqlConnection con = new MySqlConnection(UserData.conStr);
            con.Open();
            string sql = "select ifServer from user where id='" + id.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            while (mdr.Read())
            {
                string str = mdr.GetString("ifServer");
                //MessageBox.Show(str);
                if (!str.Equals(" "))
                {
                    con.Close();
                    cmd.Dispose();
                    UserData.ip = str;
                    //MessageBox.Show(UserData.ip);
                    return true;//是服务端
                }
                else
                {
                    break;
                }
            }
            con.Close();
            cmd.Dispose();
            return false;
        }


        //public static void ReadIP(string id)
        //{
        //    string flag = UserData.ip;
        //    MySqlConnection con = new MySqlConnection(UserData.conStr);
        //    con.Open();
        //    string sql = "select user set ifServer='" + flag + "'where id='" + id + "'";
        //    MySqlCommand cmd = new MySqlCommand(sql, con);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    cmd.Dispose();
        //}


    }
}
