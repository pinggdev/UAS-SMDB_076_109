/*
 * Created by SharpDevelop.
 * User: COMPUTER
 * Date: 2/2/2021
 * Time: 4:09 PM
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
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			try {
				MySqlConnection koneksi = new MySqlConnection("Server = localhost; Database = uas_smdb; Uid= root");
				MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from admin where username = '"+username.Text+"' and password = '"+password.Text+"'", koneksi);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				if(dt.Rows[0][0].ToString()=="1") {
					this.Hide();
					home hm = new home();
					hm.Show();
				} else {
					MessageBox.Show("username dan password salah!");
				}
			} 
			catch (Exception ex) {
				MessageBox.Show("Terjadi Kesalahan!");
			}
		}
	}
}
