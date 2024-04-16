using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using TestSolWFA.BLL;
using TestSolWFA.Model.Entities;

namespace TestSolWFA.UI
{
    public partial class CreateEmployee : Form
    {
        public EmployeeBLL EmployeeBLL;

        public CreateEmployee()
        {
            EmployeeBLL = new EmployeeBLL();
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            var formIsValid = FormIsValid();

            if (formIsValid)
            {
                var employee = new Employee()
                {
                    Id = string.IsNullOrEmpty(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text),
                    Name = txtName.Text,
                    FirstSurname = txtFirstSurname.Text,
                    SecondSurname = txtSecondSurname.Text,
                    Area = txtArea.Text,
                    BirthDate = dtBirthDate.Value.Date,
                    Salary = Convert.ToDouble(txtSalary.Text)
                };

                var btn = (Button)sender;

                if (btn.Text == "Crear Empleado")
                {
                    try
                    {
                        EmployeeBLL.CreateEployee(employee);
                        var result = MessageBox.Show("El usuario se creo correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        if (result == DialogResult.OK)
                            Close();
                    }
                    catch (Exception)
                    {
                        var result = MessageBox.Show("Se genero un error al Guardar el usuario, intentelo más tarde.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        if (result == DialogResult.OK)
                            Close();
                    }
                }
                else if (btn.Text == "Actualizar")
                {
                    try
                    {
                        EmployeeBLL.UpdateEmployee(employee.Id, employee);
                        var result = MessageBox.Show("El usuario se actualizo correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (result == DialogResult.OK)
                            Close();
                    }
                    catch (Exception)
                    {
                        var result = MessageBox.Show("Se genero un error al Actualizar el empleado seleccionado, intentelo más tardes.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (result == DialogResult.OK)
                            Close();
                    }
                }
            }
        }

        public bool FormIsValid()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtFirstSurname.Text) ||
                string.IsNullOrEmpty(txtSecondSurname.Text) ||
                string.IsNullOrEmpty(txtArea.Text))
            {
                MessageBox.Show("Todos los campos son requeridos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isValid = false;
            }
            else if (string.IsNullOrEmpty(txtSalary.Text) || Regex.IsMatch(txtSalary.Text, "[^0-9.]"))
            {
                MessageBox.Show("El campo salario es requerido y solo se aceptan numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isValid = false;
            }

            return isValid;
        }

        public async void UpdateEmployee(int id)
        {
            try
            {
                var employee = await EmployeeBLL.GetEmployee(id);

                var frmCreate = new CreateEmployee();

                frmCreate.btnDelete.Visible = true;

                frmCreate.Text = "Actualizar Usuario";
                frmCreate.btnSaveEmployee.Text = "Actualizar";

                frmCreate.txtId.Text = id.ToString();
                frmCreate.txtName.Text = employee.Name;
                frmCreate.txtFirstSurname.Text = employee.FirstSurname;
                frmCreate.txtSecondSurname.Text = employee.SecondSurname;
                frmCreate.txtArea.Text = employee.Area;
                frmCreate.dtBirthDate.Text = employee.BirthDate.ToString();
                frmCreate.txtSalary.Text = employee.Salary.ToString();
                frmCreate.StartPosition = FormStartPosition.CenterScreen;

                frmCreate.Show();
            }
            catch (Exception)
            {
                var result = MessageBox.Show("Se genero un error al Obtener el empleado seleccionado, intentelo más tardes.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
            
        }

        public async void btnDelete_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro de eliminar el usuario seleccionado?", "Precaucion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                try
                {
                    var idEmployee = Convert.ToInt32(txtId.Text);
                    await EmployeeBLL.DeleteEmployee(idEmployee);
                    Close();
                }
                catch (Exception)
                {
                    result = MessageBox.Show("Se genero un error al Eliminar el empleado seleccionado, intentelo más tardes.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        Close();
                    }
                }
            }
        }
    }
}
