﻿using NgopiSek_Desktop_App_V2.App.Contexts;
using NgopiSek_Desktop_App_V2.App.Models;
using NgopiSek_Desktop_App_V2.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgopiSek_Desktop_App_V2.Views.Controls.Admin
{
    public partial class UCProduct : UserControl
    {
        public UCProduct()
        {
            InitializeComponent();
            Load += UCProduk_Load;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product_Form formProduct = new Product_Form();
            formProduct.Show();
        }

        private void dataGridProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridProduct.Columns["Update"].Index)
            {
                try
                {
                    var idProduk = Convert.ToInt32(dataGridProduct.Rows[e.RowIndex].Cells["id_produk"].Value);
                    var productData = ProductContext.GetProdukById(idProduk);

                    if (productData.Rows.Count > 0)
                    {
                        var produk = new M_Produk
                        {
                            id_produk = idProduk,
                            nama_produk = productData.Rows[0]["nama_produk"].ToString(),
                            harga_produk = Convert.ToInt32(productData.Rows[0]["harga_produk"]),
                            stok_produk = Convert.ToInt32(productData.Rows[0]["stok_produk"]),
                            id_kategori = Convert.ToInt32(productData.Rows[0]["id_kategori"])
                        };

                        using (var updateForm = new Product_Form())
                        {
                            updateForm.PopulateForm(produk); // Isi form dengan data produk
                            updateForm.ShowDialog();

                            if (updateForm.DialogResult == DialogResult.OK)
                            {
                                LoadDataProduk(); // Refresh grid
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data produk tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error handling update action: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UCProduk_Load(object sender, EventArgs e)
        {
            dataGridProduct.DataBindingComplete += DataGridProduct_DataBindingComplete;
            LoadDataProduk();
        }

        private void LoadDataProduk()
        {
            try
            {
                dataGridProduct.AllowUserToAddRows = false;
                dataGridProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridProduct.ReadOnly = true;

                var dataProduk = ProductContext.All();

                if (dataProduk == null || dataProduk.Rows.Count == 0)
                {
                    MessageBox.Show("No product data available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridProduct.Columns.Clear();

                var nomorColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Nomor",
                    Name = "Nomor",
                    ReadOnly = true,
                    Width = 50
                };

                dataGridProduct.Columns.Add(nomorColumn);
                dataGridProduct.DataSource = dataProduk;

                CustomizeColumnHeaders();
                AddButtonColumn("Update", "Edit");
                AddRowNumbers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading product data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomizeColumnHeaders()
        {
            var hiddenColumns = new[] { "id_produk", "id_kategori" };

            foreach (DataGridViewColumn column in dataGridProduct.Columns)
            {
                if (hiddenColumns.Contains(column.Name))
                {
                    column.Visible = false;
                }
                else
                {
                    column.HeaderText = column.Name switch
                    {
                        "nama_produk" => "Nama Produk",
                        "harga_produk" => "Harga Produk",
                        "stok_produk" => "Stok Produk",
                        "nama_kategori" => "Nama Kategori",
                        _ => column.HeaderText
                    };
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }
        }

        private void AddRowNumbers()
        {
            if (dataGridProduct.Columns.Contains("Nomor"))
            {
                foreach (DataGridViewRow row in dataGridProduct.Rows)
                {
                    row.Cells["Nomor"].Value = row.Index + 1;
                }
            }
            else
            {
                MessageBox.Show("Kolom 'Nomor' tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridProduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AddRowNumbers();
        }

        private void AddButtonColumn(string columnName, string buttonText)
        {
            if (!dataGridProduct.Columns.Contains(columnName))
            {
                var buttonColumn = new DataGridViewButtonColumn
                {
                    Name = columnName,
                    HeaderText = columnName,
                    Text = buttonText,
                    UseColumnTextForButtonValue = true,
                    Width = 80
                };
                dataGridProduct.Columns.Add(buttonColumn);
            }
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            string searchText = textSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadDataProduk();               
            }

            try
            {
                var searchResults = ProductContext.SearchProduct(searchText);

                if (searchResults != null && searchResults.Rows.Count > 0)
                {
                    dataGridProduct.DataSource = searchResults;
                    if (!dataGridProduct.Columns.Contains("Nomor"))
                    {
                        var nomorColumn = new DataGridViewTextBoxColumn
                        {
                            HeaderText = "Nomor",
                            Name = "Nomor",
                            ReadOnly = true,
                            Width = 50
                        };
                        dataGridProduct.Columns.Insert(0, nomorColumn);
                    }

                    if (!dataGridProduct.Columns.Contains("Update"))
                    {
                        AddButtonColumn("Update", "Edit");
                    }

                    AddRowNumbers();
                }
                else
                {
                    MessageBox.Show("No product found matching your search.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataProduk();  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadDataProduk(); 
            }       
        }
    }
}
