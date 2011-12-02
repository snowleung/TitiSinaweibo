using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SinaBusiness.Config
{
    public class SConfig
    {
        readonly string xmlConfigPath;
        public SConfig()
        {
            xmlConfigPath = System.Windows.Forms.Application.StartupPath + "\\titiconfig.xml"; 
            InitConfig();
        }
        public SConfig(string configPath) 
        {
            xmlConfigPath = configPath;
            InitConfig();
        }

        string userName;

        public string UserName
        {
            get
            {

                return userName;
                 
            }
            set { userName = value; }
        }

        string password;

        public string Password
        {
            get {

                return this.password;

            }
            set { password = value; }
        }

        string usingConfig;

        public string UsingConfig
        {
            get { return usingConfig; }
            set { usingConfig = value; }
        }

        public bool isAutoLogin()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlConfigPath);

            XmlNode xnroot = doc.SelectSingleNode("titiapplication");

            return xnroot.SelectSingleNode("usingConfig").InnerText == "1";

        }

        public void DoNotAutoLogin()
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(xmlConfigPath);

            XmlNode xnroot = doc.SelectSingleNode("titiapplication");

            xnroot.SelectSingleNode("usingConfig").InnerText = "0";
            doc.Save(xmlConfigPath);
        }
        void InitConfig() 
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlConfigPath);

            XmlNode xnroot = doc.SelectSingleNode("titiapplication");

            if (xnroot.SelectSingleNode("usingConfig").InnerText=="0")//不使用配置文件
            {
                this.password = "";
                this.userName = "";
            }
            else
            {
                //this.userName = ENC.enp(xnroot.SelectSingleNode("username").InnerText, 7);
                //this.password = ENC.enp(xnroot.SelectSingleNode("password").InnerText, 7);
                this.userName = xnroot.SelectSingleNode("username").InnerText;
                this.password = xnroot.SelectSingleNode("password").InnerText;
            }
        }

        public bool SetConfig(string user,string pass,string usingConfig)
        {
            //string u =ENC.enc( user,7);
            //string p = ENC.enc(pass, 7);

            string u = user;
            string p = pass;
            bool isSuccess = false;
            try
            {

                XmlDocument doc = new XmlDocument();
                doc.Load(xmlConfigPath);

                XmlNode xnroot = doc.SelectSingleNode("titiapplication");
                xnroot.SelectSingleNode("usingConfig").InnerText = usingConfig;
                xnroot.SelectSingleNode("username").InnerText = u;
                xnroot.SelectSingleNode("password").InnerText = p;
                doc.Save(xmlConfigPath);
                isSuccess = true;
            }
            catch (Exception ex)
            {
                throw;
            }

            return isSuccess;
        }


    }
}
