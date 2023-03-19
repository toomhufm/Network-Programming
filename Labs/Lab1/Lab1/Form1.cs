namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            bai3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai3_1 bai3_1 = new Bai3_1();
            bai3_1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai4 bai4 = new Bai4();
            bai4.Show();    
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bai5 bai5 = new Bai5();
            bai5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bai6 bai6 = new Bai6();
            bai6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bai7 bai7 = new Bai7();
            bai7.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Bai8 bai8 = new Bai8();
            MessageBox.Show("Input format : Name , grade , ... , grade. \nDelimiter is ','\n" +
                "Example : Alice, 7.5, 10, 8.5, 6.75");
            bai8.Show();
        }
    }
}