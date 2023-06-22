﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    public partial class Form3 : Form
    {
        private string stringConnection = "data source=LAPTOP-JHEOJ82G\\ATTARFADHILAH;database=fakultas;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private string nim, nama, alamat, jk, prodi;
        private DateTime tgl;
        BindingSource customerBindingSource = new BindingSource();

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
        private void refreshform()
        {
            txtNIM.Enabled = false;
            txtNAMA.Enabled = false;
            cbxJenisKelamin.Enabled = false;
            txtALAMAT.Enabled = false;
            dtTanggalLahir.Enabled = false;
            cbxPRODI.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            clearBinding();
            formdata();
        }
        private void clearBinding()
        {
            this.txtNIM.DataBindings.Clear();
            this.txtNAMA.DataBindings.Clear();
            this.txtALAMAT.DataBindings.Clear();
            this.cbxJenisKelamin.DataBindings.Clear();
            this.dtTanggalLahir.DataBindings.Clear();
            this.cbxPRODI.DataBindings.Clear();
        }

        private void cbxPRODI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Prodicbx()
        {
            koneksi.Open();
            string str = "select nama_prodi from dbo.prodi";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxPRODI.DisplayMember = "nama_prodi";
            cbxPRODI.ValueMember = "id_prodi";
            cbxPRODI.DataSource = ds.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNIM.Text = "";
            txtNAMA.Text = "";
            txtALAMAT.Text = "";
            dtTanggalLahir.Value = DateTime.Today;
            txtNIM.Enabled = true;
            txtNAMA.Enabled = true;
            cbxJenisKelamin.Enabled = true;
            txtALAMAT.Enabled = true;
            dtTanggalLahir.Enabled = true;
            cbxPRODI.Enabled = true;
            Prodicbx();
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            nim = txtNIM.Text;
            nama = txtNAMA.Text;
            jk = cbxJenisKelamin.Text;
            alamat = txtALAMAT.Text;
            tgl = dtTanggalLahir.Value;
            prodi = cbxPRODI.Text;
            int hs = 0;
            koneksi.Open();
            string strs = "select id_prodi from dbo.prodi where nama_prodi = @dd";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@dd", prodi));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                hs = int.Parse(dr["id_prodi"].ToString());
            }
            dr.Close();
            string str = "insert into dbo.Mahasiswa (nim, nama_mahasiswa, Jenis_kelamin, Alamat, tgl_lahir, id_prodi)" + "values(@nim, @nama, @jk, @Alamat, @tgl, @idp)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("NIM", nim));
            cmd.Parameters.Add(new SqlParameter("nama", nama));
            cmd.Parameters.Add(new SqlParameter("jk", jk));
            cmd.Parameters.Add(new SqlParameter("Alamat", alamat));
            cmd.Parameters.Add(new SqlParameter("tgl", tgl));
            cmd.Parameters.Add(new SqlParameter("idp", hs));
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("data berhasil disimpan", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshform();
        }
        public Form3()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            this.bnMahasiswa.BindingSource = this.customerBindingSource;
            refreshform();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void formdata()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("select m.nim, m.nama_mahasiswa," +
                "m.alamat, m.jenis_kelamin, m.tgl_lahir, p.nama_prodi from dbo.mahasiswa m " +
                "join dbo.prodi p on m.id_prodi = p.id_prodi", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customerBindingSource.DataSource = ds.Tables[0];
            this.txtNIM.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "NIM", true));
            this.txtNAMA.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_mahasiswa", true));
            this.txtALAMAT.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "alamat", true));
            this.cbxJenisKelamin.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "jenis_kelamin", true));
            this.dtTanggalLahir.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "tgl_lahir", true));
            this.cbxPRODI.DataBindings.Add(
                new Binding("Text", this.customerBindingSource, "nama_prodi", true));
            koneksi.Close();
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
    }
}
