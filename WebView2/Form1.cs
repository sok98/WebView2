using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebView2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            string script = string.Format("document.getElementById('getMsg').innerText = '{0}'", tbox_SendMsg.Text);
            webView2.CoreWebView2.ExecuteScriptAsync(script);
        }

        private void webView2_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            lbl_GetMsg.Text = e.TryGetWebMessageAsString();
        }
    }
}
