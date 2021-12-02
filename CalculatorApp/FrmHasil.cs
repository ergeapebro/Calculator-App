using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class FrmHasil : Form
    {
        public FrmHasil()
        {
            InitializeComponent();
        }

        private void Tampil(int operasi, int a, int b, int hasil)
        {
            char[] operasi_simbol = { '+', '-', 'x', '/' };
            string[] operasi_str = { "Penambahan", "Pengurangan", "Perkalian", "Pembagian" };
            lstHasil.Items.Add($"Hasil {(operasi_str[operasi]).ToLower()} {a} {operasi_simbol[operasi]} {b} = {hasil}");
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            FrmInputHitung frmInput = new FrmInputHitung();
            frmInput.hubung += Tampil; ;
            frmInput.ShowDialog();
        }
    }
}
