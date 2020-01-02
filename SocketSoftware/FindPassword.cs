using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SocketSoftware
{
    public partial class FindPassword : Form
    {
        Login login = null;
        public FindPassword(Login login)
        {
            this.login = login;
            InitializeComponent();
        }

        //连接数据库
        //static string conStr = "server=localhost;port=3306;database=user;user=root;password=root;";
        MySqlConnection con = new MySqlConnection(UserData.conStr);
        private void yep_Click(object sender, EventArgs e)
        {
            text_password.Text = "";
            if (text_id.Text == "" || text_phone.Text == "")
            {
                MessageBox.Show("账号和手机号不能为空！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            con.Open();
            //连接数据库查询
            string sql = "select * from user where id = '"+text_id.Text+"' and phone ='"+text_phone.Text+"' ";
            bool flag = false;
            MySqlCommand command = new MySqlCommand(sql, con);
            MySqlDataReader reader = command.ExecuteReader();
            MySqlDataReader user = null;
            while (reader.Read())
            {
                if ((reader.GetValue(0).ToString().Trim()) == (text_id.Text.Trim())&& (reader.GetValue(5).ToString().Trim()) == (text_phone.Text.Trim()))
                {
                    flag = true;
                    user = reader;
                    break;
                }
            }
            if (!flag)
            {
                MessageBox.Show("账号或手机号错误！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                text_password.Text = user.GetValue(1).ToString();
            }
            con.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            login.Visible = true;
            this.Close();
        }

        private void FindPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
