﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon_new
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmyenimüşteri fr=new frmyenimüşteri();
            fr.Show();
        }

        /*private void button4_Click(object sender, EventArgs e)
        {
          FrmMusteriler fr =new FrmMusteriler();
            fr.Show();
        }*/

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayçiçeği Pansiyon Kayıt Uygulaması /2022 - Çorum");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar fr =new FrmOdalar();
            fr.Show();
        }
    }
}
