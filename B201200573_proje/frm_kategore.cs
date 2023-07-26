using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B201200573_proje
{
    public partial class frm_kategore : Form
    {
        public frm_kategore()
        {
            InitializeComponent();
        }
        Classes.Kategore_cs cs = new Classes.Kategore_cs();
        private void button1_Click(object sender, EventArgs e)
        {     
            if (textBox1.Text.Length != 0)
            {
                cs.Kategore_Ekle(textBox1.Text);
                MessageBox.Show("Kategori Eklendi.. ");
                textBox1.Clear();
                textBox1.Focus();
               dataGridView1.DataSource = cs.Kategore_Goster();
            }
            else {
                MessageBox.Show("Hiç bir şey eklenmedi.. ");
            }
        }

        private void frm_kategore_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cs.Kategore_Goster();
        }
    }
}
