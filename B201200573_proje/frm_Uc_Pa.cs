using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B201200573_proje
{
    public partial class frm_Uc_Pa : Form
    {
        public frm_Uc_Pa()
        {
            InitializeComponent();
        }

        private void frm_Uc_Pa_Load(object sender, EventArgs e)
        {
            Classes.EnPaUc_cs cs = new Classes.EnPaUc_cs();
            dataGridView1.DataSource = cs.Ucuz_Pahali();
        }
    }
}
