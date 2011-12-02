using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmTiti
{
    public partial class frmPictureShow : Form
    {
        public frmPictureShow()
        {
            InitializeComponent();
        }
        public frmPictureShow(Image img)
        {
            InitializeComponent();
            FormatForm(img);

        }

        void FormatForm(Image img)
        {
            this.pictureBox1.Image = img;
            this.Height = this.pictureBox1.Height;
            this.Width = this.pictureBox1.Width;            
        }
        
    }
}