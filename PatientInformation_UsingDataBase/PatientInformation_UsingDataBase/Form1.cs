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

namespace PatientInformation_UsingDataBase
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

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connetionString = "server=LAPTOP-4UV87UTN;Database=PatientDetails;Trusted_Connection=true;";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                query = "Insert into patient  values(" + txtPatientId.Text + ", '" + txtFullName.Text + "',' " + txtPType.Text + "','" + txtDisease.Text + "','"+txtTotalBill.Text+"',"+txtDate.Text+")";
                sqlCon = new SqlConnection(connetionString);
                cmd = new SqlCommand(query, sqlCon);
                sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("patient Information Saved Successfully");
               // ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
