namespace TestSolWFA.UI
{
    partial class CreateEmployee
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
            btnCancel = new Button();
            btnSaveEmployee = new Button();
            txtName = new TextBox();
            txtFirstSurname = new TextBox();
            txtSecondSurname = new TextBox();
            txtArea = new TextBox();
            txtSalary = new TextBox();
            dtBirthDate = new DateTimePicker();
            lblName = new Label();
            lblFirstSurname = new Label();
            lblSecondSurname = new Label();
            lblArea = new Label();
            lblDateBirth = new Label();
            lblSalary = new Label();
            txtId = new TextBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 330);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 24);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveEmployee
            // 
            btnSaveEmployee.Location = new Point(12, 276);
            btnSaveEmployee.Name = "btnSaveEmployee";
            btnSaveEmployee.Size = new Size(116, 33);
            btnSaveEmployee.TabIndex = 1;
            btnSaveEmployee.Text = "Crear Empleado";
            btnSaveEmployee.UseVisualStyleBackColor = true;
            btnSaveEmployee.Click += btnSaveEmployee_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(182, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 2;
            // 
            // txtFirstSurname
            // 
            txtFirstSurname.Location = new Point(182, 60);
            txtFirstSurname.Name = "txtFirstSurname";
            txtFirstSurname.Size = new Size(121, 23);
            txtFirstSurname.TabIndex = 3;
            // 
            // txtSecondSurname
            // 
            txtSecondSurname.Location = new Point(182, 97);
            txtSecondSurname.Name = "txtSecondSurname";
            txtSecondSurname.Size = new Size(121, 23);
            txtSecondSurname.TabIndex = 4;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(182, 139);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(121, 23);
            txtArea.TabIndex = 5;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(182, 230);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(121, 23);
            txtSalary.TabIndex = 6;
            // 
            // dtBirthDate
            // 
            dtBirthDate.CustomFormat = "dd/MM/yyyy";
            dtBirthDate.Format = DateTimePickerFormat.Custom;
            dtBirthDate.Location = new Point(182, 179);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(121, 23);
            dtBirthDate.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(33, 31);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 15);
            lblName.TabIndex = 8;
            lblName.Text = "Nombre:";
            // 
            // lblFirstSurname
            // 
            lblFirstSurname.AutoSize = true;
            lblFirstSurname.Location = new Point(33, 68);
            lblFirstSurname.Name = "lblFirstSurname";
            lblFirstSurname.Size = new Size(98, 15);
            lblFirstSurname.TabIndex = 9;
            lblFirstSurname.Text = "Apellido Paterno:";
            // 
            // lblSecondSurname
            // 
            lblSecondSurname.AutoSize = true;
            lblSecondSurname.Location = new Point(33, 105);
            lblSecondSurname.Name = "lblSecondSurname";
            lblSecondSurname.Size = new Size(102, 15);
            lblSecondSurname.TabIndex = 10;
            lblSecondSurname.Text = "Apellido Materno:";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(33, 139);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(34, 15);
            lblArea.TabIndex = 11;
            lblArea.Text = "Area:";
            // 
            // lblDateBirth
            // 
            lblDateBirth.AutoSize = true;
            lblDateBirth.Location = new Point(33, 187);
            lblDateBirth.Name = "lblDateBirth";
            lblDateBirth.Size = new Size(122, 15);
            lblDateBirth.TabIndex = 12;
            lblDateBirth.Text = "Fecha de Nacimiento:";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(33, 233);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(45, 15);
            lblSalary.TabIndex = 13;
            lblSalary.Text = "Salario:";
            // 
            // txtId
            // 
            txtId.Location = new Point(250, 316);
            txtId.Name = "txtId";
            txtId.Size = new Size(41, 23);
            txtId.TabIndex = 15;
            txtId.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.Location = new Point(170, 277);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 33);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Eliminar Empleado";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // CreateEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 366);
            Controls.Add(btnDelete);
            Controls.Add(txtId);
            Controls.Add(lblSalary);
            Controls.Add(lblDateBirth);
            Controls.Add(lblArea);
            Controls.Add(lblSecondSurname);
            Controls.Add(lblFirstSurname);
            Controls.Add(lblName);
            Controls.Add(dtBirthDate);
            Controls.Add(txtSalary);
            Controls.Add(txtArea);
            Controls.Add(txtSecondSurname);
            Controls.Add(txtFirstSurname);
            Controls.Add(txtName);
            Controls.Add(btnSaveEmployee);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "CreateEmployee";
            Text = "Crear Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSaveEmployee;
        private TextBox txtName;
        private TextBox txtFirstSurname;
        private TextBox txtSecondSurname;
        private TextBox txtArea;
        private TextBox txtSalary;
        private DateTimePicker dtBirthDate;
        private Label lblName;
        private Label lblFirstSurname;
        private Label lblSecondSurname;
        private Label lblArea;
        private Label lblDateBirth;
        private Label lblSalary;
        private TextBox txtId;
        private Button btnDelete;
    }
}