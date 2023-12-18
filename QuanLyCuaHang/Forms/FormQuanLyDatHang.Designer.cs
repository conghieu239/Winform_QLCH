namespace QuanLyCuaHang.Forms
{
    partial class FormQuanLyDatHang
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
            this.pnlNhap = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDonDat = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDat)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNhap
            // 
            this.pnlNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNhap.Controls.Add(this.label1);
            this.pnlNhap.Controls.Add(this.dgvDonDat);
            this.pnlNhap.Controls.Add(this.btnXem);
            this.pnlNhap.Controls.Add(this.btnXoa);
            this.pnlNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNhap.Location = new System.Drawing.Point(0, 61);
            this.pnlNhap.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNhap.Name = "pnlNhap";
            this.pnlNhap.Size = new System.Drawing.Size(986, 531);
            this.pnlNhap.TabIndex = 21;
            this.pnlNhap.Tag = "Nhập";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách đơn đặt hàng";
            // 
            // dgvDonDat
            // 
            this.dgvDonDat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDonDat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDonDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonDat.Location = new System.Drawing.Point(148, 71);
            this.dgvDonDat.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDonDat.Name = "dgvDonDat";
            this.dgvDonDat.RowHeadersWidth = 51;
            this.dgvDonDat.RowTemplate.Height = 24;
            this.dgvDonDat.Size = new System.Drawing.Size(605, 256);
            this.dgvDonDat.TabIndex = 5;
            // 
            // btnXem
            // 
            this.btnXem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(133)))));
            this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(149, 362);
            this.btnXem.Margin = new System.Windows.Forms.Padding(2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(55, 26);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(133)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(226, 362);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(55, 26);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(133)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(986, 61);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quản lý đặt hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormQuanLyDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 592);
            this.Controls.Add(this.pnlNhap);
            this.Controls.Add(this.label2);
            this.Name = "FormQuanLyDatHang";
            this.Text = "FormQuanLyDatHang";
            this.pnlNhap.ResumeLayout(false);
            this.pnlNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNhap;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvDonDat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
    }
}