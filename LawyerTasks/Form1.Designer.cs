namespace LawyerTasks
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            label1 = new Label();
            buttonRegisterLawyer = new Button();
            buttonRegisterCustomer = new Button();
            buttonGenerateAttorney = new Button();
            buttonSearchLawyer = new Button();
            buttonSearchCustomer = new Button();
            buttonSearchAttorney = new Button();
            pictureBox1 = new PictureBox();
            buttonExitApplication = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(164, 20);
            label1.Name = "label1";
            label1.Size = new Size(217, 32);
            label1.TabIndex = 0;
            label1.Text = "MENU PRINCIPAL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonRegisterLawyer
            // 
            buttonRegisterLawyer.BackColor = SystemColors.ControlLight;
            buttonRegisterLawyer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegisterLawyer.Location = new Point(12, 69);
            buttonRegisterLawyer.Name = "buttonRegisterLawyer";
            buttonRegisterLawyer.Size = new Size(225, 48);
            buttonRegisterLawyer.TabIndex = 1;
            buttonRegisterLawyer.Text = "Cadastrar &Advogado(a)";
            buttonRegisterLawyer.UseVisualStyleBackColor = false;
            buttonRegisterLawyer.Click += buttonRegisterLawyer_Click;
            // 
            // buttonRegisterCustomer
            // 
            buttonRegisterCustomer.BackColor = SystemColors.ControlLight;
            buttonRegisterCustomer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegisterCustomer.Location = new Point(12, 123);
            buttonRegisterCustomer.Name = "buttonRegisterCustomer";
            buttonRegisterCustomer.Size = new Size(225, 48);
            buttonRegisterCustomer.TabIndex = 2;
            buttonRegisterCustomer.Text = "Cadastrar &Cliente";
            buttonRegisterCustomer.UseVisualStyleBackColor = false;
            // 
            // buttonGenerateAttorney
            // 
            buttonGenerateAttorney.BackColor = SystemColors.ControlLight;
            buttonGenerateAttorney.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerateAttorney.Location = new Point(12, 177);
            buttonGenerateAttorney.Name = "buttonGenerateAttorney";
            buttonGenerateAttorney.Size = new Size(225, 48);
            buttonGenerateAttorney.TabIndex = 3;
            buttonGenerateAttorney.Text = "Gerar &Procuração";
            buttonGenerateAttorney.UseVisualStyleBackColor = false;
            // 
            // buttonSearchLawyer
            // 
            buttonSearchLawyer.BackColor = SystemColors.ControlLight;
            buttonSearchLawyer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearchLawyer.Location = new Point(12, 231);
            buttonSearchLawyer.Name = "buttonSearchLawyer";
            buttonSearchLawyer.Size = new Size(225, 48);
            buttonSearchLawyer.TabIndex = 4;
            buttonSearchLawyer.Text = "C&onsultar Advogado";
            buttonSearchLawyer.UseVisualStyleBackColor = false;
            // 
            // buttonSearchCustomer
            // 
            buttonSearchCustomer.BackColor = SystemColors.ControlLight;
            buttonSearchCustomer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearchCustomer.Location = new Point(12, 285);
            buttonSearchCustomer.Name = "buttonSearchCustomer";
            buttonSearchCustomer.Size = new Size(225, 48);
            buttonSearchCustomer.TabIndex = 5;
            buttonSearchCustomer.Text = "Co&nsultar Cliente";
            buttonSearchCustomer.UseVisualStyleBackColor = false;
            // 
            // buttonSearchAttorney
            // 
            buttonSearchAttorney.BackColor = SystemColors.ControlLight;
            buttonSearchAttorney.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSearchAttorney.Location = new Point(12, 339);
            buttonSearchAttorney.Name = "buttonSearchAttorney";
            buttonSearchAttorney.Size = new Size(225, 48);
            buttonSearchAttorney.TabIndex = 6;
            buttonSearchAttorney.Text = "Con&sultar Procuração";
            buttonSearchAttorney.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(253, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 318);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // buttonExitApplication
            // 
            buttonExitApplication.BackColor = SystemColors.ControlLight;
            buttonExitApplication.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExitApplication.Location = new Point(12, 393);
            buttonExitApplication.Name = "buttonExitApplication";
            buttonExitApplication.Size = new Size(510, 48);
            buttonExitApplication.TabIndex = 8;
            buttonExitApplication.Text = "&Encerrar Aplicação";
            buttonExitApplication.UseVisualStyleBackColor = false;
            buttonExitApplication.Click += buttonExitApplication_Click;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(534, 450);
            Controls.Add(buttonExitApplication);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSearchAttorney);
            Controls.Add(buttonSearchCustomer);
            Controls.Add(buttonSearchLawyer);
            Controls.Add(buttonGenerateAttorney);
            Controls.Add(buttonRegisterCustomer);
            Controls.Add(buttonRegisterLawyer);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU PRINCIPAL";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonRegisterLawyer;
        private Button buttonRegisterCustomer;
        private Button buttonGenerateAttorney;
        private Button buttonSearchLawyer;
        private Button buttonSearchCustomer;
        private Button buttonSearchAttorney;
        private PictureBox pictureBox1;
        private Button buttonExitApplication;
    }
}