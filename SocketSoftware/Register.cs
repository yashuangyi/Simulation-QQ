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
using MySql.Data.MySqlClient;

namespace SocketSoftware
{
    public partial class Register : Form
    {
        Login login = null;
        public Register(Login login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void skinWaterTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void picture_Click(object sender, EventArgs e)
        {
            //设置对话框的过滤条件
            openFileDialog1.Filter = "bmp文件（*.bmp）|*.bmp|jpg 文件（*.jpg）|*.jpg|ico 文件（*.ico）|*.ico|png 文件（*.png）|*.png";
            openFileDialog1.Title = "打开图片";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);//获得图片
                Clipboard.SetDataObject(bmp, false);//将图片放在剪贴板中
                picture.Image = bmp;
            }
            
        }

        /// <summary>
        /// 关闭对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_Click(object sender, EventArgs e)
        {
            login.Visible = true;
            this.Close();
        }

        //连接数据库
      
       
        MySqlConnection con = new MySqlConnection(UserData.conStr);
        
        /// <summary>
        /// 注册界面的确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yep_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || password.Text == ""|| name.Text == ""|| phone.Text == "")
            {
                MessageBox.Show("必填项不能为空！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password.Text != passwordAgain.Text)
            {
                MessageBox.Show("两次密码不相等，请重新确认！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            con.Open();
            //连接数据库查询
            string sql = "select * from user where id='" + id.Text + "'";
            bool flag = true;
            MySqlCommand command = new MySqlCommand(sql, con);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if ((reader.GetString("id").ToString().Trim()) == (id.Text.Trim()))
                {
                    flag = false;
                    break;
                }
            }
            con.Close();
            if (!flag)
            {
                MessageBox.Show("账号已存在！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                //将头像存入数据，并将路径取出来
                string path ="";
                //写入数据库
                string sqlAdd = "insert into user values('"+id.Text+ "','" + password.Text + "','" + name.Text + "','" + sign.Text + "','" + path + "','" + phone.Text + "',"+ "null" + "," + "null" + "," + "null" + "," + "null" + "," + "false" + ")";
                MySqlCommand commandAdd = new MySqlCommand(sqlAdd, con);
                int count = commandAdd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("注册成功！", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SavePhotoToDisk_WritePhotoPathToMySqlDBS(id.Text);
                }
                else
                {
                    MessageBox.Show("注册失败！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }


        private void SavePhotoToDisk_WritePhotoPathToMySqlDBS(string userName)
        {
            string currentTime = DateTime.Now.ToString("yyMMddhhmmss");
            string photoPath = @".\headPhotos\" + userName;
            Directory.CreateDirectory(photoPath);
            FileInfo fi = new FileInfo(@".\headPhotos\" + userName + "\\" + currentTime + ".png");
            Bitmap bmp = new Bitmap(picture.Image);
            bmp.Save(fi.FullName, picture.Image.RawFormat);

            string spe = @"./headPhotos/" + userName + "/" + currentTime + ".png";
            MySqlConnection con = new MySqlConnection(UserData.conStr);
            con.Open();
            string sql = "update user set photoPath='" + spe + "'where id='" + userName + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


    }
}
