namespace Lab2
{
    partial class Bai5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.TextBox();
            this.outputFilePath = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.chooseBtn = new System.Windows.Forms.Button();
            this.compressBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(100, 34);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(302, 20);
            this.filePath.TabIndex = 2;
            // 
            // outputFilePath
            // 
            this.outputFilePath.Location = new System.Drawing.Point(100, 72);
            this.outputFilePath.Name = "outputFilePath";
            this.outputFilePath.ReadOnly = true;
            this.outputFilePath.Size = new System.Drawing.Size(302, 20);
            this.outputFilePath.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(100, 114);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(302, 23);
            this.progressBar.TabIndex = 4;
            // 
            // chooseBtn
            // 
            this.chooseBtn.Location = new System.Drawing.Point(408, 32);
            this.chooseBtn.Name = "chooseBtn";
            this.chooseBtn.Size = new System.Drawing.Size(118, 23);
            this.chooseBtn.TabIndex = 5;
            this.chooseBtn.Text = "...";
            this.chooseBtn.UseVisualStyleBackColor = true;
            this.chooseBtn.Click += new System.EventHandler(this.chooseBtn_Click);
            // 
            // compressBtn
            // 
            this.compressBtn.Location = new System.Drawing.Point(408, 70);
            this.compressBtn.Name = "compressBtn";
            this.compressBtn.Size = new System.Drawing.Size(118, 23);
            this.compressBtn.TabIndex = 6;
            this.compressBtn.Text = "Compress";
            this.compressBtn.UseVisualStyleBackColor = true;
            this.compressBtn.Click += new System.EventHandler(this.compressBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 168);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.compressBtn);
            this.Controls.Add(this.chooseBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.outputFilePath);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.TextBox outputFilePath;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button chooseBtn;
        private System.Windows.Forms.Button compressBtn;
        private System.Windows.Forms.Button button2;
    }
}