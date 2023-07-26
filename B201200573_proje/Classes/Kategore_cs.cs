using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace B201200573_proje.Classes
{
    class Kategore_cs
    {
        DA.DataAccess da= new DA.DataAccess();
        public void Kategore_Ekle(string adi)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Adi", SqlDbType.NVarChar, 50);
            parameters[0].Value = adi;
            da.open();
            da.Excutecommend("Kategore_ekle",parameters);
            da.close();
        }
        public DataTable Kategore_Goster() {

            DataTable dt = new DataTable();
            dt = da.SelectData("Kategore_goster", null);
            return dt;
        
        }
    }
}
