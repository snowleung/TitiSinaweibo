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
                oauth.RequestTokenGet();//������Ȩ
            }
            catch
            {
                //throw new Exception("����ʱʧ�ܣ���ȷ�������Ƿ���ͨ,error:110"); 
                MessageBox.Show("����ʱʧ�ܣ���ȷ�������Ƿ���ͨ,error:110");
                return;
            }

            string url = string.Empty;
            try { url = oauth.AuthorizationGet(); }
            catch
            {
                //throw new Exception("����ʱʧ�ܣ���ȷ�������Ƿ���ͨ,error:110"); 
                MessageBox.Show("����ʱʧ�ܣ���ȷ�������Ƿ���ͨ,error:110");
                return;
            }

            try
            {
                Process.Start(url);//����ҳ��
                //throw new Exception();
            }
            catch 
            {
                this.groupBox2.Visible = true;
                this.SinaAuthLink.Text = url;
                //throw new Exception("��ҳ��ʧ�ܣ��븴�����ӵ��������ַ�����Ա��ȡPIN��(��Ȩ��)��error:120");
                MessageBox.Show("��ҳ��ʧ�ܣ��븴�����ӵ�ַ���������ַ�����Ա��ȡPIN��(��Ȩ��)��error:120");
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
                MessageBox.Show("����ʧ�ܣ����ֹ����ơ�");
                return;
            }

            MessageBox.Show("�ɹ�����");
        }


    
    }
}