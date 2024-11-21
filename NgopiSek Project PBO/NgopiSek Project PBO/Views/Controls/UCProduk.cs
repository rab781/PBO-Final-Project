using NgopiSek_Project_PBO.App.Contexts;
using NgopiSek_Project_PBO.Views.Forms;

namespace NgopiSek_Project_PBO.Views.Controls
{
    public partial class UCProduk : UserControl
    {
        public UCProduk()
        {
            InitializeComponent();
            Load += UCProduk_Load;
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
                        using (var updateForm = new EditProduk())
                        {
                            if (updateForm.ShowDialog() == DialogResult.OK)
                            {
                                LoadDataProduk();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error handling update action: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahProduk tambahProduk = new TambahProduk();
            tambahProduk.Show();
        }
    }
}
