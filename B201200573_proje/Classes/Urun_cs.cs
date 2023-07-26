using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace B201200573_proje.Classes
{
    class Urun_cs
    {
        DA.DataAccess da = new DA.DataAccess();
        public void Urun_Ekle(string adi , int kateID,float fiyat, string ozellikler) {

            SqlParameter[] parameters = new SqlParameter[4];
            
            parameters[0] = new SqlParameter("@isim", SqlDbType.NVarChar,50);
            parameters[0].Value = adi;
            parameters[1] = new SqlParameter("@katID", SqlDbType.Int);
            parameters[1].Value = kateID;
            parameters[2] = new SqlParameter("@fiyat", SqlDbType.Float);
            parameters[2].Value = fiyat;
            parameters[3] = new SqlParameter("@ozellikler", SqlDbType.NVarChar,50);
            parameters[3].Value = ozellikler;

            da.open();
            da.Excutecommend("Urun_Ekle",parameters);
            da.close();
        }
        public DataTable Urun_goster() {

            return da.SelectData("Urun_yonet", null);
        }
        public DataTable AramaIslem(string key)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@KeyWord", SqlDbType.NVarChar, 50);
            parameters[0].Value = key;

            return da.SelectData("Arama ", parameters);
        }
        public void SilmeIslem(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            parameters[0].Value = id;

            
            da.open();
            da.Excutecommend("Silme", parameters);
            da.close();
        }
        public void GuncellemeISlem(int ID, string ad ,  float fiyat , string ozellikler)
        {
            SqlParameter[] parameters = new SqlParameter[4];

            parameters[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            parameters[0].Value = ID;
            parameters[1] = new SqlParameter("@isim", SqlDbType.NVarChar, 50);
            parameters[1].Value = ad;
            parameters[2] = new SqlParameter("@fiyat", SqlDbType.NVarChar, 50);
            parameters[2].Value = fiyat;
            parameters[3] = new SqlParameter("@ozellik", SqlDbType.NVarChar, 50);
            parameters[3].Value = ozellikler;

            da.open();
            da.Excutecommend("Guncelleme", parameters);
            da.close();
        }
    }
}
