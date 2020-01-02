using System;
using System.Windows.Forms;
using System.Net;
using MySql.Data.MySqlClient;
using System.Net.Sockets;
using System.Threading;

namespace SocketSoftware
{
    public partial class Login : Form
    {
        private static Login _instance;
        public static Login CreateInstance()
        {
            if (_instance == null || _instance.IsDisposed) _instance = new Login();
            return _instance;
        }
        public Login()
        {
            InitializeComponent();
            _instance = this;
        }

        private void loginRegiste_Click(object sender, EventArgs e)
        {
            //弹出新界面，进行注册功能，注册须判断用户名是否已存在，若不存在则存入数据库
            Register register = new Register(this);
            this.Visible = false;
            register.Show();
        }


        //连接数据库
        MySqlConnection con = new MySqlConnection(UserData.conStr);

        private void loginSignIn_Click(object sender, EventArgs e)
        {
            if (loginID.Text == "" || loginCypher.Text == "")
            {
                MessageBox.Show("账号和密码不能为空！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            con.Open();
            //连接数据库查询
            bool flag = false;
            string sql = "select * from user where id='"+loginID.Text+"' and password='"+loginCypher.Text+"'";
            MySqlCommand command = new MySqlCommand(sql, con);
            MySqlDataReader reader = command.ExecuteReader();
            MySqlDataReader user = null;
            while (reader.Read())
            {
                if ((reader.GetValue(0).ToString().Trim()) == (loginID.Text.Trim())&& (reader.GetValue(1).ToString().Trim()) == (loginCypher.Text.Trim()))
                {
                    flag = true;
                    user = reader;
                    break;
                }

            }
            if(!flag)
            {
                MessageBox.Show("账号或密码错误！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList.ToString();
                String name = user.GetValue(2).ToString().Trim();
                String sign = user.GetValue(3).ToString().Trim();
                UserData.m_userData = new UserData(ip, loginID.Text, loginCypher.Text, name, sign);
               // InfoList m_infoList = new InfoList(m_userData);
                InfoList m_infoList = InfoList.CreateOrReadInstance();

                if (server.Checked)
                {
                    UserData.isClient = false;
                    MyOperation.SaveIfServerToSQL(loginID.Text);//服务端初始化ip到数据库
                }
                else
                {
                    UserData.isClient = true;
                }

                m_infoList.Show();
                this.Visible = false;
                #region 初始化好友列表
              //  MyOperation.ReadConnectToList(loginID.Text);
                MyOperation.MyId = loginID.Text;
               // MyOperation.LoadConnectionFromList();
                
                #endregion
            }
            con.Close();
        }

        


        private void loginFindCypher_Click(object sender, EventArgs e)
        {
            //根据用户名和注册所填写手机号来找回密码（二者均正确的情况下）
            FindPassword form = new FindPassword(this);
            this.Visible = false;
            form.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        //加锁防死锁
        bool flag = false;
        private void client_CheckedChanged(object sender, EventArgs e)
        {
            if (!flag)
            {
                flag = true;
                if (client.Checked)
                {
                    client.Checked = true;
                    server.Checked = false;
                }
                else
                {
                    client.Checked = false;
                    server.Checked = true;
                }
                flag = false;
            }
        }

        private void server_CheckedChanged(object sender, EventArgs e)
        {
            if (!flag)
            {
                flag = true;
                if (client.Checked)
                {
                    client.Checked = false;
                    server.Checked = true;
                }
                else
                {
                    client.Checked = true;
                    server.Checked = false;
                }
                flag = false;
            }
        }
    }
}
