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
            var attorney = new Attorney();
            attorney.GenerateAttorney();
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
    }
}