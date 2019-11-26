using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDelegate
{
    public partial class HasilPerhitungan : Form
    {
        public HasilPerhitungan()
        {
            InitializeComponent();
        }

        Calculator cal = new Calculator();

        public void Perhitungan(int a, string operasi, int b, int hasil)
        {
            if (cal.Operasi == "+")
            {
                listHasil.Items.Add(string.Format("Hasil Penjumlahan {0} {1} {2} = {3}", cal.NilaiA, cal.Operasi, cal.NilaiB, cal.Hasil));
            }
            else if (cal.Operasi == "-")
            {
                listHasil.Items.Add(string.Format("Hasil Pengurangan {0} {1} {2} = {3}", cal.NilaiA, cal.Operasi, cal.NilaiB, cal.Hasil));
            }
            else if (cal.Operasi == "*")
            {
                listHasil.Items.Add(string.Format("Hasil Perkalian {0} {1} {2} = {3}", cal.NilaiA, cal.Operasi, cal.NilaiB, cal.Hasil));
            }
            else if (cal.Operasi == "/")
            {
                listHasil.Items.Add(string.Format("Hasil Pembagian {0} {1} {2} = {3}", cal.NilaiA, cal.Operasi, cal.NilaiB, cal.Hasil));
            }

        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            Perhitungan htng = new Perhitungan();
            htng.Add += Perhitungan;
            htng.ShowDialog();
        }

        private void ListHasil_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
