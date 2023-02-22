namespace LawyerTasks.Forms
{
    partial class FormRegisterCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterCustomer));
            button1 = new Button();
            buttonSave = new Button();
            buttonLast = new Button();
            buttonNext = new Button();
            labelNumberOfRows = new Label();
            textBoxCurrentRow = new TextBox();
            buttonPrevious = new Button();
            buttonFirst = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label14 = new Label();
            maskedTextBoxPhone = new MaskedTextBox();
            textBoxCpf = new TextBox();
            label13 = new Label();
            label12 = new Label();
            maskedTextBoxIdentity = new MaskedTextBox();
            label11 = new Label();
            maskedTextBoxZipCode = new MaskedTextBox();
            comboBox1 = new ComboBox();
            label10 = new Label();
            comboBoxState = new ComboBox();
            label9 = new Label();
            textBoxNumero = new TextBox();
            label8 = new Label();
            textBoxEndereco = new TextBox();
            label7 = new Label();
            textBoxEmail = new TextBox();
            label6 = new Label();
            textBoxProfession = new TextBox();
            label4 = new Label();
            textBoxCivilStatus = new TextBox();
            label3 = new Label();
            textBoxNationality = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            dateTimePickerRegisterDate = new DateTimePicker();
            label5 = new Label();
            label15 = new Label();
            dateTimePickerLastUpdate = new DateTimePicker();
            textBoxId = new TextBox();
            label16 = new Label();
            dataGridViewCustomers = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(759, -2);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ControlLight;
            buttonSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(726, -2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(35, 35);
            buttonSave.TabIndex = 14;
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonLast
            // 
            buttonLast.BackColor = SystemColors.ControlLight;
            buttonLast.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLast.Location = new Point(578, -2);
            buttonLast.Name = "buttonLast";
            buttonLast.Size = new Size(150, 35);
            buttonLast.TabIndex = 13;
            buttonLast.Text = "&Último";
            buttonLast.UseVisualStyleBackColor = false;
            // 
            // buttonNext
            // 
            buttonNext.BackColor = SystemColors.ControlLight;
            buttonNext.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNext.Location = new Point(431, -2);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(150, 35);
            buttonNext.TabIndex = 12;
            buttonNext.Text = "P&róximo";
            buttonNext.UseVisualStyleBackColor = false;
            // 
            // labelNumberOfRows
            // 
            labelNumberOfRows.AutoSize = true;
            labelNumberOfRows.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumberOfRows.Location = new Point(363, 5);
            labelNumberOfRows.Name = "labelNumberOfRows";
            labelNumberOfRows.Size = new Size(46, 20);
            labelNumberOfRows.TabIndex = 11;
            labelNumberOfRows.Text = "de 10";
            labelNumberOfRows.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxCurrentRow
            // 
            textBoxCurrentRow.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCurrentRow.Location = new Point(294, -2);
            textBoxCurrentRow.Multiline = true;
            textBoxCurrentRow.Name = "textBoxCurrentRow";
            textBoxCurrentRow.Size = new Size(63, 35);
            textBoxCurrentRow.TabIndex = 10;
            textBoxCurrentRow.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonPrevious
            // 
            buttonPrevious.BackColor = SystemColors.ControlLight;
            buttonPrevious.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPrevious.Location = new Point(147, -2);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(150, 35);
            buttonPrevious.TabIndex = 9;
            buttonPrevious.Text = "&Anterior";
            buttonPrevious.UseVisualStyleBackColor = false;
            // 
            // buttonFirst
            // 
            buttonFirst.BackColor = SystemColors.ControlLight;
            buttonFirst.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFirst.Location = new Point(0, -2);
            buttonFirst.Name = "buttonFirst";
            buttonFirst.Size = new Size(150, 35);
            buttonFirst.TabIndex = 8;
            buttonFirst.Text = "&Primeiro";
            buttonFirst.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonLast);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonFirst);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonPrevious);
            panel1.Controls.Add(textBoxCurrentRow);
            panel1.Controls.Add(buttonNext);
            panel1.Controls.Add(labelNumberOfRows);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 33);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBoxId);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(dateTimePickerLastUpdate);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dateTimePickerRegisterDate);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(maskedTextBoxPhone);
            panel2.Controls.Add(textBoxCpf);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(maskedTextBoxIdentity);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(maskedTextBoxZipCode);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(comboBoxState);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBoxNumero);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBoxEndereco);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBoxEmail);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBoxProfession);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBoxCivilStatus);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBoxNationality);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBoxName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(10, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(771, 445);
            panel2.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(426, 324);
            label14.Name = "label14";
            label14.Size = new Size(87, 25);
            label14.TabIndex = 28;
            label14.Text = "Telefone:";
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxPhone.Location = new Point(519, 321);
            maskedTextBoxPhone.Mask = "(99) 00000-0000";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(149, 33);
            maskedTextBoxPhone.TabIndex = 27;
            // 
            // textBoxCpf
            // 
            textBoxCpf.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCpf.Location = new Point(426, 87);
            textBoxCpf.Name = "textBoxCpf";
            textBoxCpf.Size = new Size(242, 33);
            textBoxCpf.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(372, 93);
            label13.Name = "label13";
            label13.Size = new Size(48, 25);
            label13.TabIndex = 25;
            label13.Text = "CPF:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(13, 90);
            label12.Name = "label12";
            label12.Size = new Size(106, 25);
            label12.TabIndex = 23;
            label12.Text = "Identidade:";
            // 
            // maskedTextBoxIdentity
            // 
            maskedTextBoxIdentity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxIdentity.Location = new Point(191, 87);
            maskedTextBoxIdentity.Name = "maskedTextBoxIdentity";
            maskedTextBoxIdentity.Size = new Size(175, 33);
            maskedTextBoxIdentity.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(13, 324);
            label11.Name = "label11";
            label11.Size = new Size(49, 25);
            label11.TabIndex = 21;
            label11.Text = "CEP:";
            // 
            // maskedTextBoxZipCode
            // 
            maskedTextBoxZipCode.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxZipCode.Location = new Point(191, 321);
            maskedTextBoxZipCode.Mask = "00000-999";
            maskedTextBoxZipCode.Name = "maskedTextBoxZipCode";
            maskedTextBoxZipCode.Size = new Size(229, 33);
            maskedTextBoxZipCode.TabIndex = 20;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(370, 243);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(298, 33);
            comboBox1.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(289, 246);
            label10.Name = "label10";
            label10.Size = new Size(75, 25);
            label10.TabIndex = 18;
            label10.Text = "Cidade:";
            // 
            // comboBoxState
            // 
            comboBoxState.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxState.FormattingEnabled = true;
            comboBoxState.Location = new Point(191, 243);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(92, 33);
            comboBoxState.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(13, 246);
            label9.Name = "label9";
            label9.Size = new Size(72, 25);
            label9.TabIndex = 16;
            label9.Text = "Estado:";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumero.Location = new Point(519, 282);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(149, 33);
            textBoxNumero.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(428, 285);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 14;
            label8.Text = "Número:";
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEndereco.Location = new Point(191, 282);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(229, 33);
            textBoxEndereco.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 285);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 12;
            label7.Text = "Endereço:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(191, 204);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(477, 33);
            textBoxEmail.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 207);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 10;
            label6.Text = "Email:";
            // 
            // textBoxProfession
            // 
            textBoxProfession.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProfession.Location = new Point(191, 165);
            textBoxProfession.Name = "textBoxProfession";
            textBoxProfession.Size = new Size(477, 33);
            textBoxProfession.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 168);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 6;
            label4.Text = "Profissão:";
            // 
            // textBoxCivilStatus
            // 
            textBoxCivilStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCivilStatus.Location = new Point(191, 126);
            textBoxCivilStatus.Name = "textBoxCivilStatus";
            textBoxCivilStatus.Size = new Size(477, 33);
            textBoxCivilStatus.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 129);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 4;
            label3.Text = "Estado civil:  ";
            // 
            // textBoxNationality
            // 
            textBoxNationality.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNationality.Location = new Point(191, 48);
            textBoxNationality.Name = "textBoxNationality";
            textBoxNationality.Size = new Size(477, 33);
            textBoxNationality.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 51);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 2;
            label2.Text = "Nacionalidade:  ";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(191, 9);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(477, 33);
            textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome: ";
            // 
            // dateTimePickerRegisterDate
            // 
            dateTimePickerRegisterDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerRegisterDate.Format = DateTimePickerFormat.Short;
            dateTimePickerRegisterDate.Location = new Point(191, 360);
            dateTimePickerRegisterDate.Name = "dateTimePickerRegisterDate";
            dateTimePickerRegisterDate.Size = new Size(149, 33);
            dateTimePickerRegisterDate.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 366);
            label5.Name = "label5";
            label5.Size = new Size(158, 25);
            label5.TabIndex = 30;
            label5.Text = "Data de cadastro:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(341, 366);
            label15.Name = "label15";
            label15.Size = new Size(172, 25);
            label15.TabIndex = 32;
            label15.Text = "Última atualização:";
            // 
            // dateTimePickerLastUpdate
            // 
            dateTimePickerLastUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerLastUpdate.Format = DateTimePickerFormat.Short;
            dateTimePickerLastUpdate.Location = new Point(519, 360);
            dateTimePickerLastUpdate.Name = "dateTimePickerLastUpdate";
            dateTimePickerLastUpdate.Size = new Size(149, 33);
            dateTimePickerLastUpdate.TabIndex = 31;
            // 
            // textBoxId
            // 
            textBoxId.Enabled = false;
            textBoxId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxId.Location = new Point(191, 399);
            textBoxId.MaxLength = 36;
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(477, 33);
            textBoxId.TabIndex = 34;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(13, 402);
            label16.Name = "label16";
            label16.Size = new Size(165, 25);
            label16.TabIndex = 33;
            label16.Text = "Código do cliente:";
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(10, 490);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowTemplate.Height = 25;
            dataGridViewCustomers.Size = new Size(769, 178);
            dataGridViewCustomers.TabIndex = 18;
            // 
            // FormRegisterCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(791, 680);
            Controls.Add(dataGridViewCustomers);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormRegisterCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button buttonSave;
        private Button buttonLast;
        private Button buttonNext;
        private Label labelNumberOfRows;
        private TextBox textBoxCurrentRow;
        private Button buttonPrevious;
        private Button buttonFirst;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxId;
        private Label label16;
        private Label label15;
        private DateTimePicker dateTimePickerLastUpdate;
        private Label label5;
        private DateTimePicker dateTimePickerRegisterDate;
        private Label label14;
        private MaskedTextBox maskedTextBoxPhone;
        private TextBox textBoxCpf;
        private Label label13;
        private Label label12;
        private MaskedTextBox maskedTextBoxIdentity;
        private Label label11;
        private MaskedTextBox maskedTextBoxZipCode;
        private ComboBox comboBox1;
        private Label label10;
        private ComboBox comboBoxState;
        private Label label9;
        private TextBox textBoxNumero;
        private Label label8;
        private TextBox textBoxEndereco;
        private Label label7;
        private TextBox textBoxEmail;
        private Label label6;
        private TextBox textBoxProfession;
        private Label label4;
        private TextBox textBoxCivilStatus;
        private Label label3;
        private TextBox textBoxNationality;
        private Label label2;
        private TextBox textBoxName;
        private Label label1;
        private DataGridView dataGridViewCustomers;
    }
}