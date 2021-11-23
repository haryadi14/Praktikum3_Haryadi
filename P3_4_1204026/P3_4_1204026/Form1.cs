using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_4_1204026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelas = "";
            string jadwal = "";
            if (rbJadwal1.Checked)
            {
                jadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            else if (rbJadwal2.Checked)
            {
                jadwal = jadwal = "Selasa & Kamis, 14.00 - 16.00";

            }
            else if (rbJadwal3.Checked)
            {
                jadwal = jadwal = "Sabtu & Minggu, 09.00 - 11.00";

            }
            else if (rbJadwal4.Checked)
            {
                jadwal = jadwal = "Minggu, 13.00 - 17.00";

            }
            if (Biola.Checked)
            {
                kelas = kelas + "Biola, ";
            }

            if (Drum.Checked)
            {
                kelas = kelas + "Drum, ";
            }

            if (Saxophone.Checked)
            {
                kelas = kelas + "Saxophone, ";
            }

            if (Piano.Checked)
            {
                kelas = kelas + "Piano, ";
            }

            if (Gitar.Checked)
            {
                kelas = kelas + "Gitar, ";
            }

            if (Vokal.Checked)
            {
                kelas = kelas + "Vokal, ";
            }
            if (kelas == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas ", "Warning! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            {
                MessageBox.Show
                              ("Nama : " + txtNama.Text +
                              "\nJenis Kelamin : " + cbJK.Text +
                              "\nTanggal Lahir : " + dtTgl +
                              "\nPilihan Kelas : " + kelas +
                              "\nPilihan Jadwal: " + jadwal,
                              "Informasi Pendaftaran",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
