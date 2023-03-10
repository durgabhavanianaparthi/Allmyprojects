using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewUsingToDisplayyMySqlTables
{
    public partial class Form1 : Form
    {
        string connetionString = "";
        SqlConnection sqlCon;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        string query = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connetionString = "server =LAPTOP-4UV87UTN;Database=AllTables;Trusted_Connection=true;";
                //GetEmploye();
                //GetPatient();
                //GetStudent();
                //GetCustomer();
                GetAllTablesdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task GetAllTablesdata()
        {
            DataSet ds = await GetEmploye();
            DataSet dp = await GetPatient();
            DataSet dq = await GetStudent();
            DataSet dr = await GetEmploye();

        }
        private Task<DataSet> GetEmploye()
        {
            return Task.Run(() =>
            {
                query = "Select * from Employe";
                sqlCon = new SqlConnection(connetionString);
                adpt = new SqlDataAdapter(query, sqlCon);
                sqlCon.Open();
                DataSet ds = new DataSet();
                adpt.Fill(ds, "Employe");
                sqlCon.Close();
               //dataGridView1.DataSource = ds.Tables["Employe"];
                return ds;

            });
        }
        private Task<DataSet> GetPatient()
        {

            return Task.Run(() =>
            {
                query = "Select * from Patient";



                query = "Select * from Patient";
                sqlCon = new SqlConnection(connetionString);
                adpt = new SqlDataAdapter(query, sqlCon);
                sqlCon.Open();
                DataSet dp = new DataSet();
                adpt.Fill(dp, "Patient");
                sqlCon.Close();
               // dataGridView2.DataSource = dp.Tables["Patient"];
                return dp;

            });

        }
        private Task<DataSet> GetStudent()
        {
            return Task.Run(() =>
            {

                query = "Select * from Student";



                query = "Select * from Student";
                sqlCon = new SqlConnection(connetionString);
                adpt = new SqlDataAdapter(query, sqlCon);
                sqlCon.Open();
                DataSet dq = new DataSet();
                adpt.Fill(dq, "Student");
                sqlCon.Close();
               // dataGridView3.DataSource = dq.Tables["Student"];
                return dq;

            });
        }

        private Task<DataSet> GetCustomer()
        {
            return Task.Run(() =>
            {

                query = "Select * from Customer";



                query = "Select * from Customer";
                sqlCon = new SqlConnection(connetionString);
                adpt = new SqlDataAdapter(query, sqlCon);
                sqlCon.Open();
                DataSet dr = new DataSet();
                adpt.Fill(dr, "Customer");
                sqlCon.Close();
               // dataGridView4.DataSource = dr.Tables["Customer"];
                return dr;

            });
        }
    }
}


    
    

       
                