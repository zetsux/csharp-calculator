namespace PBKK1
{
    public partial class Form1 : Form
    {
        decimal a = -1, b = -1;
        string x = "0";
        bool done = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (done || textBox1.Text == "0")
            {
                textBox1.Text = "1";
                done = false;
            }
            else textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (done || textBox1.Text == "0")
            {
                textBox1.Text = "2";
                done = false;
            }
            else textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (done || textBox1.Text == "0")
            {
                textBox1.Text = "3";
                done = false;
            }
            else textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (done || textBox1.Text == "0")
            {
                textBox1.Text = "4";
                done = false;
            }
            else textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (done || textBox1.Text == "0")
            {
                textBox1.Text = "5";
                done = false;
            }
            else textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (done || textBox1.Text == "0")
            {
                textBox1.Text = "6";
                done = false;
            }
            else textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (done || textBox1.Text == "0")
            {
                textBox1.Text = "7";
                done = false;
            }
            else textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
           if (done || textBox1.Text == "0")
            {
                textBox1.Text = "8";
                done = false;
            }
            else  textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (done || textBox1.Text == "0")
            {
                textBox1.Text = "9";
                done = false;
            }
            else textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (done || textBox1.Text == "0")
            {
                textBox1.Text = "0";
                done = false;
            }
            else textBox1.Text += "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0) textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            a = -1;
            b = -1;
            x = "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0) return;
            if (x == "0")
            {
                a = decimal.Parse(textBox1.Text);
                x = "+";
                textBox1.Clear();
            }
            else if (textBox1.Text.Length == 0) x = "+";
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0) return;
            if (x == "0")
            {
                a = decimal.Parse(textBox1.Text);
                x = "-";
                textBox1.Clear();
            }
            else if (textBox1.Text.Length == 0)  x = "-";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0) return;
            if (x == "0")
            {
                a = decimal.Parse(textBox1.Text);
                x = "/";
                textBox1.Clear();
            }
            else if (textBox1.Text.Length == 0) x = "/";
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0) return;
            if (x == "0")
            {
                a = decimal.Parse(textBox1.Text);
                x = "*";
                textBox1.Clear();
            }
            else if (textBox1.Text.Length == 0) x = "*";
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            if (a != -1 && x != "0")
            {
                b = decimal.Parse(textBox1.Text);

                decimal res = 0;
                switch(x)
                {
                    case "+":
                        res = a + b;
                        break;
                    case "-":
                        res = a - b;
                        break;
                    case "*":
                        res = a * b;
                        break;
                    case "/":
                        res = a / b;
                        break;
                }

                textBox1.Text = res + "";
                a = -1;
                b = -1;
                x = "0";
                done = true;
            }
        }
    }
}