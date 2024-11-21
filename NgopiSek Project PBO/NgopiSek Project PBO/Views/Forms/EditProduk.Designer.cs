namespace NgopiSek_Project_PBO.Views.Forms
{
    partial class EditProduk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancel = new Button();
            btnSave = new Button();
            comboKategori = new ComboBox();
            label5 = new Label();
            textStokProduk = new TextBox();
            label4 = new Label();
            textHargaProduk = new TextBox();
            label3 = new Label();
            textNamaProduk = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(282, 731);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(176, 56);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(186, 115, 55);
            btnSave.Font = new Font("Poppins SemiBold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(87, 731);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(176, 56);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // comboKategori
            // 
            comboKategori.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(84, 608);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(685, 64);
            comboKategori.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(84, 563);
            label5.Name = "label5";
            label5.Size = new Size(118, 42);
            label5.TabIndex = 18;
            label5.Text = "Kategori";
            // 
            // textStokProduk
            // 
            textStokProduk.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textStokProduk.Location = new Point(84, 468);
            textStokProduk.Name = "textStokProduk";
            textStokProduk.Size = new Size(685, 55);
            textStokProduk.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(84, 423);
            label4.Name = "label4";
            label4.Size = new Size(155, 42);
            label4.TabIndex = 16;
            label4.Text = "Stok Produk";
            // 
            // textHargaProduk
            // 
            textHargaProduk.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textHargaProduk.Location = new Point(84, 333);
            textHargaProduk.Name = "textHargaProduk";
            textHargaProduk.Size = new Size(685, 55);
            textHargaProduk.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(84, 288);
            label3.Name = "label3";
            label3.Size = new Size(179, 42);
            label3.TabIndex = 14;
            label3.Text = "Harga Produk";
            // 
            // textNamaProduk
            // 
            textNamaProduk.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNamaProduk.Location = new Point(84, 202);
            textNamaProduk.Name = "textNamaProduk";
            textNamaProduk.Size = new Size(685, 55);
            textNamaProduk.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 157);
            label2.Name = "label2";
            label2.Size = new Size(179, 42);
            label2.TabIndex = 12;
            label2.Text = "Nama Produk";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 50);
            label1.Name = "label1";
            label1.Size = new Size(309, 84);
            label1.TabIndex = 11;
            label1.Text = "Edit Produk";
            // 
            // EditProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(978, 844);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(comboKategori);
            Controls.Add(label5);
            Controls.Add(textStokProduk);
            Controls.Add(label4);
            Controls.Add(textHargaProduk);
            Controls.Add(label3);
            Controls.Add(textNamaProduk);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProduk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private ComboBox comboKategori;
        private Label label5;
        private TextBox textStokProduk;
        private Label label4;
        private TextBox textHargaProduk;
        private Label label3;
        private TextBox textNamaProduk;
        private Label label2;
        private Label label1;
    }
}