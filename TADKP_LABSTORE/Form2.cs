using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TADKP_LABSTORE
{
    public partial class Form2 : Form
    {
        int harga, total, total1, total2, total3, jumlah;    //deklarasikan atribut bertipe data interger
        int hargamerk = 0, hargaukuran = 0;      
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Yakin Akan Keluar?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(a==DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 open = new Form1();
            open.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1 gs = new Class1();          
            int merk1 = comboBox1.SelectedIndex;      //mengambil  Indeks item yang dipilih menjadi isi dari variabel merk 1
            int ukuran1 = comboBox2.SelectedIndex;   
            gs.setmerk(merk1); //set merk1 isi variabel merk   
            gs.setukuran(ukuran1);

            string merk = comboBox1.GetItemText(comboBox1.SelectedItem);    //seleksi item merk pada combobox1
            string ukuran = comboBox2.GetItemText(comboBox2.SelectedItem);

            jumlah = int.Parse(textBox2.Text);   

            switch(gs.getmerk())     //mengambil/memilih nilai atribut merk
            {
                case 0: hargamerk = 30000; break;
                case 1: hargamerk = 45000; break;
                case 2: hargamerk = 50000; break;
            }

            switch(gs.getukuran())    //mengambil/memilih nilai atribut ukuran
            {
                case 0: hargaukuran = 5000; break;
                case 1: hargaukuran = 8000; break;
                case 2: hargaukuran = 10000; break;
                case 3: hargaukuran = 15000;break; 
            }

            harga = hargamerk + hargaukuran;
            textBox1.Text = (" " + harga);

            total1 = harga * jumlah;
            textBox7.ScrollBars = ScrollBars.Vertical;    //setting textbox7 agar bisa di scrollbar

            if (string.IsNullOrWhiteSpace(textBox7.Text))  //apabila TextBox7 Harga kosong maka akan menampilkan
            {
                textBox7.Text = ("Gelas Beker" + "\r\n\r\nMerk\t: " + merk + "\r\nUkuran\t: " + ukuran + "\r\nJumlah\t: " + jumlah + "\r\nTotal\t: Rp. " + total1);
            }
            else
            {
                textBox7.Text += ("\r\n\r\n\r\nGelas Beker" + "\r\n\r\nMerk\t: " + merk + "\r\nUkuran\t: " + ukuran + "\r\nJumlah\t: " + jumlah + "\r\nTotal\t: Rp. " + total1);
            }
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Class1 gs = new Class1();
            int merk1 = comboBox3.SelectedIndex;
            int ukuran1 = comboBox4.SelectedIndex;
            gs.setmerk(merk1);
            gs.setukuran(ukuran1);

            string merk = comboBox3.GetItemText(comboBox3.SelectedItem);
            string ukuran = comboBox4.GetItemText(comboBox4.SelectedItem);

            jumlah = int.Parse(textBox4.Text);

            switch (gs.getmerk())
            {
                case 0: hargamerk = 20000; break;
                case 1: hargamerk = 30000; break;
                case 2: hargamerk = 40000; break;
            }

            switch (gs.getukuran())
            {
                case 0: hargaukuran = 3000; break;
                case 1: hargaukuran = 6000; break;
                case 2: hargaukuran = 8000; break;
                case 3: hargaukuran = 15000; break;
            }

            harga = hargamerk + hargaukuran;
            textBox3.Text = ("" + harga);

            total2 = harga * jumlah;
            textBox7.ScrollBars = ScrollBars.Vertical;    //setting textbox7 agar bisa di scrollbar
            if (string.IsNullOrWhiteSpace(textBox7.Text))  //apabila TextBox7 Harga kosong maka akan menampilkan
            {
                textBox7.Text = ("Gelas Ukur" + "\r\n\r\nMerk\t: " + merk + "\r\nUkuran\t: " + ukuran + "\r\nJumlah\t: " + jumlah + "\r\nTotal\t: Rp. " + total2);
            }
            else
            {
                textBox7.Text += ("\r\n\r\n\r\nGelas Ukur" + "\r\n\r\nMerk\t: " + merk + "\r\nUkuran\t: " + ukuran + "\r\nJumlah\t: " + jumlah + "\r\nTotal\t: Rp.  " + total2);
            }
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Class1 gs = new Class1();
            int merk1 = comboBox5.SelectedIndex;
            int ukuran1 = comboBox6.SelectedIndex;
            gs.setmerk(merk1);
            gs.setukuran(ukuran1);

            string merk = comboBox5.GetItemText(comboBox5.SelectedItem);
            string ukuran = comboBox6.GetItemText(comboBox6.SelectedItem);

            jumlah = int.Parse(textBox6.Text);

            switch (gs.getmerk())
            {
                case 0: hargamerk = 15000; break;
                case 1: hargamerk = 20000; break;
                case 2: hargamerk = 35000; break;
            }

            switch (gs.getukuran())
            {
                case 0: hargaukuran = 5000; break;
                case 1: hargaukuran = 7000; break;
                case 2: hargaukuran = 9000; break;
                case 3: hargaukuran = 15000; break;
            }

            harga = hargamerk + hargaukuran;
            textBox5.Text = ("" + harga);

            total3 = harga * jumlah;

             textBox7.ScrollBars = ScrollBars.Vertical;    //setting textbox7 agar bisa di scrollbar

            if (string.IsNullOrWhiteSpace(textBox7.Text))  //apabila TextBox7 Harga kosong maka akan menampilkan
            {
                textBox7.Text = ("Corong" + "\r\n\r\nMerk\t: " + merk + "\r\nUkuran\t: " + ukuran + "\r\nJumlah\t: " + jumlah + "\r\nTotal\t: Rp.  " + total3);
            }
            else
            {
                textBox7.Text += ("\r\n\r\n\r\nCorong" + "\r\n\r\nMerk\t: " + merk + "\r\nUkuran\t: " + ukuran + "\r\nJumlah\t: " + jumlah + "\r\nTotal\t: Rp. " + total3);
            }
            
        }
        private void button7_Click(object sender, EventArgs e)
        {
            total = total1 + total2 +total3;
            textBox7.Text += ("\r\n\r\n\r\n Total\t: Rp. " + total);
           
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
            comboBox4.ResetText();
            comboBox5.ResetText();
            comboBox6.ResetText();

            total = 0;
            total1 = 0;
            total2 = 0;
            total3 = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double kembali;
            string bayar;
            bayar = textBox9.Text;

            if (Convert.ToDouble(bayar) < total)
            {
                MessageBox.Show("Uangnya Kurang!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox9.Clear();            
            }
            else if (Convert.ToDouble(bayar)>total)
            {
                kembali = Convert.ToDouble(bayar) - total;
                textBox8.Text =("Rp. "+ kembali);
            }

            




        }


    }

}

