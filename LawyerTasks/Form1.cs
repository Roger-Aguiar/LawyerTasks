using LawyerTasks.Classes;
using LawyerTasks.Forms;

namespace LawyerTasks
{
    public partial class FormMainMenu : Form
    {
        //Insert this code in the button to generate the attorney:
        //var attorney = new Attorney();
        //attorney.GenerateAttorney();
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void buttonGeneratePdf_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonExitApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegisterLawyer_Click(object sender, EventArgs e)
        {
            FormRegisterLawyer form = new FormRegisterLawyer();
            form.Show();
        }

        private void buttonRegisterCustomer_Click(object sender, EventArgs e)
        {
            FormRegisterCustomer form = new FormRegisterCustomer();
            form.Show();
        }

        private void buttonGenerateAttorney_Click(object sender, EventArgs e)
        {
            FormAttorneyGenerator form = new FormAttorneyGenerator();
            form.Show();
        }
    }
}