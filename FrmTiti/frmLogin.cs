using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SinaBusiness.Config;
using SinaBusiness.SinaRequest;
using SinaBusiness;
using SinaBusiness.SinaResponse;
using System.Diagnostics;
using System.IO;

namespace FrmTiti
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.groupBox2.Visible = false;
        }
        public static bool flag = false;
        oAuthSina oauth = new oAuthSina();

        private void GetAccessToken_Click(object sender, EventArgs e)
        {
            oauth.Verifier = this.pinBox.Text.Trim(); 
            oauth.AccessTokenGet();
            SConfig s = new SConfig();
            s.SetConfig(oauth.token, oauth.tokenSecret, "1");
            flag = true;
            this.Close();
        }

        private void btnGetAutho_Click(object sender, EventArgs e)
        {
            try
            {
                oauth.RequestTokenGet();//请求授权
            }
            catch
            {
                //throw new Exception("请求时失败，请确认网络是否连通,error:110"); 
                MessageBox.Show("请求时失败，请确认网络是否连通,error:110");
                return;
            }

            string url = string.Empty;
            try { url = oauth.AuthorizationGet(); }
            catch
            {
                //throw new Exception("请求时失败，请确认网络是否连通,error:110"); 
                MessageBox.Show("请求时失败，请确认网络是否连通,error:110");
                return;
            }

            try
            {
                Process.Start(url);//请求页面
                //throw new Exception();
            }
            catch 
            {
                this.groupBox2.Visible = true;
                this.SinaAuthLink.Text = url;
                //throw new Exception("打开页面失败，请复制连接到浏览器地址栏，以便获取PIN码(授权码)，error:120");
                MessageBox.Show("打开页面失败，请复制连接地址到浏览器地址栏，以便获取PIN码(授权码)，error:120");
                return;
            }
       

        }

        private void btnCopyWebUrl_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(this.SinaAuthLink.Text);
            }
            catch 
            {
                MessageBox.Show("复制失败，请手工复制。");
                return;
            }

            MessageBox.Show("成功复制");
        }


    
    }
}