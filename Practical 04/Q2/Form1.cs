namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt_num1.Text);
            double num2 = double.Parse(txt_num2.Text);

            //txt_result.Text = (num1 + num2).ToString();
        }
    }
}
