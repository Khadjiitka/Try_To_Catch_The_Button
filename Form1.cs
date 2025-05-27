using System;

namespace AP_10
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
            MessageBox.Show(" Good job! ");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private Random random = new Random();
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            int maxX = this.ClientSize.Width - btn.Width;
            int maxY = this.ClientSize.Height - btn.Height;

            int newX = random.Next(0, maxX);
            int newY = random.Next(0, maxY);
            btn.Location = new Point(newX, newY);
        }

        
    }
}
