namespace NetLoginTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Url = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Usr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Pwd = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TabPage_Info = new System.Windows.Forms.TabControl();
            this.tabPage_Header = new System.Windows.Forms.TabPage();
            this.textBox_Headers = new System.Windows.Forms.TextBox();
            this.tabPage_Cookie = new System.Windows.Forms.TabPage();
            this.textBox_Cookies = new System.Windows.Forms.TextBox();
            this.tabPage_Content = new System.Windows.Forms.TabPage();
            this.textBox_Contents = new System.Windows.Forms.TextBox();
            this.tabPage_Stream = new System.Windows.Forms.TabPage();
            this.textBox_Stream = new System.Windows.Forms.TextBox();
            this.listBox_UrlList = new System.Windows.Forms.ListBox();
            this.TabPage_Info.SuspendLayout();
            this.tabPage_Header.SuspendLayout();
            this.tabPage_Cookie.SuspendLayout();
            this.tabPage_Content.SuspendLayout();
            this.tabPage_Stream.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url：";
            // 
            // textBox_Url
            // 
            this.textBox_Url.Location = new System.Drawing.Point(38, 6);
            this.textBox_Url.Name = "textBox_Url";
            this.textBox_Url.Size = new System.Drawing.Size(285, 21);
            this.textBox_Url.TabIndex = 1;
            this.textBox_Url.Text = "http://www.sytebet.com";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "UserName:";
            // 
            // textBox_Usr
            // 
            this.textBox_Usr.Location = new System.Drawing.Point(77, 33);
            this.textBox_Usr.Name = "textBox_Usr";
            this.textBox_Usr.Size = new System.Drawing.Size(163, 21);
            this.textBox_Usr.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "PassWord:";
            // 
            // textBox_Pwd
            // 
            this.textBox_Pwd.Location = new System.Drawing.Point(77, 60);
            this.textBox_Pwd.Name = "textBox_Pwd";
            this.textBox_Pwd.Size = new System.Drawing.Size(163, 21);
            this.textBox_Pwd.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "LogIn";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TabPage_Info
            // 
            this.TabPage_Info.Controls.Add(this.tabPage_Header);
            this.TabPage_Info.Controls.Add(this.tabPage_Cookie);
            this.TabPage_Info.Controls.Add(this.tabPage_Content);
            this.TabPage_Info.Controls.Add(this.tabPage_Stream);
            this.TabPage_Info.Location = new System.Drawing.Point(14, 89);
            this.TabPage_Info.Name = "TabPage_Info";
            this.TabPage_Info.SelectedIndex = 0;
            this.TabPage_Info.Size = new System.Drawing.Size(605, 456);
            this.TabPage_Info.TabIndex = 8;
            // 
            // tabPage_Header
            // 
            this.tabPage_Header.Controls.Add(this.listBox_UrlList);
            this.tabPage_Header.Controls.Add(this.textBox_Headers);
            this.tabPage_Header.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Header.Name = "tabPage_Header";
            this.tabPage_Header.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Header.Size = new System.Drawing.Size(597, 430);
            this.tabPage_Header.TabIndex = 0;
            this.tabPage_Header.Text = "Headers";
            this.tabPage_Header.UseVisualStyleBackColor = true;
            // 
            // textBox_Headers
            // 
            this.textBox_Headers.Location = new System.Drawing.Point(275, 9);
            this.textBox_Headers.Multiline = true;
            this.textBox_Headers.Name = "textBox_Headers";
            this.textBox_Headers.Size = new System.Drawing.Size(316, 418);
            this.textBox_Headers.TabIndex = 0;
            // 
            // tabPage_Cookie
            // 
            this.tabPage_Cookie.Controls.Add(this.textBox_Cookies);
            this.tabPage_Cookie.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Cookie.Name = "tabPage_Cookie";
            this.tabPage_Cookie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Cookie.Size = new System.Drawing.Size(382, 430);
            this.tabPage_Cookie.TabIndex = 1;
            this.tabPage_Cookie.Text = "Cookies";
            this.tabPage_Cookie.UseVisualStyleBackColor = true;
            // 
            // textBox_Cookies
            // 
            this.textBox_Cookies.Location = new System.Drawing.Point(6, 6);
            this.textBox_Cookies.Multiline = true;
            this.textBox_Cookies.Name = "textBox_Cookies";
            this.textBox_Cookies.Size = new System.Drawing.Size(370, 418);
            this.textBox_Cookies.TabIndex = 0;
            // 
            // tabPage_Content
            // 
            this.tabPage_Content.Controls.Add(this.textBox_Contents);
            this.tabPage_Content.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Content.Name = "tabPage_Content";
            this.tabPage_Content.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Content.Size = new System.Drawing.Size(382, 430);
            this.tabPage_Content.TabIndex = 2;
            this.tabPage_Content.Text = "Content";
            this.tabPage_Content.UseVisualStyleBackColor = true;
            // 
            // textBox_Contents
            // 
            this.textBox_Contents.Location = new System.Drawing.Point(6, 6);
            this.textBox_Contents.Multiline = true;
            this.textBox_Contents.Name = "textBox_Contents";
            this.textBox_Contents.Size = new System.Drawing.Size(370, 418);
            this.textBox_Contents.TabIndex = 0;
            // 
            // tabPage_Stream
            // 
            this.tabPage_Stream.Controls.Add(this.textBox_Stream);
            this.tabPage_Stream.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Stream.Name = "tabPage_Stream";
            this.tabPage_Stream.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Stream.Size = new System.Drawing.Size(382, 430);
            this.tabPage_Stream.TabIndex = 3;
            this.tabPage_Stream.Text = "Stream";
            this.tabPage_Stream.UseVisualStyleBackColor = true;
            // 
            // textBox_Stream
            // 
            this.textBox_Stream.Location = new System.Drawing.Point(6, 6);
            this.textBox_Stream.Multiline = true;
            this.textBox_Stream.Name = "textBox_Stream";
            this.textBox_Stream.Size = new System.Drawing.Size(370, 546);
            this.textBox_Stream.TabIndex = 0;
            // 
            // listBox_UrlList
            // 
            this.listBox_UrlList.FormattingEnabled = true;
            this.listBox_UrlList.ItemHeight = 12;
            this.listBox_UrlList.Location = new System.Drawing.Point(6, 9);
            this.listBox_UrlList.Name = "listBox_UrlList";
            this.listBox_UrlList.Size = new System.Drawing.Size(253, 412);
            this.listBox_UrlList.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 554);
            this.Controls.Add(this.TabPage_Info);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_Pwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Usr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Url);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabPage_Info.ResumeLayout(false);
            this.tabPage_Header.ResumeLayout(false);
            this.tabPage_Header.PerformLayout();
            this.tabPage_Cookie.ResumeLayout(false);
            this.tabPage_Cookie.PerformLayout();
            this.tabPage_Content.ResumeLayout(false);
            this.tabPage_Content.PerformLayout();
            this.tabPage_Stream.ResumeLayout(false);
            this.tabPage_Stream.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Url;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Usr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Pwd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl TabPage_Info;
        private System.Windows.Forms.TabPage tabPage_Header;
        private System.Windows.Forms.TabPage tabPage_Cookie;
        private System.Windows.Forms.TabPage tabPage_Content;
        private System.Windows.Forms.TabPage tabPage_Stream;
        private System.Windows.Forms.TextBox textBox_Headers;
        private System.Windows.Forms.TextBox textBox_Contents;
        private System.Windows.Forms.TextBox textBox_Stream;
        private System.Windows.Forms.TextBox textBox_Cookies;
        private System.Windows.Forms.ListBox listBox_UrlList;
    }
}

