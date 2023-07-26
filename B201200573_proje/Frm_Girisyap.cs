using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace B201200573_proje
{
    public partial class Frm_Girisyap : Form
    {
        public Frm_Girisyap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Frm_Uyeol f = new Frm_Uyeol();
            f.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Classes.Cs_Girisyap cs_giris = new Classes.Cs_Girisyap();
            dt = cs_giris.Girisyap(textBox1.Text,textBox2.Text);
            if (dt.Rows.Count >0)
            {
                MessageBox.Show("Veri tabanına bagalndı, Giriş yapıldı..");
                this.Close();
                Form1 f = Application.OpenForms["Form1"] as Form1;
                f.urunToolStripMenuItem.Enabled = true;
                f.çıkışYapToolStripMenuItem.Enabled = true;
                f.kapatToolStripMenuItem.Enabled = true;
                f.kateGoreToolStripMenuItem.Enabled = true;
                f.button1.Enabled = false;
                f.button2.Enabled = true;
                f.button3.Enabled = true;
                f.button4.Enabled = true;
                f.girişYapToolStripMenuItem.Enabled = false;

            }
            else
            {
                MessageBox.Show("Veri tabanına baglanamadı..");
            }
            

        }
    }
}
