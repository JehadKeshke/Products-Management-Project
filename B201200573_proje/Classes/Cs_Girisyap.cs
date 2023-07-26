using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace B201200573_proje.Classes
{
    class Cs_Girisyap
    {
        DA.DataAccess cs = new DA.DataAccess();
        public DataTable Girisyap(string UyeAdi, string UyeSifre)
        {
            SqlParameter[]parameters= new SqlParameter[2];
            parameters[0] = new SqlParameter("@Adi", SqlDbType.NVarChar,50);
            parameters[0].Value = UyeAdi;

            parameters[1] = new SqlParameter("@Sifre", SqlDbType.NVarChar,50);
            parameters[1].Value = UyeSifre;

            DataTable dt = new DataTable();
            dt = cs.SelectData("Dt_Login", parameters);
            return dt;
        }

        
    }
}
