using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDWeb
{
    public partial class StudentEntryUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                messageLabel.Text = "";
            }
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string regNo = regNoTextBox.Text;

            Student aStudent = new Student(name, regNo);

            if (SaveStudent(aStudent))
            {
                messageLabel.Text = "Saved Successfully!";
            }
            else
            {
                messageLabel.Text = "Insertion Failed!";
            }
        }

        private bool SaveStudent(Student aStudent)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["UniversityConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            string query = String.Format("INSERT INTO Students VALUES('{0}','{1}')", aStudent.Name, aStudent.RegNo);

            SqlCommand command = new SqlCommand(query,connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected > 0;

        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string RegNo { get; set; }
        public Student(string name, string regNo)
        {
            Name = name;
            RegNo = regNo;
        }
    }
}