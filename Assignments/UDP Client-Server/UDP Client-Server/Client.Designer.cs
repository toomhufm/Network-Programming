namespace UDP_Client_Server
{
    partial class Client
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
            this.sendBox = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.serverPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.clientPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serverIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendBox
            // 
            this.sendBox.Location = new System.Drawing.Point(495, 333);
            this.sendBox.Name = "sendBox";
            this.sendBox.Size = new System.Drawing.Size(100, 78);
            this.sendBox.TabIndex = 5;
            this.sendBox.Text = "Send Message";
            this.sendBox.UseVisualStyleBackColor = true;
            this.sendBox.Click += new System.EventHandler(this.sendBox_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(25, 333);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(463, 78);
            this.textBox.TabIndex = 4;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(25, 115);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBox.Size = new System.Drawing.Size(570, 196);
            this.messageBox.TabIndex = 3;
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(89, 63);
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(203, 20);
            this.serverPort.TabIndex = 6;
            this.serverPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server Port";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(307, 37);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(140, 72);
            this.connectBtn.TabIndex = 8;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // clientPort
            // 
            this.clientPort.Location = new System.Drawing.Point(89, 37);
            this.clientPort.Name = "clientPort";
            this.clientPort.Size = new System.Drawing.Size(203, 20);
            this.clientPort.TabIndex = 9;
            this.clientPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Client Port";
            // 
            // serverIP
            // 
            this.serverIP.Location = new System.Drawing.Point(89, 89);
            this.serverIP.Name = "serverIP";
            this.serverIP.Size = new System.Drawing.Size(203, 20);
            this.serverIP.TabIndex = 11;
            this.serverIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Server IP";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(453, 36);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(142, 72);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Disconnect";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serverIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientPort);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverPort);
            this.Controls.Add(this.sendBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.messageBox);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.TextBox serverPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox clientPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitBtn;
    }
}

