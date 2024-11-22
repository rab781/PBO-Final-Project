using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgopiSek_Project_PBO.Views.Forms
{
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }
        private int totalHarga = 0;

        private void katalog()
        {
            for (int i = 0; i < 30; i++)
            {
                GroupBox box = new GroupBox()
                {
                    Width = 160,
                    Height = 330,
                    Margin = new Padding(20),
                    BackColor = Color.Transparent,

                };
                PictureBox picture = new PictureBox()
                {
                    Width = 160,
                    Height = 150,
                    SizeMode = PictureBoxSizeMode.AutoSize,


                };
                picture.Image = Image.FromFile("C:/Users/user/Downloads/image 12 (1).png");
                box.Controls.Add(picture);
                // ------------------------------ Nama Produk ----------------------------
                Label namaProduk = new Label()
                {
                    Location = new Point(1, 205),
                    Font = new Font("Poppins", 13, FontStyle.Regular),
                    ForeColor = ColorTranslator.FromHtml("#000000"),
                    Width=160,
                    Height=50

                    


                };
                namaProduk.Text = "Americano";
                // -------------------------------- Nama Kategori -------------------------
                Label kategori = new Label()
                {
                    Font = new Font("Arial", 11),
                    Location = new Point(1, 244),
                    ForeColor = ColorTranslator.FromHtml("#828282"),
                };
                kategori.Text = "Coffe";
                Button tambahProduk = new Button()
                {
                    Location = new Point(120, 280),
                    Width = 40,
                    Height = 40,
                    BackgroundImage = Image.FromFile("C:/Users/user/Downloads/Button Add.png"),
                    BackgroundImageLayout = ImageLayout.Stretch


                };
                Label hargaProduk = new Label()
                {
                    Font = new Font("Arial", 11),
                    Location = new Point(1, 289),
                    ForeColor = ColorTranslator.FromHtml("#000000"),
                };
                hargaProduk.Text = "Rp";
                Label Harga_Produk = new Label()
                {
                    Font = new Font("Arial", 11),
                    Location = new Point(40, 289),
                    ForeColor = ColorTranslator.FromHtml("#000000"),
                    Width=80

                };
                Harga_Produk.Text = "20000";
                box.Controls.Add(Harga_Produk);
                box.Controls.Add(hargaProduk);
                box.Controls.Add(tambahProduk);
                box.Controls.Add(kategori);
                box.Controls.Add(namaProduk);
                box.Location = new Point(box.Location.X, box.Location.Y);
                flowLayoutPanel1.Controls.Add(box);
                tambahProduk.Click += (sender, e) =>
                {
                    // Ambil harga dari label dan tambahkan ke total harga
                    int harga = int.Parse(Harga_Produk.Text);
                    totalHarga += harga;
                    subtotal.Text = $"Rp. {totalHarga}";
                    total.Text = $"Rp. {totalHarga}";

                };
            }

        }
        private void ChangeButtonColor(Button clickedButton)
        {
            if (lastClickedButton != null && lastClickedButton != clickedButton)
            {
                lastClickedButton.BackColor = Color.White;
            }
            clickedButton.BackColor = Color.FromArgb(186, 115, 55);
            lastClickedButton = clickedButton;
        }
        private Button lastChangeButton;
        private void ChangeButton(Button button)
        {
            if (lastChangeButton != null && lastChangeButton != button)
            {
                lastChangeButton.BackColor = Color.White;
            }
            button.BackColor = Color.FromArgb(186, 115, 55);
            lastChangeButton = button;
        }
        private Button lastClickedButton;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void all_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(all);
            katalog();
        }

        private void noncoffe_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(noncoffe);
            katalog();
        }

        private void snack_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(snack);
            katalog();
        }

        private void dessert_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(dessert);
            katalog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            totalHarga = 0;
            subtotal.Text = $"Rp. {totalHarga}";
            total.Text = $"Rp. {totalHarga}";
        }

        private void dinin_Click(object sender, EventArgs e)
        {
            ChangeButton(dinin);
        }

        private void takeaway_Click(object sender, EventArgs e)
        {
            ChangeButton(takeaway);
        }
    }
}
