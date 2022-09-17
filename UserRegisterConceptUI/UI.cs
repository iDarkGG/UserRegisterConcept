namespace UserRegisterConceptUI
{
    public partial class UI : Form
    {
        inheritance uwu = new inheritance();

        public UI()
        {
            InitializeComponent();
        }

        private void UI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user0 = txtUser.Text;
            string pass1 = txtPassword.Text;
            uwu.UserLogin(user0, pass1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}