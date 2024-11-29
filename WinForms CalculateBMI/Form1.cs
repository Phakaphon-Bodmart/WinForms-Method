namespace WinForms_CalculateBMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("�Թ�յ�͹�Ѻ��������", "������ӹǳ BMI!!!");
            clearForm();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("���͡�ҡ�����������", "���͡���!!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                e.Cancel = true; //¡��ԡ����觻Դ Form
            }
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            //�����ӹǳ BMI
            //input �Ѻ��� Textbox
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            //1 double height = Convert.ToDouble(txtHeight.Text);
            //1 double weight = Convert.ToDouble(txtWeight.Text);

            /*  2  double height = 0;
            if(double.TryParse(txtHeight.Text,out height)==false )
            {
                MessageBox.Show("��͡���������١��ͧ", "Please,try again");
                return;     //��Ҥ�� If ��¨�ԧ ��騺��÷ӧҹ
            }
            double weight = 0;
            if (double.TryParse(txtWeight.Text, out weight) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Please,try again");
                return;     //��Ҥ�� If ��¨�ԧ ��騺��÷ӧҹ
            }   2   */

            double height = 0; double weight = 0;
            if (CheckDouble(txtWeight, txtHeight))      //���¡�� Method Ẻ�׹����� True/False
            {
                height = Convert.ToDouble(txtHeight.Text);
                weight = Convert.ToDouble(txtWeight.Text);
            }

            //Process �ӹǳ BMI
            //double bmi = weight / Math.Pow(height / 100, 2);
            double bmi = BMI(height, weight);       //���¡�� Method BMI

            //Output 
            lblResult.Text = bmi.ToString("0.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;   //�Ѵ�Դ���
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            txtName.Text = "";
            txtAge.Text = "0";
            txtHeight.Text = "0";
            txtWeight.Text = "0";
            lblResult.Text = "";
            txtName.Focus();
        }

        private void InputDataValid(TextBox name, TextBox age) //���ͺ����� Textbox ���Ѻ Method
        {
            if (name.Text.Length != 0)      //.length �Ѻ������Ǣͧ Textbox
            {
                name.ForeColor = Color.DarkGoldenrod;

            }
            else
            {
                name.ForeColor = Color.BlueViolet;
            }

            if (Convert.ToInt32(age.Text) > 0)
            {
                age.ForeColor = Color.DarkGoldenrod;
            }
            else
            {
                age.ForeColor = Color.BlueViolet;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            InputDataValid(txtName , txtAge);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            InputDataValid(txtName, txtAge);
        }

        private double BMI(double h, double w)  //�ӹǳ bmi �觤������� 2 ���
        {
            double bmi = w / Math.Pow(h / 100, 2);
            return bmi;
            //return w / Math.Pow(h / 100, 2);
        }

        private bool CheckDouble(TextBox txtW, TextBox txtH)    //��Ǩ�ͺ������
        {
            double w =0;
            double h = 0;
            if((double.TryParse(txtW.Text, out w) == false 
                || (double.TryParse(txtH.Text, out h)==false)))
            {
                MessageBox.Show("��͡���������١��ͧ", "Please,try again");
                return false;
            }
            return true;
        }
    }
}
