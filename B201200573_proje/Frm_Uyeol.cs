using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace B201200573_proje
{
    public partial class Frm_Uyeol : Form
    {
        public Frm_Uyeol()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.UyeOl_cs cs = new Classes.UyeOl_cs();
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                
                cs.Uye_ekle(textBox2.Text, textBox1.Text, textBox3.Text);
                MessageBox.Show("Uye olundu Teşkkürler");
                this.Close();
            }
            else
            {
                MessageBox.Show("Uye adı ve Uye şifre boş doldurmalısınız..");
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Girisyap f = new Frm_Girisyap();
            f.ShowDialog();
            
        }
    }
}
