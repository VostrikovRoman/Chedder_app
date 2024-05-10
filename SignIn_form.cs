using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chedder_app
{
    public partial class SignIn_form : Form
    {
        public SignIn_form()
        {
            InitializeComponent();
        }

        private void SignIn_form_Load(object sender, EventArgs e)
        {

        }

        private void sign_in_button_Click(object sender, EventArgs e)
        {
            SignIn_form.ActiveForm.Hide();
            Main_menu_form NewForm = new Main_menu_form();
            NewForm.ShowDialog();
            Close();
        }
    }
}
