namespace OOP_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "³������ ��: ";
                label5.Text = "³������: ";

                float x1 = float.Parse(textBox1.Text);
                float y1 = float.Parse(textBox2.Text);
                float a = float.Parse(textBox3.Text);
                float b = float.Parse(textBox4.Text);
                float c = float.Parse(textBox5.Text);
                label4.Text += $"����� ({x1} , {y1}) �� ����� {a}x + {b}y + {c} = 0";

                float result = 0;
                if ((a * a + b * b) != 0)
                {
                    result = (float)(Math.Abs(a * x1 + b * y1 + c) / Math.Sqrt(a * a + b * b));
                    label5.Text += result;
                }

                else
                {
                    throw new DivideByZeroException();
                }
            }
            catch (FormatException)
            {
                label5.Text = "������ �������� ������ ������!";
            }
            catch (DivideByZeroException)
            {
                label5.Text = "���� ����'����. �� ���� ����� �� �����!";
            }
            finally
            {
                MessageBox.Show("     �������� �������� ���� ������!\n��� ����������, ������ �������� '��'.");
            }
        }


    }
}