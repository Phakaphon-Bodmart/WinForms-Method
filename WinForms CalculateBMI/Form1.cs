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
            MessageBox.Show("ยินดีต้อนรับสู่โปรแกรม", "โปรแกรมคำนวณ BMI!!!");
            clearForm();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("จะออกจากโปรแกรมใช่มั้ย", "จะออกแน่นะ!!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                e.Cancel = true; //ยกเลิกคำสั่งปิด Form
            }
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            //ปุ่มคำนวณ BMI
            //input รับค่า Textbox
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            //1 double height = Convert.ToDouble(txtHeight.Text);
            //1 double weight = Convert.ToDouble(txtWeight.Text);

            /*  2  double height = 0;
            if(double.TryParse(txtHeight.Text,out height)==false )
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Please,try again");
                return;     //ถ้าค่า If เป็ยจริง ให้จบการทำงาน
            }
            double weight = 0;
            if (double.TryParse(txtWeight.Text, out weight) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Please,try again");
                return;     //ถ้าค่า If เป็ยจริง ให้จบการทำงาน
            }   2   */

            double height = 0; double weight = 0;
            if (CheckDouble(txtWeight, txtHeight))      //เรียกใช้ Method แบบคืนค่าเป็น True/False
            {
                height = Convert.ToDouble(txtHeight.Text);
                weight = Convert.ToDouble(txtWeight.Text);
            }

            //Process คำนวณ BMI
            //double bmi = weight / Math.Pow(height / 100, 2);
            double bmi = BMI(height, weight);       //เรัยกใช้ Method BMI

            //Output 
            lblResult.Text = bmi.ToString("0.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;   //จัดชิดขวา
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;
            txtName.Text = "";
            txtAge.Text = "0";
            txtHeight.Text = "0";
            txtWeight.Text = "0";
            lblResult.Text = "";
            txtName.Focus();
        }

        private void InputDataValid(TextBox name, TextBox age) //ทดสอบการส่ง Textbox ให้กับ Method
        {
            if (name.Text.Length != 0)      //.length นับความยาวของ Textbox
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

        private double BMI(double h, double w)  //คำนวณ bmi ส่งค่าเข้ามา 2 ตัว
        {
            double bmi = w / Math.Pow(h / 100, 2);
            return bmi;
            //return w / Math.Pow(h / 100, 2);
        }

        private bool CheckDouble(TextBox txtW, TextBox txtH)    //ตรวจสอบข้อมูล
        {
            double w =0;
            double h = 0;
            if((double.TryParse(txtW.Text, out w) == false 
                || (double.TryParse(txtH.Text, out h)==false)))
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Please,try again");
                return false;
            }
            return true;
        }
    }
}
