using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using SinaBusiness.SinaRequest;
using SinaBusiness;
using SinaBusiness.SinaResponse;
using SinaBusiness.Domain;
using System.IO;
using SinaBusiness.Tools;
using System.Net;

namespace FrmTiti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //filepath是文件路径，如果要上传文件要给这个赋值为文件路径
            InitializeComponent();

            this.linkLabel1.Click += new EventHandler(delegate(object o, EventArgs args) 
            {
                System.Diagnostics.Process.Start(this.linkLabel1.Text);
            });

            this.richtxtWeiboStatus.AllowDrop = true;
            this.richtxtWeiboStatus.DragEnter += new DragEventHandler(richtxtWeiboStatus_DragEnter);

            SinaBusiness.Config.SConfig sc = new SinaBusiness.Config.SConfig();
            this.Text = "账号:" + sc.UserName; 
            this.Height = 150;
            this.picBoxRequestLoading.Visible = false;
            this.picBoxSendLoading.Visible = false;
            IsVisibleSendWebboControl(false);

            this.richtxtWeiboStatus.TextChanged += new EventHandler(delegate(object o, EventArgs args) 
            {
                int onlyNum=140 - richtxtWeiboStatus.Text.Trim().Length;
                grpSendWeibo.Text="Only "+onlyNum.ToString();
                if (!isShow)
                {
                    if (!string.IsNullOrEmpty(richtxtWeiboStatus.Text.Trim()))
                    {
                        this.btnSendWeiBo.Visible = true;
                        this.button1.Visible = false;
                    }
                    else
                    {
                        this.btnSendWeiBo.Visible = false;
                        this.button1.Visible = true;
                    } 
                }
            });
            this.btnUploadPicture.Click += new EventHandler(btnUploadPicture_Click);
            this.btnPerv.Click += new EventHandler(btnPerv_Click);
            this.btnNext.Click += new EventHandler(btnNext_Click);
            this.pictureBox1.Click += new EventHandler(delegate(object o, EventArgs args)
            {
                if (this.pictureBox1.Image!=null)
                {
                    ShowPictureFromImageObject(this.pictureBox1.Image); 
                }
            });
            this.btnSendWeiBo.Click += new EventHandler(btnSendWeiBo_Click);
            bgSend = this.GetNewBackgroundWorkerObject();
            bgSend.DoWork += new DoWorkEventHandler(delegate(object o, DoWorkEventArgs args)
            {
                
                if (string.IsNullOrEmpty(FilePath))
                {
                    SendWeibo((string)args.Argument);
                }
                else
                {
                    SendWeibo((string)args.Argument, FilePath);
                }
            });
            bgSend.RunWorkerCompleted += new RunWorkerCompletedEventHandler(delegate(object o, RunWorkerCompletedEventArgs args) 
            {
                IsVisibleControl(this.picBoxSendLoading, false);
                this.lblSendWeiboTips.Text = "Finish!!!";
                this.pictureBox1.Image = null;
                this.FilePath = string.Empty;
                this.richtxtWeiboStatus.Text = "";
                this.btnSendWeiBo.Enabled = true ;
                this.btnUploadPicture.Enabled = true;
            });
            this.btnLoginout.Click += new EventHandler(btnLoginout_Click);

            bindEventPictureBox();
            bindLinkClickRichTextBox();
        }

        void alertBox(object m)
        {
            MessageBox.Show(m.ToString());
        }

        void richtxtWeiboStatus_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                FileInfo f = new FileInfo(((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString());
                string fileExt= f.Extension.ToLower();
                if (fileExt==".jpg"||fileExt==".gif"||fileExt==".png")
                {
                    if (checkPicLength(f))
                    {
                        alertBox("文件太大");
                    }
                    else
                    {
                        FilePath = f.FullName;
                        bindPictureBoxImageItem(f.FullName);
                    }
                }
                else
                {
                    alertBox("不是指定的图片文件，仅能上传图片(jpg,gif,png)");
                }
                
            }

        }


        void btnLoginout_Click(object sender, EventArgs e)
        {
            SinaBusiness.Config.SConfig s = new SinaBusiness.Config.SConfig();
            s.DoNotAutoLogin();
            this.Close();
        }

        private void ShowPictureFromImageObject(Image imageObject)
        {
            frmPictureShow f = new frmPictureShow(imageObject);
            f.ShowDialog();
        }

        void btnSendWeiBo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(GetStatus()))
            {
                IsVisibleControl(this.picBoxSendLoading, true);
                this.lblSendWeiboTips.Text = "Sending...";
                this.btnSendWeiBo.Enabled = false;
                this.btnUploadPicture.Enabled = false;
                bgSend.RunWorkerAsync(GetStatus());
            }
        }

        /// <summary>
        /// 获取status
        /// </summary>
        /// <returns></returns>
        private string GetStatus()
        {
            int maxStatusLength=140;
            string st = string.Empty;
            if (this.richtxtWeiboStatus.Text.Length<maxStatusLength)
            {
                st = this.richtxtWeiboStatus.Text;
            }
            else
            {
                st = this.richtxtWeiboStatus.Text.Substring(0, maxStatusLength) ;
            }
            return st;
        }

        void SendWeibo(string status) 
        {
            WBAccessUpdateRequest req = new WBAccessUpdateRequest();
            req.status = status;
            client.Excute(req);

        }
        void SendWeibo(string status, string filepath) 
        {
            WBAccessUploadRequest req = new WBAccessUploadRequest();
            req.status = status;
            req.pic = new FileItem(filepath);
            client.Excute(req);
        }

        /// <summary>
        /// 是否大于指定的图片大小
        /// </summary>
        /// <param name="fo"></param>
        /// <returns></returns>
        bool checkPicLength(FileInfo fo)
        { 
            long maxFileLength = 5242800;

            return fo.Length > maxFileLength;
        }
        /// <summary>
        /// /// 是否大于指定的图片大小
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns></returns>
        bool checkPicLength(string FilePath) 
        {

            return checkPicLength((new FileInfo(FilePath)));
        }

        void bindPictureBoxImageItem(string FilePath) 
        {
            this.pictureBox1.Image = Image.FromFile(FilePath);            
        }


        void btnUploadPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg文件|*.jpg|GIF文件|*.gif|PNG文件|*.png";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                this.FilePath = openFileDialog1.FileName;
                if (checkPicLength(FilePath))
                {
                    MessageBox.Show("上传的图片不能大于5M,请从新选择!");
                }
                else
                {
                    bindPictureBoxImageItem(FilePath);
                }
            }
            else
            {
                FilePath= string.Empty;
            }
        }

        #region 页面属性
        Timer tmrPageAnimation = null;
        Timer tmr = null;
        Timer tmr2 = null;
        string wbStatus = string.Empty;
        ISinaClient client = new SinaClient();
        string FilePath = string.Empty;
        BackgroundWorker AsyncWork;
        BackgroundWorker bgSend;
        BackgroundWorker GetNewBackgroundWorkerObject() 
        {
            return new BackgroundWorker();
        }

        #endregion

        void btnPerv_Click(object sender, EventArgs e)
        {
            pageindex -= 1;
            //GetOtherPage();
            BindData();
        }

        void btnNext_Click(object sender, EventArgs e)
        {
            pageindex += 1;

            BindData();

            //GetOtherPage();
        }

        private void GetOtherPage()
        {
            PlayPageAnimation();
        }

        /// <summary>
        /// 控制这个控件的展示属性
        /// </summary>
        /// <param name="isShow"></param>
        void IsVisibleSendWebboControl(bool isShow) 
        {
            if (isShow)
            {
                this.button1.Text = "收起";
            }
            else
            {
                this.button1.Text = "展开";
            }
            IsVisibleControl(this.btnGetNewWeibo, isShow);

            IsVisibleControl(this.btnPerv, isShow);
            IsVisibleControl(this.btnNext, isShow);
            IsVisibleControl(this.btnSendWeiBo, isShow);
        }

        void IsVisibleControl(Control ctrl, bool isShow)
        {
            ctrl.Visible = isShow;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!isShow)
            {
                
                BindData();
                ShowContentAnimation();
                IsVisibleSendWebboControl(!isShow);
            }
            else
            {
                HideContentAnimation();
                IsVisibleSendWebboControl(!isShow);
            }

        }


        List<SinaStatus> GetDataSource()
        {
            WBFriendtimelineRequest req = new WBFriendtimelineRequest();
            WBFriendtimelineResponse rsp = client.Excute(req);
            
            return rsp.Statuses;
        }

        /// <summary>
        /// 数据列表
        /// </summary>
        List<SinaStatus> ls = null;
        int pageindex = 1;
        private void BindData()
        {
            BindData(false);
        }
        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="isGetNewSource"></param>
        private void BindData(bool isGetNewSource)
        {

            if (pageindex>4)
            {
                pageindex = 4;
                return;
            }
            if (pageindex<1)
            {
                pageindex = 1;
                return;
            }
            if (isGetNewSource||ls==null)
            {
                this.groupBox1.Text = "  Now doing Request,please wait a monent...";
                IsVisibleControl(this.picBoxRequestLoading, true);
                AsyncWork = GetNewBackgroundWorkerObject();
                AsyncWork.DoWork += new DoWorkEventHandler(delegate(object o, DoWorkEventArgs args) 
                {
                    ls = GetDataSource();                 
                });
                AsyncWork.RunWorkerCompleted += new RunWorkerCompletedEventHandler(delegate(object o,RunWorkerCompletedEventArgs args) 
                {
                    IsVisibleControl(this.picBoxRequestLoading, false);
                    this.groupBox1.Text = "  Request completed!!!";
                    BindRichTextBox();
                });

                AsyncWork.RunWorkerAsync();
            }
            else
            {
                BindRichTextBox();
            }
        }

        private void BindRichTextBox()
        {
            int dataCount = ls.Count;
            int i = pageindex * 4 - 1;
            foreach (Control ctrl in this.groupBox1.Controls)
            {
                if (ctrl is RichTextBox)
                {
                    RichTextBox rch = ctrl as RichTextBox;
                    if (ls[i].user!=null)
                    {
                        ctrl.Text ="From:"+ ls[i].user._screen_name;
                    }
                    ctrl.Text += "\n" + ls[i].text; 
                    if (ls[i].retweeted_status != null)
                    {
                        ctrl.Text += "\n转发以下内容：\n" + ls[i].retweeted_status.text;
                        if (ls[i].retweeted_status._original_pic!=null)
                        {
                            ctrl.Text += "\n此条微博含有图片(点以下可看)\n" + ls[i].retweeted_status._original_pic;
                        }
                    }

                    if (ls[i]._original_pic!=null)
                    {
                        rch.AppendText("\n此条微博含有图片(点以下可看)\n" + ls[i]._original_pic);
                    }
                    
                  
                    i++;

                    continue;

                }
                //加载图片暂时无用
                //if (ctrl is PictureBox)
                //{
                //    PictureBox pic = ctrl as PictureBox;

                //    if (ls[i-1].retweeted_status != null)
                //    {
                //        if (ls[i - 1].retweeted_status._original_pic != null)
                //        {
                //            Image requestPictureTemp = null;
                //            bgGetPicture = this.GetNewBackgroundWorkerObject();
                //            bgGetPicture.DoWork += new DoWorkEventHandler(delegate(object o, DoWorkEventArgs args)
                //            {
                //                requestPictureTemp = Image.FromStream((new WebClient()).OpenRead(ls[i - 1].retweeted_status._original_pic));
                //            });
                //            bgGetPicture.RunWorkerCompleted += new RunWorkerCompletedEventHandler(delegate(object o, RunWorkerCompletedEventArgs args)
                //            {
                //                pic.Image = requestPictureTemp;
                //            });
                //            bgGetPicture.RunWorkerAsync();
                //        }
                //        else
                //        {
                //            pic.Image = null;
                //        }
                        
                //    }
                //}
            }
        }

        private void bindLinkClickRichTextBox()
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is RichTextBox)
                {
                    RichTextBox rch = ctr as RichTextBox;
                    rch.LinkClicked+=new LinkClickedEventHandler(delegate(object o, LinkClickedEventArgs args)
                       {

                           System.Diagnostics.Process.Start(args.LinkText); 
                       });
                }
            }
        }
        private void bindEventPictureBox()
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is PictureBox)
                {
                    ctr.Click += new EventHandler(delegate(object o, EventArgs args)
                       {
                           PictureBox p = o as PictureBox;
                           if (p.Image != null)
                           {
                               ShowPictureFromImageObject(p.Image);
                           }
                       });
                }
            }
        }

        static bool isShow = false;
        #region Animation
        /// <summary>
        /// 暂时无用
        /// </summary>
        private void PlayPageAnimation()
        {
            int maxHeight = this.richTextBox5.Location.Y - this.pnlHidden.Location.Y + 85;
            tmrPageAnimation = new Timer();
            tmrPageAnimation.Interval = 10;
            tmrPageAnimation.Tick += new EventHandler(delegate(object sender, EventArgs e)
            {
                this.pnlHidden.Height += 15;
                if (this.pnlHidden.Height >= maxHeight)
                {
                    this.pnlHidden.Height = maxHeight;
                    this.tmrPageAnimation.Stop();
                }
            });
            this.tmrPageAnimation.Start();
        }
        private void ShowContentAnimation()
        {
            tmr = new Timer();
            tmr.Interval = 10;
            tmr.Tick += new EventHandler(
            delegate(object sender,EventArgs e) 
            {
                this.Height += 15;
                if (this.Height > 555)
                {
                    isShow = true;
                    tmr.Stop();
                }
            });
            tmr.Start();
        }
        private void HideContentAnimation() 
        {
            tmr2 = new Timer();
            tmr2.Interval = 10;
            tmr2.Tick += new EventHandler(
            delegate(object sender, EventArgs e) 
            {

                this.Height -= 10;

                if (this.Height < 155)
                {
                    isShow = false;
                    tmr2.Stop();
                }            
            });
            tmr2.Start();
        }
        #endregion

        private void btnGetNewWeibo_Click(object sender, EventArgs e)
        {
            BindData(true);
        }

    }
}