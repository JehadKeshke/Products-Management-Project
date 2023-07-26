using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace B201200573_proje.Classes
{
    class EnSatan_cs
    {
        DA.DataAccess da= new DA.DataAccess();
        public DataTable EnSatilan() {
            DataTable dt = new DataTable();
            dt = da.SelectData("EnSatilan", null);
            return dt;
        }
    }
}
