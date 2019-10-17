using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Automation
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDo_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Dillon's Laptop\AppData\Local\Programs\Microsoft VS Code\Code.exe");
            
            //Process.Start(@"C: \Users\Dillon's Laptop\AppData\Local\GitHubDesktop\GitHubDesktop.exe");
            try
            {
                Process.Start("chrome.exe", "www.youtube.com");
                Process.Start("chrome.exe", "www.github.com/dillonallen92/");
                Process.Start("chrome.exe", "https://www.messenger.com/t/wyndom.wescott");

            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString() + "blahh");
            }
            

        }
    }
}
