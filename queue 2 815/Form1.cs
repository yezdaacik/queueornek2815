using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queue_2_815
{
    public partial class Form1 : Form
    {
        Queue<String> musteri = new Queue<String>();
        public Form1()
        {
            InitializeComponent();
        }
        private void musteriCagir (Label lbl)
        {
            if (musteri.Count > 0)
            {
                lbl.Text = musteri.Dequeue();
            }
            else
            {
                MessageBox.Show("Müsteri yok.");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteri.Enqueue(txtAd.Text);
        }

        private void btnSira1_Click(object sender, EventArgs e)
        {
            musteriCagir(lblSira1);
        }

        private void btnSira2_Click(object sender, EventArgs e)
        {
            musteriCagir(lblSira2);
        }

        private void btnSira3_Click(object sender, EventArgs e)
        {
            musteriCagir(lblSira3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musteri.Enqueue("Yezda");
            musteri.Enqueue("Nursevim");
            musteri.Enqueue("Hilal");
            musteri.Enqueue("Ravza");
        }
    }
}
