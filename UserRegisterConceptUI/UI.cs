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
            bool checker;
            string user0 = txtUser.Text;
            string pass1 = txtPassword.Text;
            uwu.UserLogin(user0, pass1);
            checker = uwu.UserChecker();
            if (checker == true)
            {
                MessageBox.Show("LOGGED IN", "uwu", MessageBoxButtons.OK);
                txtPassword.Clear();
                txtUser.Clear();
            }
            else
            {
                MessageBox.Show("NOT LOGGED IN", "uwu", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta seguro que desea volver a la pestaña anterior?", "SALIENDO", MessageBoxButtons.OKCancel);
            this.Close();
        }
    }
}