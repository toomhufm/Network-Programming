namespace Lab1
{
    partial class Bai7
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
            this.oct1 = new System.Windows.Forms.TextBox();
            this.oct2 = new System.Windows.Forms.TextBox();
            this.oct3 = new System.Windows.Forms.TextBox();
            this.oct4 = new System.Windows.Forms.TextBox();
            this.cidr = new System.Windows.Forms.TextBox();
            this.subnetNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // oct1
            // 
            this.oct1.Location = new System.Drawing.Point(129, 84);
            this.oct1.Name = "oct1";
            this.oct1.Size = new System.Drawing.Size(100, 23);
            this.oct1.TabIndex = 0;
            this.oct1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oct2
            // 
            this.oct2.Location = new System.Drawing.Point(235, 84);
            this.oct2.Name = "oct2";
            this.oct2.Size = new System.Drawing.Size(100, 23);
            this.oct2.TabIndex = 1;
            this.oct2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oct3
            // 
            this.oct3.Location = new System.Drawing.Point(341, 84);
            this.oct3.Name = "oct3";
            this.oct3.Size = new System.Drawing.Size(100, 23);
            this.oct3.TabIndex = 2;
            this.oct3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oct4
            // 
            this.oct4.Location = new System.Drawing.Point(447, 84);
            this.oct4.Name = "oct4";
            this.oct4.Size = new System.Drawing.Size(100, 23);
            this.oct4.TabIndex = 3;
            this.oct4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cidr
            // 
            this.cidr.Location = new System.Drawing.Point(553, 84);
            this.cidr.Name = "cidr";
            this.cidr.Size = new System.Drawing.Size(100, 23);
            this.cidr.TabIndex = 4;
            this.cidr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subnetNum
            // 
            this.subnetNum.Location = new System.Drawing.Point(129, 137);
            this.subnetNum.Name = "subnetNum";
            this.subnetNum.Size = new System.Drawing.Size(100, 23);
            this.subnetNum.TabIndex = 5;
            this.subnetNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(222, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(327, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(433, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(542, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(40, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "IP Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(53, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Subnet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(613, 245);
            this.dataGridView1.TabIndex = 12;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(235, 138);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(100, 23);
            this.calculateBtn.TabIndex = 13;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(341, 138);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 23);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(447, 138);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 23);
            this.exitBtn.TabIndex = 15;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UTM Bebas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.OliveDrab;
            this.label7.Location = new System.Drawing.Point(194, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 47);
            this.label7.TabIndex = 16;
            this.label7.Text = "Subnetting Calculator";
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subnetNum);
            this.Controls.Add(this.cidr);
            this.Controls.Add(this.oct4);
            this.Controls.Add(this.oct3);
            this.Controls.Add(this.oct2);
            this.Controls.Add(this.oct1);
            this.Name = "Bai7";
            this.Text = "Bai7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox oct1;
        private TextBox oct2;
        private TextBox oct3;
        private TextBox oct4;
        private TextBox cidr;
        private TextBox subnetNum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Button calculateBtn;
        private Button clearBtn;
        private Button exitBtn;
        private Label label7;
    }
}