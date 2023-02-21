using LawyerTasks.Classes;

namespace LawyerTasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGeneratePdf_Click(object sender, EventArgs e)
        {
            var attorney = new Attorney();
            attorney.GenerateAttorney();
        }
        
    }
}