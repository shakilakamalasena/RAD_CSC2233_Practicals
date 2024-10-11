namespace Q2
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
            label1 = new Label();
            txt_num1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_num2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_result = new TextBox();
            label6 = new Label();
            btn_add = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(244, 79);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 0;
            label1.Text = "Number 1";
            // 
            // txt_num1
            // 
            txt_num1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_num1.Location = new Point(244, 110);
            txt_num1.Name = "txt_num1";
            txt_num1.Size = new Size(272, 34);
            txt_num1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(520, 115);
            label2.Name = "label2";
            label2.Size = new Size(21, 28);
            label2.TabIndex = 2;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(520, 198);
            label3.Name = "label3";
            label3.Size = new Size(21, 28);
            label3.TabIndex = 5;
            label3.Text = "*";
            // 
            // txt_num2
            // 
            txt_num2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_num2.Location = new Point(244, 193);
            txt_num2.Name = "txt_num2";
            txt_num2.Size = new Size(272, 34);
            txt_num2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(244, 162);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 3;
            label4.Text = "Number 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(520, 331);
            label5.Name = "label5";
            label5.Size = new Size(21, 28);
            label5.TabIndex = 8;
            label5.Text = "*";
            // 
            // txt_result
            // 
            txt_result.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_result.Location = new Point(244, 326);
            txt_result.Name = "txt_result";
            txt_result.Size = new Size(272, 34);
            txt_result.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(192, 0, 0);
            label6.Location = new Point(244, 295);
            label6.Name = "label6";
            label6.Size = new Size(71, 28);
            label6.TabIndex = 6;
            label6.Text = "Result";
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.FromArgb(192, 0, 0);
            btn_add.Location = new Point(422, 242);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 46);
            btn_add.TabIndex = 9;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_add);
            Controls.Add(label5);
            Controls.Add(txt_result);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txt_num2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txt_num1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Numbers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_num1;
        private Label label2;
        private Label label3;
        private TextBox txt_num2;
        private Label label4;
        private Label label5;
        private TextBox txt_result;
        private Label label6;
        private Button btn_add;
    }
}
