using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketSoftware
{
    public partial class PersonalInfo : Form
    {
       
        private static PersonalInfo _instance;
        public static PersonalInfo Instance { get => _instance; set => _instance = value; }
        public PersonalInfo(string DisplayName)
        {
            InitializeComponent();
            Instance=this;
            //从数据库中读取相应数据到界面
            MySqlConnection con = new MySqlConnection(UserData.conStr);
            con.Open();
            string sql = "select * from user where id='"+ DisplayName + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader mdr = cmd.ExecuteReader();
            while (mdr.Read())
            {
                if (!rtfRichTextBox_birthday.Text.Equals("default")) rtfRichTextBox_birthday.Text = mdr.GetString("birthday");
                rtfRichTextBox_account.Text = mdr.GetString("id");
                rtfRichTextBox_name.Text = mdr.GetString("name");
                rtfRichTextBox_personalSignature.Text = mdr.GetString("sign");
                if (!rtfRichTextBox_address.Text.Equals("default")) rtfRichTextBox_address.Text = mdr.GetString("address");
                if (!rtfRichTextBox_age.Text.Equals("default")) rtfRichTextBox_age.Text = mdr.GetString("age");
                rtfRichTextBox_phoneNum.Text = mdr.GetString("phone");
                if (!rtfRichTextBox_sex.Text.Equals("default")) rtfRichTextBox_sex.Text = mdr.GetString("sex");
                skinWaterTextBox_password.Text = mdr.GetString("password");
            }
            con.Close();
        }
        /// <summary>
        /// 将个人资料面板设计成单例，避免重复打开
        /// </summary>
        /// <returns></returns>
        public static PersonalInfo CreateInstance(string DisplayName)
        {
            if (Instance == null||Instance.IsDisposed) return new PersonalInfo(DisplayName);
            else return Instance;
        }

        /// <summary>
        /// 点击即可编辑个人资料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bu_override_Click(object sender, EventArgs e)
        {
            //只有账号是不可以改的
            Button bu = (Button)sender;
            if (bu.Text == "编辑个人资料")
            {
                rtfRichTextBox_age.ReadOnly = false;
                rtfRichTextBox_birthday.ReadOnly = false;
                rtfRichTextBox_name.ReadOnly = false;
                rtfRichTextBox_personalSignature.ReadOnly = false;
                rtfRichTextBox_sex.ReadOnly = false;
                rtfRichTextBox_phoneNum.ReadOnly = false;
                rtfRichTextBox_address.ReadOnly = false;
                skinWaterTextBox_password.ReadOnly = false;

                rtfRichTextBox_age.BackColor = Color.White;
                rtfRichTextBox_birthday.BackColor = Color.White;
                rtfRichTextBox_name.BackColor = Color.White;
                rtfRichTextBox_personalSignature.BackColor = Color.White;
                rtfRichTextBox_sex.BackColor = Color.White;
                rtfRichTextBox_phoneNum.BackColor = Color.White;
                rtfRichTextBox_address.BackColor = Color.White;
                skinWaterTextBox_password.BackColor = Color.White;
                bu.Text = "确定";
               
                
            }
            else
            {
                rtfRichTextBox_age.ReadOnly = true;
                rtfRichTextBox_birthday.ReadOnly = true;
                rtfRichTextBox_name.ReadOnly = true;
                rtfRichTextBox_personalSignature.ReadOnly = true;
                rtfRichTextBox_sex.ReadOnly = true;
                rtfRichTextBox_phoneNum.ReadOnly = true;
                rtfRichTextBox_address.ReadOnly = false;
                skinWaterTextBox_password.ReadOnly = true;
              
                bu.Text = "编辑个人资料";
                rtfRichTextBox_age.BackColor = Color.WhiteSmoke;
                rtfRichTextBox_birthday.BackColor = Color.WhiteSmoke;
                rtfRichTextBox_name.BackColor = Color.WhiteSmoke;
                rtfRichTextBox_personalSignature.BackColor = Color.WhiteSmoke;
                rtfRichTextBox_sex.BackColor = Color.WhiteSmoke;
                rtfRichTextBox_phoneNum.BackColor = Color.WhiteSmoke;
                rtfRichTextBox_address.BackColor = Color.WhiteSmoke;
                skinWaterTextBox_password.BackColor = Color.WhiteSmoke;
                //数据库接收text的数据:
                MySqlConnection con = new MySqlConnection(UserData.conStr);
                con.Open();
                //string sql = "update user set password='"+skinWaterTextBox_password.Text+"',"
                //   +"age='"+Convert.ToInt32(rtfRichTextBox_age.Text)+"',"
                //   +"name='"+rtfRichTextBox_name.Text+"',"
                //   +"sign='"+rtfRichTextBox_personalSignature.Text+"',"
                //   +"phone='"+rtfRichTextBox_phoneNum.Text+"',"
                //   +"birthday='"+rtfRichTextBox_birthday.Text+"',"
                //   +"address='"+rtfRichTextBox_address.Text+"',"
                //   +"sex='"+rtfRichTextBox_sex.Text+"'"
                //    +"where id='"+rtfRichTextBox_account.Text+"'";


                string sql = "update user set password='" + skinWaterTextBox_password.Text + "',"
             + "age='" + rtfRichTextBox_age.Text + "',"
             + "name='" + rtfRichTextBox_name.Text + "',"
             + "sign='" + rtfRichTextBox_personalSignature.Text + "',"
             + "phone='" + rtfRichTextBox_phoneNum.Text + "',"
             + "birthday='" + rtfRichTextBox_birthday.Text + "',"
             + "address='" + rtfRichTextBox_address.Text + "',"
             + "sex='" + rtfRichTextBox_sex.Text + "'"
               + "where id='" + rtfRichTextBox_account.Text + "'";
               MySqlCommand cmd = new MySqlCommand(sql, con);
               cmd.ExecuteNonQuery();
               con.Close();
                //更新到infolist
                InfoList.Instance.lab_Name.Text = rtfRichTextBox_name.Text.ToString();
                InfoList.Instance.lab_signature.Text = rtfRichTextBox_personalSignature.Text;
            }
            

        }

        /// <summary>
        /// 控制密码是否显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bu_showPwd_Click(object sender, EventArgs e)
        {
            Button bu = (Button)sender;
            if (bu.Text == "显示")
            {
                skinWaterTextBox_password.PasswordChar =default;
                bu.Text = "隐藏";
            }
            else
            {
                skinWaterTextBox_password.PasswordChar = '*';
                bu.Text = "显示";
            }
         

        }


        /// <summary>
        /// 要把个人资料从数据库中加载到界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PersonalInfo_Load(object sender, EventArgs e)
        {
            //暂时用这个模拟数据库(只举例了名字)
           rtfRichTextBox_name.Text= InfoList.Instance.lab_Name.Text;
        }
    }
}
