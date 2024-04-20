using System;
using System.Windows.Forms;

namespace SeansTakipUygulamasi
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form1
    {
        public MainForm()
        {
            this.Text = "Seans Takip Uygulamasi";
            this.ClientSize = new System.Drawing.Size(800, 450);
        }
    }
}
