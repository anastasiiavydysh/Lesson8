//�������������� Visual Studio, ������� ������ �� �������� Windows Forms. 
//    �������� ��������, � ���� ���������� textbox1 � textBox2 ������� ��� � ������ �� 
//    ��������� �������� radioButton ��� ��������, ��� ������� ��������: ������� �� �����, 
//    �������� � ������, ������������, ����. 
//    ��������� ���������� � textBox3, ���������� ������ ����������.
namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                if (radioButton1.Checked)
                    textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) % Convert.ToInt32(textBox2.Text));
                if (radioButton2.Checked)
                    textBox3.Text = Convert.ToString(Math.Pow(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
                if (radioButton3.Checked)
                    textBox3.Text = textBox1.Text + textBox2.Text;
                if (radioButton4.Checked)
                    if (Convert.ToInt32(textBox2.Text) != 0)
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));
                    else
                        textBox3.Text = "��������� ������� �� 0";

            }
            else
                textBox3.Text = "������ ��������";
        }
    }
}