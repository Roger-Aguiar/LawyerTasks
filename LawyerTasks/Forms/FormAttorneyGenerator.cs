using LawyerTasks.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawyerTasks.Forms
{
    public partial class FormAttorneyGenerator : Form
    {
        public FormAttorneyGenerator()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGenerateAttorney_Click(object sender, EventArgs e)
        {
            var location = SaveFile.Save();
            var attorney = new Attorney(location);
            attorney.GenerateAttorney();

            var email = new EmailSent(location);
            email.SendEmail();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLocation_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
