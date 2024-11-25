namespace BTVN_Buoi3
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nguyễn Văn",
            "A",
            "123"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nguyễn Văn",
            "B",
            "456"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nguyễn Văn",
            "C",
            "789"}, -1);
            this.lv1 = new System.Windows.Forms.ListView();
            this.txtHo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ho = new System.Windows.Forms.TextBox();
            this.ten = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblHo = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv1
            // 
            this.lv1.CheckBoxes = true;
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.txtHo,
            this.txtTen,
            this.txtSDT});
            this.lv1.GridLines = true;
            this.lv1.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            this.lv1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv1.Location = new System.Drawing.Point(12, 62);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(219, 158);
            this.lv1.TabIndex = 0;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            // 
            // txtHo
            // 
            this.txtHo.Text = "Họ";
            this.txtHo.Width = 83;
            // 
            // txtTen
            // 
            this.txtTen.Text = "Tên";
            // 
            // txtSDT
            // 
            this.txtSDT.Text = "SĐT";
            // 
            // ho
            // 
            this.ho.Location = new System.Drawing.Point(274, 65);
            this.ho.Name = "ho";
            this.ho.Size = new System.Drawing.Size(158, 20);
            this.ho.TabIndex = 1;
            this.ho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ho.TextChanged += new System.EventHandler(this.ho_TextChanged);
            // 
            // ten
            // 
            this.ten.Location = new System.Drawing.Point(274, 112);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(158, 20);
            this.ten.TabIndex = 2;
            this.ten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(274, 156);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(158, 20);
            this.sdt.TabIndex = 3;
            this.sdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(261, 196);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(357, 196);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(299, 238);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(233, 68);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(21, 13);
            this.lblHo.TabIndex = 7;
            this.lblHo.Text = "Họ";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(233, 159);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(29, 13);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = "SĐT";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(233, 115);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(26, 13);
            this.lblTen.TabIndex = 9;
            this.lblTen.Text = "Tên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 310);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblHo);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.ho);
            this.Controls.Add(this.lv1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.ColumnHeader txtHo;
        private System.Windows.Forms.ColumnHeader txtTen;
        private System.Windows.Forms.ColumnHeader txtSDT;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox ho;
        private System.Windows.Forms.TextBox ten;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTen;
    }
}

