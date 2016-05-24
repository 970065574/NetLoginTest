using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetLoginTest
{
    public partial class Form1 : Form
    {
        HttpHelper MyHttpHelper;
        HttpItem MyHttpItem;
        HttpResult MyHttpResult;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox_Url.Text.Contains("http:"))
            {
                textBox_Url.Text += "http://" + textBox_Url.Text;
            }
            MyHttpItem.URL = textBox_Url.Text;
            MyHttpResult = MyHttpHelper.GetHtml(MyHttpItem);
            textBox_Headers.Text = MyHttpResult.Header.ToString();
            textBox_Contents.Text = MyHttpResult.Html;
            textBox_Cookies.Text = MyHttpResult.Cookie;
            textBox_Stream.Text = MyHttpResult.ResultByte.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyHttpHelper = new HttpHelper();
            MyHttpItem = new HttpItem();
            MyHttpResult = new HttpResult();
        }
    }
}
