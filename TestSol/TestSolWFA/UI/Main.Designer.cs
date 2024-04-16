namespace TestSolWFA.UI
{
    partial class Main
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
            btnCreateEmployee = new Button();
            dgvEmployees = new DataGridView();
            btnReload = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.Location = new Point(14, 12);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(105, 30);
            btnCreateEmployee.TabIndex = 0;
            btnCreateEmployee.Text = "Crear Empleado";
            btnCreateEmployee.UseVisualStyleBackColor = true;
            btnCreateEmployee.Click += btnCreateEmployee_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(14, 61);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.Size = new Size(674, 202);
            dgvEmployees.TabIndex = 1;
            dgvEmployees.CellDoubleClick += dgvEmployees_CellDoubleClick;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(139, 12);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(99, 30);
            btnReload.TabIndex = 2;
            btnReload.Text = "Actualizar Tabla";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 275);
            Controls.Add(btnReload);
            Controls.Add(dgvEmployees);
            Controls.Add(btnCreateEmployee);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Main";
            Text = "Control de Empleados";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateEmployee;
        private DataGridView dgvEmployees;
        private Button btnReload;
    }
}