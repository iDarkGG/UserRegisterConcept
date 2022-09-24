namespace UserRegisterConceptUI
{
    public partial class RegisterUI : Form
    {
        public RegisterUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UI uwu = new UI();
            DialogResult = uwu.ShowDialog(this);
        }

        private void RegisterUI_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            inheritance i = new inheritance();
            bool checker;
            string newUser = txtUser.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confPassword = txtConfPass.Text;
            i.userData.Add(new inheritance(newUser, email, password));
            checker = i.UserChecker();
            if(checker == true)
            {
                MessageBox.Show("LOGGED IN", "uwu", MessageBoxButtons.OK);
                txtEmail.Clear();
                txtPassword.Clear();
                txtConfPass.Clear();
                txtUser.Clear();
            }
            else
            {
                MessageBox.Show("NOT LOGGED IN", "uwu", MessageBoxButtons.OK);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}