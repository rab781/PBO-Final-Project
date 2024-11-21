using NgopiSek_Project_PBO.App.Contexts;
using NgopiSek_Project_PBO.App.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace NgopiSek_Project_PBO.Views.Forms
{
    public partial class TambahProduk : Form
    {
        public bool IsEditMode { get; set; } = false; // Default mode: Add
        public int ProductId { get; set; }           // ID produk untuk mode edit

        public TambahProduk()
        {
            InitializeComponent();
            UpdateButtonText();    // Set text tombol sesuai mode
            LoadCategoryData();    // Load kategori untuk combobox
        }

        // Event untuk tombol batal
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event untuk tombol simpan
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Input tidak valid. Harap isi semua data dengan benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Membuat objek produk berdasarkan input pengguna
            M_Produk produk = new M_Produk
            {
                nama_produk = textNamaProduk.Text,
                harga_produk = int.Parse(textHargaProduk.Text),
                stok_produk = int.Parse(textStokProduk.Text),
                id_kategori = (int)comboKategori.SelectedValue
            };

            try
            {
                if (IsEditMode)
                {
                    // Mode edit
                    produk.id_produk = ProductId;
                    ProductContext.UpdateProduct(produk); // Update produk di database
                    MessageBox.Show("Produk berhasil diperbarui!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Mode tambah
                    ProductContext.AddProduct(produk); // Tambahkan produk ke database
                    MessageBox.Show("Produk berhasil ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK; // Beri tahu form lain untuk refresh data
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validasi input pengguna
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textNamaProduk.Text) ||
                !int.TryParse(textHargaProduk.Text, out _) ||
                !int.TryParse(textStokProduk.Text, out _) ||
                comboKategori.SelectedIndex < 0)
            {
                return false;
            }
            return true;
        }

        // Bersihkan input setelah tambah produk
        private void ClearFields()
        {
            textNamaProduk.Clear();
            textHargaProduk.Clear();
            textStokProduk.Clear();
            comboKategori.SelectedIndex = -1;
        }

        // Load data kategori untuk ComboBox
        private void LoadCategoryData()
        {
            var dataKategori = ProductContext.GetAllCategories(); // Ambil data kategori dari database
            comboKategori.DisplayMember = "nama_kategori";
            comboKategori.ValueMember = "id_kategori";
            comboKategori.DataSource = dataKategori;
            comboKategori.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // Isi form dengan data produk (untuk mode edit)
        public void PopulateForm(M_Produk produk)
        {
            LoadCategoryData(); // Pastikan kategori terisi

            textNamaProduk.Text = produk.nama_produk;
            textHargaProduk.Text = produk.harga_produk.ToString();
            textStokProduk.Text = produk.stok_produk.ToString();
            comboKategori.SelectedValue = produk.id_kategori;
            IsEditMode = true;
            ProductId = produk.id_produk;

            UpdateButtonText(); // Sesuaikan tombol
        }

        // Ubah teks tombol simpan sesuai mode
        private void UpdateButtonText()
        {
            btnSimpan.Text = IsEditMode ? "Update" : "Tambah";
        }
    }
}
