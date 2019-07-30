using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace HR_Departments
{
    public partial class Form1 : Form
    {
        string connection_string;
        SqlConnection connection;

        List<Department> departments;
        List<Employee> employees;

        public Form1()
        {
            InitializeComponent();
            connection_string =
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data\HR_DB.mdf;Integrated Security=True";
            connection = new SqlConnection(connection_string);
            departments = new List<Department>();
            employees = new List<Employee>();
            LoadEmployees();
        }

        public void LoadEmployees()
        {
            connection.Open();
            string query = "SELECT * FROM Employees";
            
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //string time = $"({DateTime.Today.ToString("d")}):";
                Employee x = new Employee()
                {
                    Id = (int)reader["Id"],
                    FirstName = (string)reader["FirstName"].ToString(),
                    LastName = (string)reader["LastName"].ToString(),
                    Birthday = DateTime.Parse(reader["Birthday"].ToString()),
                    Position = (string)reader["Position"].ToString(),
                    Experience = (string)reader["Experience"].ToString(),
                    DepId = (int)reader["DepId"],
                    Photo = (string)reader["Photo"].ToString()
                };
                employees.Add(x);
            }

            connection.Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Departments";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Department d = new Department()
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"].ToString()
                };
                departments.Add(d);
                DepartmentsList.Items.Add(d.Name);
            }

            connection.Close();
            DepartmentsList.SelectedIndex = 0;
        }

        private void DepartmentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = DepartmentsList.SelectedItem.ToString();

            var id = departments
                .Where(d => d.Name == name)
                .FirstOrDefault().Id;
            var emps = employees
                .Where(x => x.DepId == id)
                .ToList();
            EmpList.Items.Clear();
            foreach(var x in emps)
            {
                EmpList.Items.Add($"{x.FirstName} {x.LastName}");
            }
            Add_but.Enabled = true;
            FName.Clear();
            LName.Clear();
            Position.Clear();
            Experience.Clear();
        }

        private void EmpList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string data = EmpList.SelectedItem.ToString();
                string[] parts = data.Split();
                string fname = parts[0];
                string lname = parts[1];

                var emp = employees.Where(x => x.FirstName == fname && x.LastName == lname).FirstOrDefault();
                if (emp != null)
                {
                    Photo.Image = Image.FromFile(emp.Photo);
                    FName.Text = emp.FirstName;
                    LName.Text = emp.LastName;
                    Birthday.Value = emp.Birthday;
                    Position.Text = emp.Position;
                    Experience.Text = emp.Experience;
                }
                Add_but.Enabled = false;
            }
            catch(Exception ex) { }            
        }

        private void Add_but_Click(object sender, EventArgs e)
        {
            string fname = FName.Text;
            string lname = LName.Text;
            DateTime bday = Birthday.Value;
            string pos = Position.Text;
            string exprnc = Experience.Text;
            string name = DepartmentsList.SelectedItem.ToString();
            var id = departments
                .Where(d => d.Name == name)
                .FirstOrDefault().Id;
            if (fname == "" || lname == "" || pos == ""
                || exprnc == "" || name == "")
            {
                MessageBox.Show("Warning", "vi ne zapolnili vse polya", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string source = ofd.FileName;
                    string target = $"..\\..\\Photo\\{ofd.SafeFileName}";
                    Photo.Image = Image.FromFile(source);
                    File.Copy(source, target);

                    string query = String.Format(
                        "exec SetEmployees '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'",
                        fname, lname, bday.ToLongTimeString(), pos, exprnc, id, target);
                    //execute procname ()

                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    LoadEmployees();
                }
            }
        }
    }
}
