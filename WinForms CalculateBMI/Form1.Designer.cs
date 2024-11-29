namespace WinForms_CalculateBMI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtAge = new TextBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            label3 = new Label();
            btnBMI = new Button();
            lblResult = new Label();
            label4 = new Label();
            label5 = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(197, 107);
            txtName.Name = "txtName";
            txtName.Size = new Size(328, 27);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.BlanchedAlmond;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(197, 31);
            label1.Name = "label1";
            label1.Size = new Size(346, 36);
            label1.TabIndex = 1;
            label1.Text = "โปรแกรมคำนวณค่า BMI";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(52, 103);
            label2.Name = "label2";
            label2.Size = new Size(124, 36);
            label2.TabIndex = 2;
            label2.Text = "ชื่อ-นามสกุล";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(197, 159);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 3;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(197, 210);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 27);
            txtHeight.TabIndex = 4;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(197, 259);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(125, 27);
            txtWeight.TabIndex = 5;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(115, 155);
            label3.Name = "label3";
            label3.Size = new Size(61, 36);
            label3.TabIndex = 6;
            label3.Text = "อายุ";
            // 
            // btnBMI
            // 
            btnBMI.BackColor = Color.SkyBlue;
            btnBMI.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBMI.Location = new Point(572, 136);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(195, 101);
            btnBMI.TabIndex = 7;
            btnBMI.Text = "ค่า BMI";
            btnBMI.UseVisualStyleBackColor = false;
            btnBMI.Click += btnBMI_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.DarkSalmon;
            lblResult.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Blue;
            lblResult.Location = new Point(36, 312);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(731, 255);
            lblResult.TabIndex = 8;
            lblResult.Text = "....";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(52, 255);
            label4.Name = "label4";
            label4.Size = new Size(124, 36);
            label4.TabIndex = 9;
            label4.Text = "น้ำหนัก (kg)";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(52, 206);
            label5.Name = "label5";
            label5.Size = new Size(124, 36);
            label5.TabIndex = 10;
            label5.Text = "ส่วนสูง (cm)";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SkyBlue;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(572, 248);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(195, 43);
            btnClear.TabIndex = 11;
            btnClear.Text = "เริ่มใหม่";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(809, 586);
            Controls.Add(btnClear);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblResult);
            Controls.Add(btnBMI);
            Controls.Add(label3);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtAge;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Label label3;
        private Button btnBMI;
        private Label lblResult;
        private Label label4;
        private Label label5;
        private Button btnClear;
    }
}
