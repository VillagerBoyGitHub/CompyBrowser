using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompyBrowser
{
    public partial class CompyBrowser : Form
    {
        public CompyBrowser()
        {
            InitializeComponent();
        }

        private void URL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
                browser.Load(URL.Text);
        }
        ChromiumWebBrowser browser;

        private void CompyBrowser_Load(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser(URL.Text);
            browser.Dock = DockStyle.Fill;
            this.Browser.Controls.Add(browser);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            browser.Load(URL.Text);
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            browser.Load(URL.Text);
        }

        private void URL_Click(object sender, EventArgs e)
        {
            URL.Clear();
        }

        private void Forward_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {

        }
    }
}
