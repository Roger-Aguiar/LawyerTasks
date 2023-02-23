namespace LawyerTasks.Forms
{
    partial class FormAttorneyGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttorneyGenerator));
            label1 = new Label();
            panel1 = new Panel();
            textBoxCpf = new TextBox();
            textBoxSpecificPowers = new TextBox();
            label6 = new Label();
            textBoxId = new TextBox();
            label5 = new Label();
            textBoxLocation = new TextBox();
            label4 = new Label();
            label17 = new Label();
            dateTimePickerRegisterDate = new DateTimePicker();
            comboBoxLawyer = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            buttonGenerateAttorney = new Button();
            buttonClose = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(270, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 0;
            label1.Text = "Procuração";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBoxCpf);
            panel1.Controls.Add(textBoxSpecificPowers);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBoxId);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxLocation);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(dateTimePickerRegisterDate);
            panel1.Controls.Add(comboBoxLawyer);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(16, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 251);
            panel1.TabIndex = 1;
            // 
            // textBoxCpf
            // 
            textBoxCpf.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCpf.Location = new Point(265, 7);
            textBoxCpf.Name = "textBoxCpf";
            textBoxCpf.Size = new Size(380, 33);
            textBoxCpf.TabIndex = 0;
            // 
            // textBoxSpecificPowers
            // 
            textBoxSpecificPowers.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSpecificPowers.Location = new Point(265, 124);
            textBoxSpecificPowers.Name = "textBoxSpecificPowers";
            textBoxSpecificPowers.Size = new Size(380, 33);
            textBoxSpecificPowers.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 129);
            label6.Name = "label6";
            label6.Size = new Size(180, 25);
            label6.TabIndex = 43;
            label6.Text = "Poderes específicos:";
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxId.Location = new Point(265, 163);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(380, 33);
            textBoxId.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 168);
            label5.Name = "label5";
            label5.Size = new Size(214, 25);
            label5.TabIndex = 41;
            label5.Text = "Código da procuração:  ";
            // 
            // textBoxLocation
            // 
            textBoxLocation.Enabled = false;
            textBoxLocation.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLocation.Location = new Point(265, 202);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(380, 33);
            textBoxLocation.TabIndex = 5;
            textBoxLocation.TextChanged += textBoxLocation_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 207);
            label4.Name = "label4";
            label4.Size = new Size(166, 25);
            label4.TabIndex = 39;
            label4.Text = "Local do arquivo:  ";
            label4.Click += label4_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(3, 91);
            label17.Name = "label17";
            label17.Size = new Size(158, 25);
            label17.TabIndex = 38;
            label17.Text = "Data de cadastro:";
            // 
            // dateTimePickerRegisterDate
            // 
            dateTimePickerRegisterDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerRegisterDate.Format = DateTimePickerFormat.Short;
            dateTimePickerRegisterDate.Location = new Point(265, 85);
            dateTimePickerRegisterDate.Name = "dateTimePickerRegisterDate";
            dateTimePickerRegisterDate.Size = new Size(149, 33);
            dateTimePickerRegisterDate.TabIndex = 2;
            // 
            // comboBoxLawyer
            // 
            comboBoxLawyer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxLawyer.FormattingEnabled = true;
            comboBoxLawyer.Location = new Point(265, 46);
            comboBoxLawyer.Name = "comboBoxLawyer";
            comboBoxLawyer.Size = new Size(380, 33);
            comboBoxLawyer.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 49);
            label3.Name = "label3";
            label3.Size = new Size(267, 25);
            label3.TabIndex = 2;
            label3.Text = "Selecione um(a) advogado(a): ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(212, 25);
            label2.TabIndex = 0;
            label2.Text = "Digite o CPF do cliente: ";
            // 
            // buttonGenerateAttorney
            // 
            buttonGenerateAttorney.BackColor = SystemColors.ControlLight;
            buttonGenerateAttorney.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGenerateAttorney.Location = new Point(16, 311);
            buttonGenerateAttorney.Name = "buttonGenerateAttorney";
            buttonGenerateAttorney.Size = new Size(329, 38);
            buttonGenerateAttorney.TabIndex = 6;
            buttonGenerateAttorney.Text = "&Gerar Procuração";
            buttonGenerateAttorney.UseVisualStyleBackColor = false;
            buttonGenerateAttorney.Click += buttonGenerateAttorney_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = SystemColors.ControlLight;
            buttonClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.Location = new Point(346, 311);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(329, 38);
            buttonClose.TabIndex = 7;
            buttonClose.Text = "&Fechar";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormAttorneyGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(691, 361);
            Controls.Add(buttonClose);
            Controls.Add(buttonGenerateAttorney);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormAttorneyGenerator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de procuração";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ComboBox comboBoxLawyer;
        private Label label3;
        private Label label2;
        private Label label17;
        private DateTimePicker dateTimePickerRegisterDate;
        private TextBox textBoxLocation;
        private Label label4;
        private TextBox textBoxId;
        private Label label5;
        private Button buttonGenerateAttorney;
        private Button buttonClose;
        private TextBox textBoxSpecificPowers;
        private Label label6;
        private TextBox textBoxCpf;
    }
}