
namespace WebView2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.lbl_GetMsg = new System.Windows.Forms.Label();
            this.tbox_SendMsg = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            this.SuspendLayout();
            // 
            // webView2
            // 
            this.webView2.AllowExternalDrop = true;
            this.webView2.CreationProperties = null;
            this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2.Dock = System.Windows.Forms.DockStyle.Right;
            this.webView2.Location = new System.Drawing.Point(419, 0);
            this.webView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(495, 562);
            this.webView2.Source = new System.Uri("http://localhost:8088/Test.html", System.UriKind.Absolute);
            this.webView2.TabIndex = 0;
            this.webView2.ZoomFactor = 1D;
            this.webView2.WebMessageReceived += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs>(this.webView2_WebMessageReceived);
            // 
            // lbl_GetMsg
            // 
            this.lbl_GetMsg.Font = new System.Drawing.Font("굴림", 11F);
            this.lbl_GetMsg.Location = new System.Drawing.Point(14, 158);
            this.lbl_GetMsg.Name = "lbl_GetMsg";
            this.lbl_GetMsg.Size = new System.Drawing.Size(365, 88);
            this.lbl_GetMsg.TabIndex = 1;
            this.lbl_GetMsg.Text = "get message";
            // 
            // tbox_SendMsg
            // 
            this.tbox_SendMsg.Location = new System.Drawing.Point(14, 112);
            this.tbox_SendMsg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_SendMsg.Name = "tbox_SendMsg";
            this.tbox_SendMsg.Size = new System.Drawing.Size(283, 25);
            this.tbox_SendMsg.TabIndex = 2;
            // 
            // btn_Send
            // 
            this.btn_Send.AutoSize = true;
            this.btn_Send.Location = new System.Drawing.Point(304, 112);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(61, 28);
            this.btn_Send.TabIndex = 3;
            this.btn_Send.Text = "send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.tbox_SendMsg);
            this.Controls.Add(this.lbl_GetMsg);
            this.Controls.Add(this.webView2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private System.Windows.Forms.Label lbl_GetMsg;
        private System.Windows.Forms.TextBox tbox_SendMsg;
        private System.Windows.Forms.Button btn_Send;
    }
}

