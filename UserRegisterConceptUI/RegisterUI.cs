using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserRegisterConceptUI
{
    public partial class RegisterUI : Form
    {
        inheritance uwu = new inheritance(); 
        public RegisterUI()
        {
            InitializeComponent();
        }

        private void RegisterUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UI jsjs = new UI();
            DialogResult d = jsjs.ShowDialog(this);
        }
    }
}
