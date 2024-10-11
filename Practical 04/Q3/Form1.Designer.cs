namespace Q3
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
            txt_num1 = new TextBox();
            txt_num2 = new TextBox();
            label1 = new Label();
            txt_result = new TextBox();
            lbl_result = new Label();
            lst_result = new ListBox();
            btn_add = new Button();
            SuspendLayout();
            // 
            // txt_num1
            // 
            txt_num1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_num1.Location = new Point(146, 105);
            txt_num1.Name = "txt_num1";
            txt_num1.Size = new Size(125, 34);
            txt_num1.TabIndex = 0;
            // 
            // txt_num2
            // 
            txt_num2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_num2.Location = new Point(382, 105);
            txt_num2.Name = "txt_num2";
            txt_num2.Size = new Size(125, 34);
            txt_num2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 115);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 2;
            label1.Text = "+";
            // 
            // txt_result
            // 
            txt_result.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_result.Location = new Point(262, 190);
            txt_result.Name = "txt_result";
            txt_result.Size = new Size(125, 34);
            txt_result.TabIndex = 3;
            // 
            // lbl_result
            // 
            lbl_result.AutoSize = true;
            lbl_result.Location = new Point(299, 256);
            lbl_result.Name = "lbl_result";
            lbl_result.Size = new Size(50, 20);
            lbl_result.TabIndex = 4;
            lbl_result.Text = "label2";
            // 
            // lst_result
            // 
            lst_result.FormattingEnabled = true;
            lst_result.Location = new Point(251, 296);
            lst_result.Name = "lst_result";
            lst_result.Size = new Size(150, 104);
            lst_result.TabIndex = 5;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(533, 110);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(51, 29);
            btn_add.TabIndex = 6;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 450);
            Controls.Add(btn_add);
            Controls.Add(lst_result);
            Controls.Add(lbl_result);
            Controls.Add(txt_result);
            Controls.Add(label1);
            Controls.Add(txt_num2);
            Controls.Add(txt_num1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_num1;
        private TextBox txt_num2;
        private Label label1;
        private TextBox txt_result;
        private Label lbl_result;
        private ListBox lst_result;
        private Button btn_add;
    }
}
