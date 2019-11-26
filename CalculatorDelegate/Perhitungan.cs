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
    public partial class Perhitungan : Form
    {
        public Perhitungan()
        {
            InitializeComponent();
        }

        public delegate void CreateEventHandler(int a, string operasi, int b, int hasil);
        public event CreateEventHandler Add;
        public event CreateEventHandler Remove;
        private bool isNewData = true;

        Calculator cal;


        private void BtnProses_Click_1(object sender, EventArgs e)
        {
            if (isNewData) cal = new Calculator();
            {
                Add(cal.NilaiA, cal.Operasi, cal.NilaiB, cal.Hasil);

                string op;
                int hasil, nilai1, nilai2;


                nilai1 = int.Parse(textNilaiA.Text);
                nilai2 = int.Parse(textNilaiB.Text);

                cal.NilaiA = nilai1;
                cal.NilaiB = nilai2;

                if (Operasi.SelectedIndex == -1)
                {
                    MessageBox.Show("Pilih Operasi !");
                }
                else if (Operasi.SelectedIndex == 0)
                {
                    op = "+";
                    hasil = nilai1 + nilai2;
                    hasil = cal.Hasil;
                    op = cal.Operasi;
                }
                else if (Operasi.SelectedIndex == 1)
                {
                    op = "-";
                    hasil = nilai1 - nilai2;
                    hasil = cal.Hasil;
                    op = cal.Operasi;
                }
                else if (Operasi.SelectedIndex == 2)
                {
                    op = "*";
                    hasil = nilai1 * nilai2;
                    hasil = cal.Hasil;
                    op = cal.Operasi;
                }
                else if(Operasi.SelectedIndex == 3)
                {
                    op = "/";
                    hasil = nilai1 / nilai2;
                    hasil = cal.Hasil;
                    op = cal.Operasi;
                }
            }
            

            else if()
            {
                Remove(Cal);
            }
        }
    }
}

