using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace RAT_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void SetExIp()
        {
            try
            {
                var req = (HttpWebRequest)WebRequest.Create("http://canyouseeme.org");
                var resp = (HttpWebResponse)req.GetResponse();

                string x = new StreamReader(resp.GetResponseStream()).ReadToEnd();
                //  input type="hidden" name="IP" value="41.238.175.7"/>
                string[] sepd = x.Split(new char[] { '<' });
                foreach (string s in sepd)
                    if (s.Contains("input type=\"hidden\" name=\"IP\""))
                    {
                        string[] spdbyspace = s.Split(new char[] { ' ' });
                        foreach (string sen in spdbyspace)
                            if (sen.Contains("value"))
                            {
                                string[] spd_by_qoute = sen.Split(new char[] { '"' });
                                this.CurrentExIp = spd_by_qoute[1];
                                labelEXIP.Text = "Your IP:" + this.CurrentExIp;

                                this.ExIpDetetected = true;
                                return;
                            }
                    }
            }
            catch {
                labelEXIP.Text = "..";
            
            }
        }

        private void SetLocalIp()
        {
           labelIp.Text = "Local Ip :"+    RATHELPER.GetLOCIp();
             
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedIndex)
            {
                case 0: webBrowser1.Navigate("http://192.168.1.1");
                    break;
                case 2: if (this.ExIpDetetected == false)
                        SetExIp();
                    break;
            }
        }

        private void labelEXIP_Click(object sender, EventArgs e)
        {

        }

        public string CurrentExIp { get; set; }

        private void linkLabelCopyExIp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.CurrentExIp != null)
                Clipboard.SetText(this.CurrentExIp);
        }

        public bool ExIpDetetected =false;

        private void button1_Click(object sender, EventArgs e)
        {
            string ip = this.CurrentExIp;
            string port = numericUpDownPort.Value.ToString();
            string url = "http://canyouseeme.org";

            var request = (HttpWebRequest)WebRequest.Create(url);


            var postData = "port="+port;
            postData += "&IP="+ip;
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            request.Referer = "http://canyouseeme.org/";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:39.0)";
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            
            string [] spd = responseString.Split(new string[]{"<p"},StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in spd)
                if (s.Contains("style=\"padding-left:15px\">"))
                {
                    if(s.Contains("<form"))
                    {
                        string[] xx = s.Split(new string[] { "<form" }, StringSplitOptions.RemoveEmptyEntries);
                        labelPortCheckResult.Text = AnalyzPortOpenResult(xx[0]);
                    }
                    else
                    labelPortCheckResult.Text = s;
                    break;
                }
        }

        private string AnalyzPortOpenResult(string p)
        {
            if (p.Contains("Error"))
                return "failed";
            else if (p.Contains("uccess"))
                return "Success";
            else
                return "Error";
        }

        private void linkLabelRefExIp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetExIp();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ticks++;
            if(this.Ticks==10)
            {
                timer1.Stop();

                SetLocalIp();
                SetExIp();
            }
        }

        public int Ticks { get; set; }

        private void labelPortCheckResult_TextChanged(object sender, EventArgs e)
        { 
                labelPortCheckResult.ForeColor =labelPortCheckResult.Text.Contains("Success")? Color.Green:Color.Red;

        }

        private void linkLabelHH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/hAck.hLAk");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Minimize to Tray App";
            notifyIcon1.BalloonTipText = "Im Here "+Environment.UserName;

            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
