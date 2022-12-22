namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, x1, x2;

            //textBox4.Text = "";

            a = Convert.ToDouble(textBox1.Text);

            b = Convert.ToDouble(textBox2.Text);

            c = Convert.ToDouble(textBox3.Text);

            d = b * b - 4 * a * c;

            if (d >= 0)

            {

                d = Math.Sqrt(d);

                x1 = (-b + d) / (2 * a);

                x2 = (-b - d) / (2 * a);

                textBox4.Text += "Корни уравнения: \r\n";

                textBox4.Text += "x1= " + x1.ToString() + "\r\n";

                textBox4.Text += "\nx2= " + x2.ToString() + "\r\n";

                textBox4.AppendText(" Задача решена");

            }

            else

                textBox4.Text = "Нет действительных корней";

        }
    }
}