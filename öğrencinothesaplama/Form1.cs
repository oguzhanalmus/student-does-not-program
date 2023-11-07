using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace öğrencinothesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int matematikNot, fizikNot, biyolojiNot, turkceNot;
        double ortalama;
        string ogrenciAd, ogrenciSoyad;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            matematikNot = Convert.ToInt32(mmrmatematik.Value);
            fizikNot = Convert.ToInt32(mmrfizik.Value);
            biyolojiNot = Convert.ToInt32(mmrbiyoloji.Value);
            turkceNot = Convert.ToInt32(mmrturkce.Value);  

            if (ogrenciAd != "" && ogrenciSoyad != "") 
            {
                ogrenciAd = txtOgrenciAd.Text;
                ogrenciSoyad = txtOgrenciSoyadi.Text;

                ortalama = (matematikNot + fizikNot + biyolojiNot + turkceNot) / 4;
                liste.Items.Add(ogrenciAd + " " + ogrenciSoyad + " = " + ortalama.ToString("0.00"));

            }
            else 
            {
                MessageBox.Show("Öğrenci adı veya soyadı boş bırakılamaz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }

            
        }
    }
}
