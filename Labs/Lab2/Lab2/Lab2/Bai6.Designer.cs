namespace Lab2
{
    partial class Bai6
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
            this.treeView = new System.Windows.Forms.Panel();
            this.nagviator = new GongSolutions.Shell.ShellTreeView();
            this.shellView1 = new GongSolutions.Shell.ShellView();
            this.fileContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileNameComboBox1 = new GongSolutions.Shell.FileNameComboBox();
            this.fileFilterComboBox1 = new GongSolutions.Shell.FileFilterComboBox();
            this.fileExplorer = new System.Windows.Forms.Panel();
            this.shellComboBox1 = new GongSolutions.Shell.ShellComboBox();
            this.fileDialogToolbar1 = new GongSolutions.Shell.FileDialogToolbar();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView.SuspendLayout();
            this.fileExplorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Controls.Add(this.nagviator);
            this.treeView.Location = new System.Drawing.Point(16, 15);
            this.treeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(267, 524);
            this.treeView.TabIndex = 0;
            // 
            // nagviator
            // 
            this.nagviator.Location = new System.Drawing.Point(4, 4);
            this.nagviator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nagviator.Name = "nagviator";
            this.nagviator.ShellView = this.shellView1;
            this.nagviator.Size = new System.Drawing.Size(259, 521);
            this.nagviator.TabIndex = 0;
            // 
            // shellView1
            // 
            this.shellView1.Location = new System.Drawing.Point(0, 49);
            this.shellView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shellView1.Name = "shellView1";
            this.shellView1.Size = new System.Drawing.Size(449, 347);
            this.shellView1.StatusBar = null;
            this.shellView1.TabIndex = 0;
            this.shellView1.Text = "shellView1";
            this.shellView1.DoubleClick += new System.EventHandler(this.shellView1_DoubleClick);
            // 
            // fileContent
            // 
            this.fileContent.Location = new System.Drawing.Point(752, 37);
            this.fileContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileContent.Name = "fileContent";
            this.fileContent.Size = new System.Drawing.Size(505, 502);
            this.fileContent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 432);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 475);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "File Type";
            // 
            // fileNameComboBox1
            // 
            this.fileNameComboBox1.FormattingEnabled = true;
            this.fileNameComboBox1.Location = new System.Drawing.Point(107, 422);
            this.fileNameComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileNameComboBox1.Name = "fileNameComboBox1";
            this.fileNameComboBox1.ShellView = this.shellView1;
            this.fileNameComboBox1.Size = new System.Drawing.Size(321, 24);
            this.fileNameComboBox1.TabIndex = 3;
            // 
            // fileFilterComboBox1
            // 
            this.fileFilterComboBox1.FilterItems = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            this.fileFilterComboBox1.FormattingEnabled = true;
            this.fileFilterComboBox1.Location = new System.Drawing.Point(107, 471);
            this.fileFilterComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileFilterComboBox1.Name = "fileFilterComboBox1";
            this.fileFilterComboBox1.ShellView = this.shellView1;
            this.fileFilterComboBox1.Size = new System.Drawing.Size(321, 24);
            this.fileFilterComboBox1.TabIndex = 4;
            // 
            // fileExplorer
            // 
            this.fileExplorer.Controls.Add(this.shellComboBox1);
            this.fileExplorer.Controls.Add(this.fileDialogToolbar1);
            this.fileExplorer.Controls.Add(this.fileFilterComboBox1);
            this.fileExplorer.Controls.Add(this.fileNameComboBox1);
            this.fileExplorer.Controls.Add(this.label2);
            this.fileExplorer.Controls.Add(this.label1);
            this.fileExplorer.Controls.Add(this.shellView1);
            this.fileExplorer.Location = new System.Drawing.Point(291, 15);
            this.fileExplorer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileExplorer.Name = "fileExplorer";
            this.fileExplorer.Size = new System.Drawing.Size(453, 524);
            this.fileExplorer.TabIndex = 1;
            // 
            // shellComboBox1
            // 
            this.shellComboBox1.Location = new System.Drawing.Point(416, 96);
            this.shellComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shellComboBox1.Name = "shellComboBox1";
            this.shellComboBox1.Size = new System.Drawing.Size(11, 10);
            this.shellComboBox1.TabIndex = 6;
            this.shellComboBox1.Text = "shellComboBox1";
            // 
            // fileDialogToolbar1
            // 
            this.fileDialogToolbar1.AutoSize = true;
            this.fileDialogToolbar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileDialogToolbar1.Location = new System.Drawing.Point(0, 0);
            this.fileDialogToolbar1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fileDialogToolbar1.Name = "fileDialogToolbar1";
            this.fileDialogToolbar1.ShellView = this.shellView1;
            this.fileDialogToolbar1.Size = new System.Drawing.Size(453, 39);
            this.fileDialogToolbar1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(752, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "File Content";
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1265, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileContent);
            this.Controls.Add(this.fileExplorer);
            this.Controls.Add(this.treeView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai6";
            this.Text = "Bai6";
            this.treeView.ResumeLayout(false);
            this.fileExplorer.ResumeLayout(false);
            this.fileExplorer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel treeView;
        private GongSolutions.Shell.ShellTreeView nagviator;
        private System.Windows.Forms.Panel fileContent;
        private GongSolutions.Shell.ShellView shellView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private GongSolutions.Shell.FileNameComboBox fileNameComboBox1;
        private GongSolutions.Shell.FileFilterComboBox fileFilterComboBox1;
        private System.Windows.Forms.Panel fileExplorer;
        private GongSolutions.Shell.FileDialogToolbar fileDialogToolbar1;
        private System.Windows.Forms.Label label3;
        private GongSolutions.Shell.ShellComboBox shellComboBox1;
    }
}