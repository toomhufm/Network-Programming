namespace Server
{
    partial class Server
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
            this.messageBox = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.sendBox = new System.Windows.Forms.Button();
            this.listenBtn = new System.Windows.Forms.Button();
            this.serverPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(36, 49);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBox.Size = new System.Drawing.Size(570, 222);
            this.messageBox.TabIndex = 0;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(36, 293);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(463, 78);
            this.textBox.TabIndex = 1;
            // 
            // sendBox
            // 
            this.sendBox.Location = new System.Drawing.Point(506, 293);
            this.sendBox.Name = "sendBox";
            this.sendBox.Size = new System.Drawing.Size(100, 78);
            this.sendBox.TabIndex = 2;
            this.sendBox.Text = "Send Message";
            this.sendBox.UseVisualStyleBackColor = true;
            this.sendBox.Click += new System.EventHandler(this.sendBox_Click);
            // 
            // listenBtn
            // 
            this.listenBtn.Location = new System.Drawing.Point(233, 19);
            this.listenBtn.Name = "listenBtn";
            this.listenBtn.Size = new System.Drawing.Size(177, 20);
            this.listenBtn.TabIndex = 3;
            this.listenBtn.Text = "Listen";
            this.listenBtn.UseVisualStyleBackColor = true;
            this.listenBtn.Click += new System.EventHandler(this.listenBtn_Click);
            // 
            // serverPort
            // 
            this.serverPort.Location = new System.Drawing.Point(91, 19);
            this.serverPort.Name = "serverPort";
            this.serverPort.Size = new System.Drawing.Size(136, 20);
            this.serverPort.TabIndex = 4;
            this.serverPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(416, 19);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(190, 20);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Disconnect";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverPort);
            this.Controls.Add(this.listenBtn);
            this.Controls.Add(this.sendBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.messageBox);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button sendBox;
        private System.Windows.Forms.Button listenBtn;
        private System.Windows.Forms.TextBox serverPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtn;
    }
}

