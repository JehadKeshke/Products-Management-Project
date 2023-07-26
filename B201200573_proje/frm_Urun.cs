using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B201200573_proje
{
    public partial class frm_Urun : Form
    {
        Classes.Kategore_cs kacls = new Classes.Kategore_cs();
        public frm_Urun()
        {

            InitializeComponent();
            comboBox1.DataSource = kacls.Kategore_Goster();
            comboBox1.DisplayMember = "KategoreIsim";
            comboBox1.ValueMember = "KatagoreId";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        Classes.Urun_cs urcs = new Classes.Urun_cs();
        private void button1_Click(object sender, EventArgs e)
        {
           
            
                urcs.Urun_Ekle(txt_UrunAd.Text, int.Parse(comboBox1.SelectedValue.ToString()), float.Parse(txt_UrunF.Text), txt_UrunO.Text);
                MessageBox.Show("Urun Eklendi..");
                txt_UrunO.Clear();
                txt_UrunAd.Clear();
                txt_UrunF.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
