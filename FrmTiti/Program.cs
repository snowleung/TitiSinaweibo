using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FrmTiti
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //if (new SinaBusiness.Config.SConfig().isAutoLogin())
            //{
            //    Application.Run(new Form1());
            //    Application.Exit();
            //}
            //else
            //{
            //    Form f = new frmLogin();
            //    f.Show();
            //    //Application.Run(new frmLogin());

            //    //Application.Restart();
            //}
            if (new SinaBusiness.Config.SConfig().isAutoLogin())
            {
                Application.Run(new Form1());
            }
            else
            {
                frmLogin f = new frmLogin();
                f.ShowDialog();
                if (frmLogin.flag)
                {
                    Application.Run(new Form1());
                }
            }


            Application.ExitThread();
        }
    }
}