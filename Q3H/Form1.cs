namespace Q3H
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassWord.Text;

            if (username == "admin" && password == "admin")
            {
                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!");

                // Chuyển sang form khác
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}