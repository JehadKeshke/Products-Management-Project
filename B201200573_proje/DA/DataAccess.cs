using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace B201200573_proje.DA
{
    class DataAccess
    {
        SqlConnection con;
        
        public DataAccess()
        {
            con = new SqlConnection("Data Source=MSI;Initial Catalog=StarLight_Store;Integrated Security=True");
        }
        public void open()
        {
            if (con.State == ConnectionState.Closed)
            con.Open();

        }
        public void close()
        {
            if (con.State == ConnectionState.Open) 
            con.Close();

        }
        public DataTable SelectData(string proc_name, SqlParameter[] parametres)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = proc_name;
            if (parametres != null)
            
                for (int i = 0; i < parametres.Length; i++)
                {
                    cmd.Parameters.Add(parametres[i]);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
        }
        public void Excutecommend(string proc_name, SqlParameter[] parametres)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = proc_name;
            if (parametres != null)

                for (int i = 0; i < parametres.Length; i++)
                {
                    cmd.Parameters.Add(parametres[i]);
                }
            cmd.ExecuteNonQuery(); 
        }
    } 
}
    

