namespace FrmTiti
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.btnPerv = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlHidden = new System.Windows.Forms.Panel();
            this.btnSendWeiBo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnGetNewWeibo = new System.Windows.Forms.Button();
            this.btnUploadPicture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxRequestLoading = new System.Windows.Forms.PictureBox();
            this.picBoxSendLoading = new System.Windows.Forms.PictureBox();
            this.lblSendWeiboTips = new System.Windows.Forms.Label();
            this.grpSendWeibo = new System.Windows.Forms.GroupBox();
            this.richtxtWeiboStatus = new System.Windows.Forms.RichTextBox();
            this.btnLoginout = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRequestLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSendLoading)).BeginInit();
            this.grpSendWeibo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(443, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "收起";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(0, 14);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(450, 70);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(0, 104);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(450, 70);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(0, 195);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(450, 70);
            this.richTextBox4.TabIndex = 1;
            this.richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(0, 286);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(450, 70);
            this.richTextBox5.TabIndex = 1;
            this.richTextBox5.Text = "";
            // 
            // btnPerv
            // 
            this.btnPerv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPerv.Location = new System.Drawing.Point(12, 497);
            this.btnPerv.Name = "btnPerv";
            this.btnPerv.Size = new System.Drawing.Size(75, 23);
            this.btnPerv.TabIndex = 3;
            this.btnPerv.Text = "上一页";
            this.btnPerv.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.Location = new System.Drawing.Point(93, 497);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "下一页";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // pnlHidden
            // 
            this.pnlHidden.Location = new System.Drawing.Point(0, 14);
            this.pnlHidden.Name = "pnlHidden";
            this.pnlHidden.Size = new System.Drawing.Size(450, 10);
            this.pnlHidden.TabIndex = 5;
            // 
            // btnSendWeiBo
            // 
            this.btnSendWeiBo.Location = new System.Drawing.Point(387, 97);
            this.btnSendWeiBo.Name = "btnSendWeiBo";
            this.btnSendWeiBo.Size = new System.Drawing.Size(75, 23);
            this.btnSendWeiBo.TabIndex = 6;
            this.btnSendWeiBo.Text = "发一条";
            this.btnSendWeiBo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.richTextBox3);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.richTextBox4);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.richTextBox5);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pnlHidden);
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 375);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  groupBox1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = global::FrmTiti.Properties.Resources.loading2;
            this.pictureBox2.Location = new System.Drawing.Point(5, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.InitialImage = global::FrmTiti.Properties.Resources.loading2;
            this.pictureBox3.Location = new System.Drawing.Point(5, 176);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.InitialImage = global::FrmTiti.Properties.Resources.loading2;
            this.pictureBox4.Location = new System.Drawing.Point(5, 268);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.InitialImage = global::FrmTiti.Properties.Resources.loading2;
            this.pictureBox5.Location = new System.Drawing.Point(5, 356);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 16);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // btnGetNewWeibo
            // 
            this.btnGetNewWeibo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGetNewWeibo.Location = new System.Drawing.Point(398, 497);
            this.btnGetNewWeibo.Name = "btnGetNewWeibo";
            this.btnGetNewWeibo.Size = new System.Drawing.Size(39, 23);
            this.btnGetNewWeibo.TabIndex = 8;
            this.btnGetNewWeibo.Text = "更新";
            this.btnGetNewWeibo.UseVisualStyleBackColor = true;
            this.btnGetNewWeibo.Click += new System.EventHandler(this.btnGetNewWeibo_Click);
            // 
            // btnUploadPicture
            // 
            this.btnUploadPicture.Location = new System.Drawing.Point(306, 97);
            this.btnUploadPicture.Name = "btnUploadPicture";
            this.btnUploadPicture.Size = new System.Drawing.Size(75, 23);
            this.btnUploadPicture.TabIndex = 10;
            this.btnUploadPicture.Text = "图片";
            this.btnUploadPicture.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = global::FrmTiti.Properties.Resources.loading2;
            this.pictureBox1.Location = new System.Drawing.Point(276, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // picBoxRequestLoading
            // 
            this.picBoxRequestLoading.Image = global::FrmTiti.Properties.Resources.loading2;
            this.picBoxRequestLoading.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxRequestLoading.InitialImage")));
            this.picBoxRequestLoading.Location = new System.Drawing.Point(13, 115);
            this.picBoxRequestLoading.Name = "picBoxRequestLoading";
            this.picBoxRequestLoading.Size = new System.Drawing.Size(16, 16);
            this.picBoxRequestLoading.TabIndex = 9;
            this.picBoxRequestLoading.TabStop = false;
            // 
            // picBoxSendLoading
            // 
            this.picBoxSendLoading.Image = global::FrmTiti.Properties.Resources.loading2;
            this.picBoxSendLoading.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxSendLoading.InitialImage")));
            this.picBoxSendLoading.Location = new System.Drawing.Point(13, 98);
            this.picBoxSendLoading.Name = "picBoxSendLoading";
            this.picBoxSendLoading.Size = new System.Drawing.Size(16, 16);
            this.picBoxSendLoading.TabIndex = 9;
            this.picBoxSendLoading.TabStop = false;
            // 
            // lblSendWeiboTips
            // 
            this.lblSendWeiboTips.AutoSize = true;
            this.lblSendWeiboTips.Location = new System.Drawing.Point(30, 101);
            this.lblSendWeiboTips.Name = "lblSendWeiboTips";
            this.lblSendWeiboTips.Size = new System.Drawing.Size(0, 12);
            this.lblSendWeiboTips.TabIndex = 12;
            // 
            // grpSendWeibo
            // 
            this.grpSendWeibo.Controls.Add(this.richtxtWeiboStatus);
            this.grpSendWeibo.Location = new System.Drawing.Point(2, 2);
            this.grpSendWeibo.Name = "grpSendWeibo";
            this.grpSendWeibo.Size = new System.Drawing.Size(468, 100);
            this.grpSendWeibo.TabIndex = 13;
            this.grpSendWeibo.TabStop = false;
            this.grpSendWeibo.Text = "groupBox2";
            // 
            // richtxtWeiboStatus
            // 
            this.richtxtWeiboStatus.Location = new System.Drawing.Point(8, 12);
            this.richtxtWeiboStatus.Name = "richtxtWeiboStatus";
            this.richtxtWeiboStatus.Size = new System.Drawing.Size(450, 85);
            this.richtxtWeiboStatus.TabIndex = 2;
            this.richtxtWeiboStatus.Text = "";
            // 
            // btnLoginout
            // 
            this.btnLoginout.Location = new System.Drawing.Point(348, 496);
            this.btnLoginout.Name = "btnLoginout";
            this.btnLoginout.Size = new System.Drawing.Size(44, 23);
            this.btnLoginout.TabIndex = 14;
            this.btnLoginout.Text = "注销并关闭";
            this.btnLoginout.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(175, 507);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(167, 12);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://t.sina.com/snowleung";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 522);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnLoginout);
            this.Controls.Add(this.lblSendWeiboTips);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUploadPicture);
            this.Controls.Add(this.picBoxRequestLoading);
            this.Controls.Add(this.picBoxSendLoading);
            this.Controls.Add(this.btnGetNewWeibo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSendWeiBo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPerv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpSendWeibo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRequestLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSendLoading)).EndInit();
            this.grpSendWeibo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Button btnPerv;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnlHidden;
        private System.Windows.Forms.Button btnSendWeiBo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetNewWeibo;
        private System.Windows.Forms.PictureBox picBoxSendLoading;
        private System.Windows.Forms.PictureBox picBoxRequestLoading;
        private System.Windows.Forms.Button btnUploadPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSendWeiboTips;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grpSendWeibo;
        private System.Windows.Forms.RichTextBox richtxtWeiboStatus;
        private System.Windows.Forms.Button btnLoginout;
        private System.Windows.Forms.LinkLabel linkLabel1;


    }
}

