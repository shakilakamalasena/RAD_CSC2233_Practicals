namespace PracticalAnswer
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_enterData = new Button();
            btn_viewSalary = new Button();
            SuspendLayout();
            // 
            // btn_enterData
            // 
            btn_enterData.Location = new Point(126, 160);
            btn_enterData.Name = "btn_enterData";
            btn_enterData.Size = new Size(115, 53);
            btn_enterData.TabIndex = 0;
            btn_enterData.Text = "Enter Data";
            btn_enterData.UseVisualStyleBackColor = true;
            btn_enterData.Click += btn_enterData_Click;
            // 
            // btn_viewSalary
            // 
            btn_viewSalary.Location = new Point(312, 160);
            btn_viewSalary.Name = "btn_viewSalary";
            btn_viewSalary.Size = new Size(115, 53);
            btn_viewSalary.TabIndex = 1;
            btn_viewSalary.Text = "View Salary";
            btn_viewSalary.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 393);
            Controls.Add(btn_viewSalary);
            Controls.Add(btn_enterData);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_enterData;
        private Button btn_viewSalary;
    }
}