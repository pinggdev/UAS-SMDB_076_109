/*
 * Created by SharpDevelop.
 * User: COMPUTER
 * Date: 2/2/2021
 * Time: 4:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace UAS
{
	/// <summary>
	/// Description of home.
	/// </summary>
	public partial class home : Form
	{
			MySqlConnection koneksi = new MySqlConnection("Server = localhost; Database = uas_smdb; Uid= root");
			MySqlCommand mycommand = new MySqlCommand();
			MySqlDataAdapter myadapter = new MySqlDataAdapter();	
			
		public home()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			tampilData();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void tampilData() {
			try{
				mycommand.Connection = koneksi;
				myadapter.SelectCommand=mycommand;
				mycommand.CommandText="select * from pratikan";
				DataSet ds = new DataSet();
					if (myadapter.Fill(ds,"dftpesan")>0) {
						dataGridView.DataSource = ds;
						dataGridView.DataMember = "dftpesan";
					}
						koneksi.Close();
			}
			catch (Exception ex) {
					MessageBox.Show(ex.ToString());
			}
		}
		
		void tambahData() {
			try {
				koneksi.Open();
				mycommand.Connection = koneksi;
				mycommand.CommandText = "insert into pratikan values('"+nim.Text+"', '"+nama.Text+"', '"+kom.Text+"', '"+lab.Text+"', '"+totalNilai.Text+"')";
				myadapter.SelectCommand = mycommand;
				if(mycommand.ExecuteNonQuery() == 1) {
					MessageBox.Show("Data berhasil dimasukkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
					tampilData();
				}
					koneksi.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		void ubahData() {
			try {
				koneksi.Open();
				mycommand.CommandText = "update pratikan set nim='"+nim.Text+"',nama='"+nama.Text+"',kom='"+kom.Text+"',lab='"+lab.Text+"',totalNilai='"+totalNilai.Text+"' where nim='"+nim.Text+"'";
				myadapter.SelectCommand = mycommand;
				if(mycommand.ExecuteNonQuery() == 1) {
					MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
					tampilData();
				}
					koneksi.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		void hapusData() {
			try {
				koneksi.Open();
				mycommand.CommandText = "delete from pratikan where nim = '"+nim.Text+"'";
				myadapter.SelectCommand = mycommand;
				if(mycommand.ExecuteNonQuery() == 1) {
					MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
					tampilData();
				}
					koneksi.Close();
			} catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		
		void DataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			nim.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
			nama.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
			kom.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
			lab.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
			totalNilai.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
		}
		
		
		
		void BtnTambahClick(object sender, EventArgs e)
		{
			tambahData();
		}
		
		void BtnUbahClick(object sender, EventArgs e)
		{
			ubahData();
		}

				
		void BtnHapusClick(object sender, EventArgs e)
		{
			hapusData();
		}
		
		void Label7Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm MF = new MainForm();
			MF.Show();
		}

	
		


	}
}
