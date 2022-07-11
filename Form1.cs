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
using System.Configuration;



namespace Eclerx.Question1.Minakshee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private void button1_Click(object sender, EventArgs e)
        {
          
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["hrcon"].ConnectionString))
            {
                using(cmd= new SqlCommand("usp_AddNewEmployees",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeNo", TxtEmployeeNo.Text);
                    cmd.Parameters.AddWithValue("@EmployeeName", TxtEmployeeName.Text);
                    cmd.Parameters.AddWithValue("@Salary", TxtSalary.ToString());
                    if(con.State ==ConnectionState.Closed)
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                    }
             
                    MessageBox.Show("New employee add");
                }
            }

        }
      
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        

        }

        private void Form1_Load(object sender, EventArgs e)
           
        {

       
              
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            TxtEmployeeName.Clear();
            TxtEmployeeNo.Clear();
            TxtSalary.Clear();

        }
    }
}
