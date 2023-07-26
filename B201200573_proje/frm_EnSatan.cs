using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B201200573_proje
{
    public partial class frm_EnSatan : Form
    {
        public frm_EnSatan()
        {
            InitializeComponent();
        }

        private void frm_EnSatan_Load(object sender, EventArgs e)
        {
            Classes.EnSatan_cs cs = new Classes.EnSatan_cs();
            dataGridView1.DataSource = cs.EnSatilan();
        }
    }
}
