using System.Runtime.InteropServices;

namespace Chedder_app
{
    public partial class Main_menu_form : Form
    {
        public Main_menu_form()
        {
            InitializeComponent();
        }

        private void Main_menu_form_Load(object sender, EventArgs e)
        {

        }

        private void cash_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� ��������� �� ���������� - ������ �� ��������");
        }

        private void kitchen_btn_Click(object sender, EventArgs e)
        {
            Main_menu_form.ActiveForm.Hide();
            Kitchen_form NewForm = new Kitchen_form();
            NewForm.ShowDialog();
            Close();
        }

        private void employers_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� ��������� �� ���������� - ������ �� ��������");
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� ��������� �� ���������� - ������ �� ��������");
        }

        private void square_btn_Click(object sender, EventArgs e)
        {
            Main_menu_form.ActiveForm.Hide();
            Square_form NewForm = new Square_form();
            NewForm.ShowDialog();
            Close();
        }
    }


}
