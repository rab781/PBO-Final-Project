namespace NgopiSek_Project_PBO.Views.Controls
{
    partial class UCTransaksi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridTransaksi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridTransaksi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 102);
            label1.Name = "label1";
            label1.Size = new Size(420, 127);
            label1.TabIndex = 31;
            label1.Text = "Transaksi";
            // 
            // dataGridTransaksi
            // 
            dataGridTransaksi.AllowUserToOrderColumns = true;
            dataGridTransaksi.AllowUserToResizeColumns = false;
            dataGridTransaksi.AllowUserToResizeRows = false;
            dataGridTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTransaksi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridTransaksi.BackgroundColor = Color.White;
            dataGridTransaksi.BorderStyle = BorderStyle.None;
            dataGridTransaksi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(186, 115, 55);
            dataGridViewCellStyle1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(186, 115, 55);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridTransaksi.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridTransaksi.EnableHeadersVisualStyles = false;
            dataGridTransaksi.GridColor = Color.White;
            dataGridTransaksi.Location = new Point(104, 260);
            dataGridTransaksi.Name = "dataGridTransaksi";
            dataGridTransaksi.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridTransaksi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridTransaksi.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridTransaksi.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridTransaksi.Size = new Size(1226, 833);
            dataGridTransaksi.TabIndex = 30;
            dataGridTransaksi.CellContentClick += dataGridTransaksi_CellContentClick;
            // 
            // UCTransaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(dataGridTransaksi);
            Name = "UCTransaksi";
            Size = new Size(1452, 1166);
            Load += UCTransaksi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridTransaksi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridTransaksi;
    }
}
