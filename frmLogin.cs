using System;
using System.Windows.Forms;

namespace Encoder
{
    public partial class frmLogin : Form
    {
        //Global
        cLogin theLogin = new cLogin();
        public frmLogin()
        {
            InitializeComponent();
        }

        //Form load
        //
        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblCode.Text = theLogin.accessCode();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblCode.Text = theLogin.accessCode();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string userInput = txtCode.Text;
            string AutoCode = lblCode.Text;
            if(userInput == AutoCode)
            {
                frmEncoder encodeForm = new frmEncoder();
                encodeForm.Show();
                
                Hide();                     //hides the frmLogin

            }
            else
            {
                MessageBox.Show("Try Again!!");
            }
        }

        
    }
}
