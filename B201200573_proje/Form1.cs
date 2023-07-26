using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace B201200573_proje
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void uyeOlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void girişYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Girisyap frm = new Frm_Girisyap();
            frm.ShowDialog();
        }
        private void urunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_kategore f = new frm_kategore();
            f.ShowDialog();
        }

        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Urun f = new frm_Urun();
            f.ShowDialog();

        }
       
        private void urunYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_UrunYonet f = new frm_UrunYonet();
            f.ShowDialog();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.girişYapToolStripMenuItem.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.urunYönetimiToolStripMenuItem.PerformClick();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = Application.OpenForms["Form1"] as Form1;
            f.urunToolStripMenuItem.Enabled = false;
            f.çıkışYapToolStripMenuItem.Enabled = false;
            f.kateGoreToolStripMenuItem.Enabled = false;
            f.button2.Enabled = false;
            f.button1.Enabled = true;
            f.button3.Enabled = false;
            f.button4.Enabled = false;
            f.girişYapToolStripMenuItem.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_EnSatan f = new frm_EnSatan();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_Uc_Pa f = new frm_Uc_Pa();
            f.ShowDialog();
        }
    }
}
