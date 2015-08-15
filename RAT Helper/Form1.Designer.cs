namespace RAT_Helper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelGateWay = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPagePrtChk = new System.Windows.Forms.TabPage();
            this.panelPortCheck = new System.Windows.Forms.Panel();
            this.labelPortCheckResult = new System.Windows.Forms.Label();
            this.buttonCheckPort = new System.Windows.Forms.Button();
            this.numericUpDownPort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpgExtIp = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabelRefExIp = new System.Windows.Forms.LinkLabel();
            this.linkLabelCopyExIp = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEXIP = new System.Windows.Forms.Label();
            this.labelIp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabelHH = new System.Windows.Forms.LinkLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelGateWay.SuspendLayout();
            this.tabPagePrtChk.SuspendLayout();
            this.panelPortCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).BeginInit();
            this.tpgExtIp.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.linkLabelHH);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.labelIp);
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 451);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPagePrtChk);
            this.tabControl1.Controls.Add(this.tpgExtIp);
            this.tabControl1.Location = new System.Drawing.Point(12, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 381);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelGateWay);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(511, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Router ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelGateWay
            // 
            this.panelGateWay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGateWay.Controls.Add(this.webBrowser1);
            this.panelGateWay.Location = new System.Drawing.Point(3, 25);
            this.panelGateWay.Name = "panelGateWay";
            this.panelGateWay.Size = new System.Drawing.Size(505, 323);
            this.panelGateWay.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(505, 323);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabPagePrtChk
            // 
            this.tabPagePrtChk.Controls.Add(this.panelPortCheck);
            this.tabPagePrtChk.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrtChk.Name = "tabPagePrtChk";
            this.tabPagePrtChk.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrtChk.Size = new System.Drawing.Size(511, 350);
            this.tabPagePrtChk.TabIndex = 1;
            this.tabPagePrtChk.Text = "Port Check";
            this.tabPagePrtChk.UseVisualStyleBackColor = true;
            // 
            // panelPortCheck
            // 
            this.panelPortCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPortCheck.Controls.Add(this.labelPortCheckResult);
            this.panelPortCheck.Controls.Add(this.buttonCheckPort);
            this.panelPortCheck.Controls.Add(this.numericUpDownPort);
            this.panelPortCheck.Controls.Add(this.label3);
            this.panelPortCheck.Controls.Add(this.label2);
            this.panelPortCheck.Location = new System.Drawing.Point(0, 0);
            this.panelPortCheck.Name = "panelPortCheck";
            this.panelPortCheck.Size = new System.Drawing.Size(508, 344);
            this.panelPortCheck.TabIndex = 0;
            // 
            // labelPortCheckResult
            // 
            this.labelPortCheckResult.AutoSize = true;
            this.labelPortCheckResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortCheckResult.Location = new System.Drawing.Point(141, 144);
            this.labelPortCheckResult.Name = "labelPortCheckResult";
            this.labelPortCheckResult.Size = new System.Drawing.Size(38, 31);
            this.labelPortCheckResult.TabIndex = 5;
            this.labelPortCheckResult.Text = "...";
            this.labelPortCheckResult.TextChanged += new System.EventHandler(this.labelPortCheckResult_TextChanged);
            // 
            // buttonCheckPort
            // 
            this.buttonCheckPort.Location = new System.Drawing.Point(346, 87);
            this.buttonCheckPort.Name = "buttonCheckPort";
            this.buttonCheckPort.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckPort.TabIndex = 4;
            this.buttonCheckPort.Text = "Check";
            this.buttonCheckPort.UseVisualStyleBackColor = true;
            this.buttonCheckPort.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownPort
            // 
            this.numericUpDownPort.Location = new System.Drawing.Point(147, 87);
            this.numericUpDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPort.Name = "numericUpDownPort";
            this.numericUpDownPort.Size = new System.Drawing.Size(179, 20);
            this.numericUpDownPort.TabIndex = 3;
            this.numericUpDownPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Powered By Canyouseeme.org";
            // 
            // tpgExtIp
            // 
            this.tpgExtIp.Controls.Add(this.panel2);
            this.tpgExtIp.Location = new System.Drawing.Point(4, 22);
            this.tpgExtIp.Name = "tpgExtIp";
            this.tpgExtIp.Padding = new System.Windows.Forms.Padding(3);
            this.tpgExtIp.Size = new System.Drawing.Size(511, 355);
            this.tpgExtIp.TabIndex = 2;
            this.tpgExtIp.Text = "External Ip";
            this.tpgExtIp.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.linkLabelRefExIp);
            this.panel2.Controls.Add(this.linkLabelCopyExIp);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelEXIP);
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 349);
            this.panel2.TabIndex = 1;
            // 
            // linkLabelRefExIp
            // 
            this.linkLabelRefExIp.AutoSize = true;
            this.linkLabelRefExIp.Location = new System.Drawing.Point(196, 160);
            this.linkLabelRefExIp.Name = "linkLabelRefExIp";
            this.linkLabelRefExIp.Size = new System.Drawing.Size(44, 13);
            this.linkLabelRefExIp.TabIndex = 2;
            this.linkLabelRefExIp.TabStop = true;
            this.linkLabelRefExIp.Text = "Refresh";
            this.linkLabelRefExIp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRefExIp_LinkClicked);
            // 
            // linkLabelCopyExIp
            // 
            this.linkLabelCopyExIp.AutoSize = true;
            this.linkLabelCopyExIp.LinkColor = System.Drawing.Color.Olive;
            this.linkLabelCopyExIp.Location = new System.Drawing.Point(255, 160);
            this.linkLabelCopyExIp.Name = "linkLabelCopyExIp";
            this.linkLabelCopyExIp.Size = new System.Drawing.Size(31, 13);
            this.linkLabelCopyExIp.TabIndex = 1;
            this.linkLabelCopyExIp.TabStop = true;
            this.linkLabelCopyExIp.Text = "Copy";
            this.linkLabelCopyExIp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCopyExIp_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Powered By Canyouseeme.org";
            // 
            // labelEXIP
            // 
            this.labelEXIP.AutoSize = true;
            this.labelEXIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEXIP.Location = new System.Drawing.Point(102, 124);
            this.labelEXIP.Name = "labelEXIP";
            this.labelEXIP.Size = new System.Drawing.Size(38, 31);
            this.labelEXIP.TabIndex = 0;
            this.labelEXIP.Text = "...";
            this.labelEXIP.Click += new System.EventHandler(this.labelEXIP_Click);
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Location = new System.Drawing.Point(9, 12);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(45, 13);
            this.labelIp.TabIndex = 0;
            this.labelIp.Text = "Local Ip";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // linkLabelHH
            // 
            this.linkLabelHH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelHH.AutoSize = true;
            this.linkLabelHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.linkLabelHH.Location = new System.Drawing.Point(339, 424);
            this.linkLabelHH.Name = "linkLabelHH";
            this.linkLabelHH.Size = new System.Drawing.Size(178, 22);
            this.linkLabelHH.TabIndex = 4;
            this.linkLabelHH.TabStop = true;
            this.linkLabelHH.Text = "By Hack Hlack Team";
            this.linkLabelHH.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHH_LinkClicked);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 455);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RAT Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelGateWay.ResumeLayout(false);
            this.tabPagePrtChk.ResumeLayout(false);
            this.panelPortCheck.ResumeLayout(false);
            this.panelPortCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPort)).EndInit();
            this.tpgExtIp.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelGateWay;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPagePrtChk;
        private System.Windows.Forms.Panel panelPortCheck;
        private System.Windows.Forms.TabPage tpgExtIp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelEXIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelCopyExIp;
        private System.Windows.Forms.Button buttonCheckPort;
        private System.Windows.Forms.NumericUpDown numericUpDownPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPortCheckResult;
        private System.Windows.Forms.LinkLabel linkLabelRefExIp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabelHH;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

