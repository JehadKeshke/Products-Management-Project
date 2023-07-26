using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace B201200573_proje.Classes
{
    class UyeOl_cs
    {
        DA.DataAccess da = new DA.DataAccess();
        public void Uye_ekle(string name, string sifre, string E_posta) {
            SqlParameter[] parameters = new SqlParameter[3];

         parameters[0] = new SqlParameter("@Adi", SqlDbType.NVarChar, 50);
         parameters[0].Value = name;

         parameters[1] = new SqlParameter("@Sifre", SqlDbType.NVarChar, 50);
         parameters[1].Value = sifre;

         parameters[2] = new SqlParameter("@Eposta", SqlDbType.NVarChar, 50);
         parameters[2].Value = E_posta;

         da.open();
         da.Excutecommend("Uye_ekle", parameters);
         da.close();

        }

    }
}
