using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SocketSoftware
{
   
    public class UserData
    {
        public static UserData m_userData;
        //文件存储路径
        public static string spath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);//姑且桌面吧
        public static bool serverHaveOpened = false;
        
        public static string searchId = "";//搜索好友时 搜索框的id

        //文件名
        public static string fileName = "";
        
        //若为true则表示作为客户端，为false表示作为服务器
        public static bool isClient;
        //服务器地址
        //public static String ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList.ToString();
        public static String ip = GetAddressIP();
        public static string GetAddressIP()
        {
            ///获取服务端
            string AddressIP = string.Empty;
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    AddressIP = _IPAddress.ToString();
                }
            }
            return AddressIP;
        }


        //监听端口
        public static int port = 6666;

       // public static string conStr = "server=localhost;port=3306;database=m_dbs;user=root;password=DOTALOVE1314;";
        public static string conStr = "server=localhost;port=3306;database=socket_software;user=root;password=asd123456;charset=utf8";
        //public static string conStr = "server=172.16.30.140;port=3306;database=user;user=guest;password=jiaopi;"; 
        private string userIp;//通信ip
        private string userAccount;//用户登录账号
        private string userPassWord;//用户登录密码
        private string displayName;//用户名
        private string personalSignature;//个性签名
        private string headPhotoPath;//头像路径

        private string age;
        private string birthday;
        private string sex;
        private string address;
        private string phoneNum;

        public string UserIp { get => userIp; set => userIp = value; }
        public string UserAccount { get => userAccount; set => userAccount = value; }
     
        public string DisplayName { get => displayName; set => displayName = value; }
        public string PersonalSignature { get => personalSignature; set => personalSignature = value; }
        public string HeadPhotoPath { get => headPhotoPath; set => headPhotoPath = value; }
        public string UserPassWord { get => userPassWord; set => userPassWord = value; }
        public string Age { get => age; set => age = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }

        public UserData(string m_userIp,string m_userAccount,string m_userPassWord,string m_displayName,string m_personalSignature)
        {
            this.UserIp = m_userIp;
            this.UserAccount = m_userAccount;
            this.UserPassWord = m_userPassWord;
            this.displayName = m_displayName;
            this.personalSignature = m_personalSignature;
        }   
            
        public UserData()
        {
            this.UserIp = "1";
            this.UserAccount = "1";
            this.UserPassWord = "1";
            this.DisplayName = "1";
            this.PersonalSignature = "1";
            this.Age = "1";
            this.Birthday = "2000.01.01";
            this.Sex = "woman";
            this.Address = "china";
            this.PhoneNum = "7788";
        }

    }
}
