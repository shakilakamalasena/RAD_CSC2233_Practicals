namespace Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt_num1.Text);
            int num2 = int.Parse(txt_num2.Text);

            int result = num1 + num2;

            txt_result.Text = result.ToString();
            lbl_result.Text = result.ToString();
            lst_result.Items.Add(result);
        }
    }
}
