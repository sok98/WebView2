using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            Init_webview2();
        }

        // fixed버전 경로 설정
        async private void Init_webview2()
        {
            string currentPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            webView2.CreationProperties = new Microsoft.Web.WebView2.WinForms.CoreWebView2CreationProperties
            {
                //BrowserExecutableFolder = currentPath + @"\WebView2_Runtime\Microsoft.WebView2.FixedVersionRuntime.103.0.1264.62.x64"
                BrowserExecutableFolder = @"C:\WebView2_Runtime\Microsoft.WebView2.FixedVersionRuntime.103.0.1264.62.x64"
            };
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            await webView2.EnsureCoreWebView2Async();
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
