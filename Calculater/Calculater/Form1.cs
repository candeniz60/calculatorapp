using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculater
{
    public partial class Form1 : Form
    {
        string number1 = "";
        string number2 = "";
        string islem = "";
        int numb1 = 0;
        int numb2 = 0;
        int counterCarpim = 0;
        int counterToplam = 0;
        int counterBolum = 0;
        int counterCikarma = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void hesapla(string islem)
        {
            if (islem == "+")
            {
                numb2 = Int32.Parse(number2);
                textBox1.Clear();
                numb1 += numb2;
                number1 = numb1.ToString();
                textBox1.Text = numb1.ToString();
                resetCounters();
            }
            if (islem == "*")
            {
                numb2 = Int32.Parse(number2);
                textBox1.Clear();
                numb1 *= numb2;
                number1 = numb1.ToString();
                textBox1.Text = numb1.ToString();
                resetCounters();
            }
            if (islem == "/")
            {
                numb2 = Int32.Parse(number2);
                textBox1.Clear();
                numb1 /= numb2;
                number1 = numb1.ToString();
                textBox1.Text = numb1.ToString();
                resetCounters();
            }
            if (islem == "-")
            {
                numb2 = Int32.Parse(number2);
                textBox1.Clear();
                numb1 -= numb2;
                number1 = numb1.ToString();
                textBox1.Text = numb1.ToString();
                resetCounters();
            }
        }

        public void resetCounters()
        {
            counterCarpim = 0;
            counterToplam = 0;
            counterBolum = 0;
            counterCikarma = 0;
            number2 = "";
        }

        public bool islemDogrulama()
        {
            if (counterBolum > 0 || counterCarpim > 0 || counterCikarma > 0 || counterToplam > 0)
            {
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(1);
            if (islemDogrulama())
            {
                number2 += "1";
            }
            else { number1 += "1"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(2);
            if (islemDogrulama())
            {
                number2 += "2";
            }
            else { number1 += "2"; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(3);
            if (islemDogrulama())
            {
                number2 += "3";
            }
            else { number1 += "3"; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(4);
            if (islemDogrulama())
            {
                number2 += "4";
            }
            else { number1 += "4"; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(5);
            if (islemDogrulama())
            {
                number2 += "5";
            }
            else { number1 += "5"; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(6);
            if (islemDogrulama())
            {
                number2 += "6";
            }
            else { number1 += "6"; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(7);
            if (islemDogrulama())
            {
                number2 += "7";
            }
            else { number1 += "7"; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(8);
            if (islemDogrulama())
            {
                number2 += "8";
            }
            else { number1 += "8"; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(9);
            if (islemDogrulama())
            {
                number2 += "9";
            }
            else { number1 += "9"; }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += Convert.ToString(0);
            if (islemDogrulama())
            {
                number2 += "0";
            }
            else { number1 += "0"; }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            islem = "+";
            counterToplam += 1;
            numb1 = Int32.Parse(number1);
            if (number2 != "")
            {
                hesapla(islem);
            }
            else
            {
                if (counterToplam == 1)
                {
                    textBox1.Text += "+";
                }
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {

            islem = "*";
            counterCarpim += 1;
            numb1 = Int32.Parse(number1);
            if (number2 != "")
            {
                hesapla(islem);
            }
            else
            {
                if (counterCarpim == 1)
                {
                    textBox1.Text += "*";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            islem = "-";
            counterCikarma += 1;
            numb1 = Int32.Parse(number1);
            if (number2 != "")
            {
                hesapla(islem);
            }
            else
            {
                if (counterCikarma == 1)
                {
                    textBox1.Text += "-";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            islem = "/";
            counterBolum += 1;
            numb1 = Int32.Parse(number1);
            if (number2 != "")
            {
                hesapla(islem);
            }
            else
            {
                if (counterBolum == 1)
                {
                    textBox1.Text += "/";
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hesapla(islem);
        }
    }
}