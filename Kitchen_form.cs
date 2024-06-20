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
    public partial class Kitchen_form : Form
    {
        public Kitchen_form()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Kitchen_form.ActiveForm.Hide();
            Main_menu_form NewForm = new Main_menu_form();
            NewForm.ShowDialog();
            Close();
        }
    }
}
