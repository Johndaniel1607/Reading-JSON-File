using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TVLICT201.JSONReader.Windows.Employee
{
    /// <summary>
    /// Interaction logic for EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();
            
            Employee employee = new Employee();

            using (StreamReader r = new StreamReader("data\\employee.json"))
            {
                string json = r.ReadToEnd();
                employee = JsonConvert.DeserializeObject<Employee>(json);
            }

            lblEmployeeId.Content = "Id :" + employee.Id;
            lblEmployeeFirstName.Content = "FirstName :" + employee.FirstName;
            lblEmployeeLastName.Content = "LastName :" + employee.LastName;
            lblEmployeeEmailAddress.Content = "EmailAddress :" + employee.EmailAddress;
            lblEmployeeSalary.Content = "Salary :" + employee.Salary;
        }
    }
}
