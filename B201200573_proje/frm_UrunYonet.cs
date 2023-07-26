using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B201200573_proje
{
    public partial class frm_UrunYonet : Form
    {
        public frm_UrunYonet()
        {
            InitializeComponent();
        }
        Classes.Urun_cs uryo = new Classes.Urun_cs();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frm_UrunYonet_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = uryo.Urun_goster();
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.urunEkleToolStripMenuItem.PerformClick();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = uryo.AramaIslem(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçtiğiniz urun silmek istiyormusunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                uryo.SilmeIslem(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                dataGridView1.DataSource = uryo.Urun_goster();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçtiğiniz urun güncellemek istiyormusunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            uryo.GuncellemeISlem(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),dataGridView1.CurrentRow.Cells[1].Value.ToString(),Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value),dataGridView1.CurrentRow.Cells[4].Value.ToString());
            dataGridView1.DataSource = uryo.Urun_goster();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
