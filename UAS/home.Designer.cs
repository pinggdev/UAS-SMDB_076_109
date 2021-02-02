/*
 * Created by SharpDevelop.
 * User: COMPUTER
 * Date: 2/2/2021
 * Time: 4:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UAS
{
	partial class home
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.nim = new System.Windows.Forms.TextBox();
			this.nama = new System.Windows.Forms.TextBox();
			this.kom = new System.Windows.Forms.TextBox();
			this.lab = new System.Windows.Forms.TextBox();
			this.totalNilai = new System.Windows.Forms.TextBox();
			this.btnTambah = new System.Windows.Forms.Button();
			this.btnUbah = new System.Windows.Forms.Button();
			this.btnHapus = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Daftar Nilai Lab 2";
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(23, 80);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(559, 446);
			this.dataGridView.TabIndex = 1;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCellContentClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(597, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "NIM";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(597, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nama";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(597, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Kom";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(597, 247);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Lab";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(597, 302);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "Total Nilai";
			// 
			// nim
			// 
			this.nim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nim.Location = new System.Drawing.Point(703, 77);
			this.nim.Name = "nim";
			this.nim.Size = new System.Drawing.Size(149, 26);
			this.nim.TabIndex = 7;
			// 
			// nama
			// 
			this.nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nama.Location = new System.Drawing.Point(703, 132);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(149, 26);
			this.nama.TabIndex = 8;
			// 
			// kom
			// 
			this.kom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kom.Location = new System.Drawing.Point(703, 189);
			this.kom.Name = "kom";
			this.kom.Size = new System.Drawing.Size(149, 26);
			this.kom.TabIndex = 9;
			// 
			// lab
			// 
			this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lab.Location = new System.Drawing.Point(703, 244);
			this.lab.Name = "lab";
			this.lab.Size = new System.Drawing.Size(149, 26);
			this.lab.TabIndex = 10;
			// 
			// totalNilai
			// 
			this.totalNilai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalNilai.Location = new System.Drawing.Point(703, 299);
			this.totalNilai.Name = "totalNilai";
			this.totalNilai.Size = new System.Drawing.Size(149, 26);
			this.totalNilai.TabIndex = 11;
			// 
			// btnTambah
			// 
			this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTambah.Location = new System.Drawing.Point(703, 356);
			this.btnTambah.Name = "btnTambah";
			this.btnTambah.Size = new System.Drawing.Size(149, 27);
			this.btnTambah.TabIndex = 12;
			this.btnTambah.Text = "Tambah";
			this.btnTambah.UseVisualStyleBackColor = true;
			this.btnTambah.Click += new System.EventHandler(this.BtnTambahClick);
			// 
			// btnUbah
			// 
			this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUbah.Location = new System.Drawing.Point(703, 404);
			this.btnUbah.Name = "btnUbah";
			this.btnUbah.Size = new System.Drawing.Size(149, 27);
			this.btnUbah.TabIndex = 13;
			this.btnUbah.Text = "Ubah";
			this.btnUbah.UseVisualStyleBackColor = true;
			this.btnUbah.Click += new System.EventHandler(this.BtnUbahClick);
			// 
			// btnHapus
			// 
			this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHapus.Location = new System.Drawing.Point(703, 452);
			this.btnHapus.Name = "btnHapus";
			this.btnHapus.Size = new System.Drawing.Size(149, 27);
			this.btnHapus.TabIndex = 14;
			this.btnHapus.Text = "Hapus";
			this.btnHapus.UseVisualStyleBackColor = true;
			this.btnHapus.Click += new System.EventHandler(this.BtnHapusClick);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(793, 30);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 23);
			this.label7.TabIndex = 15;
			this.label7.Text = "Keluar";
			this.label7.Click += new System.EventHandler(this.Label7Click);
			// 
			// home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnHapus);
			this.Controls.Add(this.btnUbah);
			this.Controls.Add(this.btnTambah);
			this.Controls.Add(this.totalNilai);
			this.Controls.Add(this.lab);
			this.Controls.Add(this.kom);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.nim);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.label1);
			this.Name = "home";
			this.Text = "home";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnHapus;
		private System.Windows.Forms.Button btnUbah;
		private System.Windows.Forms.Button btnTambah;
		private System.Windows.Forms.TextBox totalNilai;
		private System.Windows.Forms.TextBox lab;
		private System.Windows.Forms.TextBox kom;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.TextBox nim;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Label label1;
	}
}
