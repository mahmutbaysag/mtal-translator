using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using System.IO;


namespace tr2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            
            InitializeComponent();
            this.webBrowser1.ScriptErrorsSuppressed = true;

            metroRadioButton3.Enabled = false;
            metroRadioButton4.Enabled = false;
            metroRadioButton4.Visible = false;
            metroRadioButton3.Visible = false;

            if(metroRadioButton5.Checked==true)
            {
                webBrowser1.Navigate("https://ceviri.yandex.com.tr/?lang=en-tr");
                
            }
            else if (metroRadioButton6.Checked==true)
            {
                webBrowser1.Navigate("https://ceviri.yandex.com.tr/?lang=tr-en");
                
            }

            if (metroRadioButton1.Checked == true)
            {
                light();
            }
            if (metroRadioButton2.Checked == true)
            {
                dark();
            }

        }

        public void light()
        {
            this.Theme = MetroThemeStyle.Light;
            metroButton1.Theme= MetroThemeStyle.Light;
            metroButton2.Theme= MetroThemeStyle.Light;
            metroButton3.Theme= MetroThemeStyle.Light;
            metroButton4.Theme= MetroThemeStyle.Light;
            metroTextBox1.Theme= MetroThemeStyle.Light;
            metroTextBox2.Theme= MetroThemeStyle.Light;
            metroPanel1.Theme= MetroThemeStyle.Light;
            metroRadioButton1.Theme= MetroThemeStyle.Light;
            metroRadioButton2.Theme= MetroThemeStyle.Light;
        }

        public void dark()
        {
            this.Theme = MetroThemeStyle.Dark;
            metroButton1.Theme = MetroThemeStyle.Dark;
            metroButton2.Theme = MetroThemeStyle.Dark;
            metroButton3.Theme = MetroThemeStyle.Dark;
            metroButton4.Theme = MetroThemeStyle.Dark;
            metroTextBox1.Theme = MetroThemeStyle.Dark;
            metroTextBox2.Theme = MetroThemeStyle.Dark;
            metroPanel1.Theme = MetroThemeStyle.Dark;
            metroRadioButton1.Theme = MetroThemeStyle.Dark;
            metroRadioButton2.Theme = MetroThemeStyle.Dark;
        }
     
        private void MetroTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.webBrowser1.ScriptErrorsSuppressed = true;
            metroTextBox1.Focus();
        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {

        }


        private void MetroButton3_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = Clipboard.GetText();
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(metroTextBox2.Text);
        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = "";
            metroTextBox2.Text = "";
            if (metroRadioButton5.Checked == true)
            {
                webBrowser1.Navigate("https://ceviri.yandex.com.tr/?lang=en-tr");

            }
            else if (metroRadioButton6.Checked == true)
            {
                webBrowser1.Navigate("https://ceviri.yandex.com.tr/?lang=tr-en");

            }
        }
        int sayac = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            webBrowser1.Document.GetElementById("textarea").InnerText = metroTextBox1.Text;
            this.webBrowser1.ScriptErrorsSuppressed = true;
            if (sayac == 2)
            {
                metroTextBox2.Text = webBrowser1.Document.GetElementById("translation").InnerText;
                this.webBrowser1.ScriptErrorsSuppressed = true;
                sayac = 0;
                timer1.Stop();
            }
            
        }

        private void MetroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Theme = MetroThemeStyle.Light;
            metroButton1.Theme = MetroThemeStyle.Light;
            metroButton2.Theme = MetroThemeStyle.Light;
            metroButton3.Theme = MetroThemeStyle.Light;
            metroButton4.Theme = MetroThemeStyle.Light;
            metroTextBox1.Theme = MetroThemeStyle.Light;
            metroTextBox2.Theme = MetroThemeStyle.Light;
            metroPanel1.Theme = MetroThemeStyle.Light;
            metroRadioButton1.Theme = MetroThemeStyle.Light;
            metroRadioButton2.Theme = MetroThemeStyle.Light;
        }

        private void MetroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.Theme = MetroThemeStyle.Dark;
            metroButton1.Theme = MetroThemeStyle.Dark;
            metroButton2.Theme = MetroThemeStyle.Dark;
            metroButton3.Theme = MetroThemeStyle.Dark;
            metroButton4.Theme = MetroThemeStyle.Dark;
            metroTextBox1.Theme = MetroThemeStyle.Dark;
            metroTextBox2.Theme = MetroThemeStyle.Dark;
            metroPanel1.Theme = MetroThemeStyle.Dark;
            metroRadioButton1.Theme = MetroThemeStyle.Dark;
            metroRadioButton2.Theme = MetroThemeStyle.Dark;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }
    }
}
