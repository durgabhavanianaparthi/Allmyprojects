using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4__Bhavani_Employee7
{
    internal class DB_Connection : DB_List
    {

        string? connection;
       // SqlConnection? con;
        string? query;
        public void Method1()
        {
            var listEmployee_LIst = EmployeeMethod();
            connection = "Server=LAPTOP-4UV87UTN;Database=Durgabhavani;Trusted_Connection = true;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connection);
            //query = "insert into Employee(EmpName,EmpAge,Gender,DeptID)" + "values (@EmpName,@EmpAge,@EmpGender,@DeptID)";
            query = "insert into Emp (EmpId,EmpName,EmpAge,EmpGender,DeptId)"+"values (@EmpName,@EmpAge,@EmpGender,@DeptId)";
            int isdone = 0;
            foreach (var dept in listEmployee_LIst)
            {
               
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@EmpName", System.Data.SqlDbType.VarChar, 100).Value = dept.EmpName;
                cmd.Parameters.Add("@EmpAge", System.Data.SqlDbType.VarChar, 100).Value = dept.EmpAge;
                cmd.Parameters.Add("@EmpGender", System.Data.SqlDbType.VarChar, 100).Value = dept.EmpGender;
                cmd.Parameters.Add("@DeptId", System.Data.SqlDbType.VarChar, 100).Value = dept.DeptId;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            if (isdone == 1)
            {
                Console.WriteLine("Values  Inserted");
            }
        }
    }
}
     
    
