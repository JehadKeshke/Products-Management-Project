﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace B201200573_proje.Classes
{
    class EnPaUc_cs
    {
        DA.DataAccess da = new DA.DataAccess();
        public DataTable Ucuz_Pahali()
        {
            DataTable dt = new DataTable();
            dt = da.SelectData("UcuzPahali",null);
            return dt;      
        }
    }
}
