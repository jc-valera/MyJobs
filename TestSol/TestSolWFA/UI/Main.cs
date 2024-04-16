using System;
using System.Data;
using System.Windows.Forms;
using TestSolWFA.BLL;
using TestSolWFA.Model.Entities;

namespace TestSolWFA.UI
{
    public partial class Main : Form
    {
        public EmployeeBLL EmployeeBLL { get; }

        public Main()
        {
            InitializeComponent();

            LoadGridEmployees();
        }

        public async Task LoadGridEmployees()
        {
            try
            {
                var employeeBLL = new EmployeeBLL();

                await employeeBLL.GetServiceStatus();

                var employees = await employeeBLL.GetAllEmployees();

                dgvEmployees.DataSource = employees;

                dgvEmployees.Columns["Id"].Visible = false;

                dgvEmployees.Columns[0].HeaderText = "Id";
                dgvEmployees.Columns[1].HeaderText = "Nombre";
                dgvEmployees.Columns[2].HeaderText = "Apellido Paterno";
                dgvEmployees.Columns[3].HeaderText = "Apellido Materno";
                dgvEmployees.Columns[4].HeaderText = "Area";
                dgvEmployees.Columns[5].HeaderText = "Fecha de Nacimiento";
                dgvEmployees.Columns[6].HeaderText = "Salario";
            }
            catch (Exception ex)
            {
                var result = MessageBox.Show(ex.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            var frmCreate = new CreateEmployee();
            frmCreate.StartPosition = FormStartPosition.CenterScreen;

            frmCreate.Show();
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex != -1) 
            {
                var idEmployee = dgvEmployees.Rows[rowIndex].Cells[0].Value.ToString();

                var frmCreateEmployee = new CreateEmployee();
                frmCreateEmployee.UpdateEmployee(Convert.ToInt32(idEmployee));
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadGridEmployees();
        }
    }
}
