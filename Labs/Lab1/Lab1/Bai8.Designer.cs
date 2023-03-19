namespace Lab1
{
    partial class Bai8
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.avgBox = new System.Windows.Forms.TextBox();
            this.highBox = new System.Windows.Forms.TextBox();
            this.lowBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(490, 284);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(135, 23);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(101, 92);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(524, 23);
            this.infoBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter info";
            // 
            // dataBox
            // 
            this.dataBox.AcceptsReturn = true;
            this.dataBox.AcceptsTab = true;
            this.dataBox.Location = new System.Drawing.Point(102, 140);
            this.dataBox.Multiline = true;
            this.dataBox.Name = "dataBox";
            this.dataBox.ReadOnly = true;
            this.dataBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataBox.Size = new System.Drawing.Size(524, 71);
            this.dataBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rating";
            // 
            // avgBox
            // 
            this.avgBox.Location = new System.Drawing.Point(101, 226);
            this.avgBox.Name = "avgBox";
            this.avgBox.ReadOnly = true;
            this.avgBox.Size = new System.Drawing.Size(93, 23);
            this.avgBox.TabIndex = 5;
            // 
            // highBox
            // 
            this.highBox.Location = new System.Drawing.Point(101, 255);
            this.highBox.Name = "highBox";
            this.highBox.ReadOnly = true;
            this.highBox.Size = new System.Drawing.Size(93, 23);
            this.highBox.TabIndex = 6;
            // 
            // lowBox
            // 
            this.lowBox.Location = new System.Drawing.Point(101, 284);
            this.lowBox.Name = "lowBox";
            this.lowBox.ReadOnly = true;
            this.lowBox.Size = new System.Drawing.Size(93, 23);
            this.lowBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Average";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Highest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lowest";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(284, 226);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(341, 23);
            this.resultBox.TabIndex = 11;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(349, 283);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(135, 23);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(208, 284);
            this.calculateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(135, 23);
            this.calculateBtn.TabIndex = 13;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UTM Bebas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(214, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 44);
            this.label6.TabIndex = 14;
            this.label6.Text = "Student Grade Rating";
            // 
            // Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lowBox);
            this.Controls.Add(this.highBox);
            this.Controls.Add(this.avgBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.exitBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bai8";
            this.Text = "Bai8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exitBtn;
        private TextBox infoBox;
        private Label label1;
        private TextBox dataBox;
        private Label label2;
        private TextBox avgBox;
        private TextBox highBox;
        private TextBox lowBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox resultBox;
        private Button clearBtn;
        private Button calculateBtn;
        private Label label6;
    }
}