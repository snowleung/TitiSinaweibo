namespace FrmTiti
{
    partial class frmLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GetAccessToken = new System.Windows.Forms.Button();
            this.AuthlinkgroupBox = new System.Windows.Forms.GroupBox();
            this.pinBox = new System.Windows.Forms.TextBox();
            this.SinaAuthLink = new System.Windows.Forms.TextBox();
            this.btnGetAutho = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCopyWebUrl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.AuthlinkgroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnGetAutho);
            this.groupBox1.Controls.Add(this.AuthlinkgroupBox);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 264);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "欢迎";
            // 
            // GetAccessToken
            // 
            this.GetAccessToken.Location = new System.Drawing.Point(486, 16);
            this.GetAccessToken.Name = "GetAccessToken";
            this.GetAccessToken.Size = new System.Drawing.Size(98, 23);
            this.GetAccessToken.TabIndex = 19;
            this.GetAccessToken.Text = "确定授权";
            this.GetAccessToken.UseVisualStyleBackColor = true;
            this.GetAccessToken.Click += new System.EventHandler(this.GetAccessToken_Click);
            // 
            // AuthlinkgroupBox
            // 
            this.AuthlinkgroupBox.Controls.Add(this.GetAccessToken);
            this.AuthlinkgroupBox.Controls.Add(this.pinBox);
            this.AuthlinkgroupBox.Location = new System.Drawing.Point(8, 195);
            this.AuthlinkgroupBox.Name = "AuthlinkgroupBox";
            this.AuthlinkgroupBox.Size = new System.Drawing.Size(646, 48);
            this.AuthlinkgroupBox.TabIndex = 22;
            this.AuthlinkgroupBox.TabStop = false;
            this.AuthlinkgroupBox.Text = "请填写授权码";
            // 
            // pinBox
            // 
            this.pinBox.Location = new System.Drawing.Point(15, 17);
            this.pinBox.Name = "pinBox";
            this.pinBox.Size = new System.Drawing.Size(441, 23);
            this.pinBox.TabIndex = 17;
            // 
            // SinaAuthLink
            // 
            this.SinaAuthLink.Location = new System.Drawing.Point(6, 22);
            this.SinaAuthLink.Name = "SinaAuthLink";
            this.SinaAuthLink.Size = new System.Drawing.Size(626, 23);
            this.SinaAuthLink.TabIndex = 15;
            // 
            // btnGetAutho
            // 
            this.btnGetAutho.Location = new System.Drawing.Point(227, 18);
            this.btnGetAutho.Name = "btnGetAutho";
            this.btnGetAutho.Size = new System.Drawing.Size(220, 88);
            this.btnGetAutho.TabIndex = 23;
            this.btnGetAutho.Text = "访问您的新浪围脖";
            this.btnGetAutho.UseVisualStyleBackColor = true;
            this.btnGetAutho.Click += new System.EventHandler(this.btnGetAutho_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCopyWebUrl);
            this.groupBox2.Controls.Add(this.SinaAuthLink);
            this.groupBox2.Location = new System.Drawing.Point(6, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 75);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "请复制下列网址到浏览器地址栏以获得授权码";
            // 
            // btnCopyWebUrl
            // 
            this.btnCopyWebUrl.Location = new System.Drawing.Point(6, 46);
            this.btnCopyWebUrl.Name = "btnCopyWebUrl";
            this.btnCopyWebUrl.Size = new System.Drawing.Size(98, 23);
            this.btnCopyWebUrl.TabIndex = 20;
            this.btnCopyWebUrl.Text = "复制";
            this.btnCopyWebUrl.UseVisualStyleBackColor = true;
            this.btnCopyWebUrl.Click += new System.EventHandler(this.btnCopyWebUrl_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 285);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.groupBox1.ResumeLayout(false);
            this.AuthlinkgroupBox.ResumeLayout(false);
            this.AuthlinkgroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GetAccessToken;
        private System.Windows.Forms.GroupBox AuthlinkgroupBox;
        private System.Windows.Forms.TextBox pinBox;
        private System.Windows.Forms.TextBox SinaAuthLink;
        private System.Windows.Forms.Button btnGetAutho;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCopyWebUrl;

    }
}