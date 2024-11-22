namespace NgopiSek_Project_PBO.Views.Forms
{
    partial class Transaksi
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dessert = new Button();
            snack = new Button();
            noncoffe = new Button();
            all = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            button1 = new Button();
            delete = new Button();
            total = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            subtotal = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            takeaway = new Button();
            dinin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 161);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Logo_NgopiSek_Brown_Version;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(22, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 89);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(dessert);
            panel2.Controls.Add(snack);
            panel2.Controls.Add(noncoffe);
            panel2.Controls.Add(all);
            panel2.Location = new Point(0, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 900);
            panel2.TabIndex = 1;
            // 
            // dessert
            // 
            dessert.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dessert.Location = new Point(22, 446);
            dessert.Name = "dessert";
            dessert.Size = new Size(199, 62);
            dessert.TabIndex = 3;
            dessert.Text = "Dessert";
            dessert.UseVisualStyleBackColor = true;
            dessert.Click += dessert_Click;
            // 
            // snack
            // 
            snack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            snack.Location = new Point(22, 340);
            snack.Name = "snack";
            snack.Size = new Size(199, 62);
            snack.TabIndex = 2;
            snack.Text = "Snack";
            snack.UseVisualStyleBackColor = true;
            snack.Click += snack_Click;
            // 
            // noncoffe
            // 
            noncoffe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            noncoffe.Location = new Point(22, 236);
            noncoffe.Name = "noncoffe";
            noncoffe.Size = new Size(199, 62);
            noncoffe.TabIndex = 1;
            noncoffe.Text = "None Coffe";
            noncoffe.UseVisualStyleBackColor = true;
            noncoffe.Click += noncoffe_Click;
            // 
            // all
            // 
            all.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            all.Location = new Point(22, 46);
            all.Name = "all";
            all.Size = new Size(199, 77);
            all.TabIndex = 0;
            all.Text = "All";
            all.UseVisualStyleBackColor = true;
            all.Click += all_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.Control;
            flowLayoutPanel1.Location = new Point(248, 163);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1133, 1004);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(delete);
            panel3.Controls.Add(total);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(subtotal);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(takeaway);
            panel3.Controls.Add(dinin);
            panel3.Location = new Point(1382, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(538, 900);
            panel3.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(186, 115, 55);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(132, 712);
            button1.Name = "button1";
            button1.Size = new Size(351, 85);
            button1.TabIndex = 11;
            button1.Text = "Place Oder";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Transparent;
            delete.BackgroundImageLayout = ImageLayout.Zoom;
            delete.Image = Properties.Resources.Button_Cancel;
            delete.Location = new Point(36, 712);
            delete.Name = "delete";
            delete.Size = new Size(79, 85);
            delete.TabIndex = 10;
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 12F);
            total.Location = new Point(336, 663);
            total.Name = "total";
            total.Size = new Size(60, 32);
            total.TabIndex = 9;
            total.Text = "Rp.0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(34, 663);
            label4.Name = "label4";
            label4.Size = new Size(65, 32);
            label4.TabIndex = 8;
            label4.Text = "Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(336, 621);
            label3.Name = "label3";
            label3.Size = new Size(60, 32);
            label3.TabIndex = 7;
            label3.Text = "Rp.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(34, 621);
            label2.Name = "label2";
            label2.Size = new Size(47, 32);
            label2.TabIndex = 6;
            label2.Text = "Tax";
            // 
            // subtotal
            // 
            subtotal.AutoSize = true;
            subtotal.Font = new Font("Segoe UI", 12F);
            subtotal.Location = new Point(336, 570);
            subtotal.Name = "subtotal";
            subtotal.Size = new Size(60, 32);
            subtotal.TabIndex = 5;
            subtotal.Text = "Rp.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(34, 570);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 4;
            label1.Text = "Sub Total";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Image_Pesanan;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(39, 165);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(444, 380);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(39, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(444, 39);
            textBox1.TabIndex = 2;
            textBox1.Text = "Customer Name";
            // 
            // takeaway
            // 
            takeaway.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            takeaway.Location = new Point(301, 12);
            takeaway.Name = "takeaway";
            takeaway.Size = new Size(182, 70);
            takeaway.TabIndex = 1;
            takeaway.Text = "Take Away";
            takeaway.UseVisualStyleBackColor = true;
            takeaway.Click += takeaway_Click;
            // 
            // dinin
            // 
            dinin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dinin.Location = new Point(39, 12);
            dinin.Name = "dinin";
            dinin.Size = new Size(182, 70);
            dinin.TabIndex = 0;
            dinin.Text = "Din in";
            dinin.UseVisualStyleBackColor = true;
            dinin.Click += dinin_Click;
            // 
            // Transaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1898, 1050);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Transaksi";
            Text = " ";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button dessert;
        private Button snack;
        private Button noncoffe;
        private Button all;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private TextBox textBox1;
        private Button takeaway;
        private Button dinin;
        private Label label2;
        private Label subtotal;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button1;
        private Button delete;
        private Label total;
        private Label label4;
        private Label label3;
    }
}