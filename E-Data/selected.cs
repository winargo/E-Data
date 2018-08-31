﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using E_Data.Properties;

namespace E_Data
{
    public partial class selected : Form
    {

        public int editing = 0;
        public string nacust = "";
        public string alacust = "";
        public string prcust = "";
        public string hpccust = "";
        public string nstcust = "";
        public string nkacust = "";
        public string tecust = "";
        public string tekncust = "";
        public string ketecust = "";
        public DateTime cust ;
        public string facust = "";

        public selected()
        {
            InitializeComponent();
        }

        private void selected_Load(object sender, EventArgs e)
        {
            if (mainmenu.idcustomer.Equals(""))
            {
                this.Close();
            }
            else {

                using (var connection1 = new SqlConnection("Server=" + Settings.Default.server + ";" +
                                                           "Trusted_Connection=yes;" +
                                                           "user id=" + Settings.Default.username + "; " +
                                                           "password=" + Settings.Default.password + "; " +
                                                           "database=" + Settings.Default.database + "; " +
                                                           "connection timeout=20"))
                {
                    SqlDataAdapter cmd = new SqlDataAdapter();
                    using (var checkCommand = new SqlCommand("select * from customer where id = '" + mainmenu.idcustomer + "'"))
                    {

                        checkCommand.Connection = connection1;
                        cmd.InsertCommand = checkCommand;
                        //.....
                        connection1.Open();

                        SqlDataReader a = checkCommand.ExecuteReader();

                        int count = 0;

                        while (a.Read()) {
                            count++;
                            ncust.Text = a["nama_customer"].ToString();
                            alcust.Text = a["alamat_customer"].ToString();
                            tcust.Text = a["no_telepon"].ToString();
                            nscust.Text = a["no_stb"].ToString();
                            nkcust.Text = a["no_kartu"].ToString();
                            hpcust.Text = a["no_handphone"].ToString();
                            fcust.Text = a["no_fax"].ToString();
                            pcust.Text = a["produk_customer"].ToString();
                            tekcust.Text = a["teknisi_customer"].ToString();
                            ketcust.Text = a["keterangan"].ToString();
                            dtptek.Value = (DateTime) a["tanggal_pasang"];
                        }

                        if (count > 0)
                        {


                        }
                        else {
                            MessageBox.Show("Deleted","Refresh data search !!");
                                this.Close();
                        }

                    }
                }
            }
        }

        private void kosong_Click(object sender, EventArgs e)
        {
            editing = 1;

            button1.Enabled = false;
            Print.Text = "Simpan";

            kosong.Text = "Editing...";

            kosong.Enabled = false;

            nacust = ncust.Text;
            alacust = alcust.Text;
            tecust = tcust.Text;
            hpccust = hpcust.Text;
            facust = fcust.Text;
            nstcust = nscust.Text;
            nkacust = nkcust.Text;
            prcust =pcust.Text;
            tekncust = tekcust.Text;
            cust = dtptek.Value;
            ketecust = ketcust.Text;

            ncust.Text = nacust;
            alcust.Text = alacust;
            tcust.Text = tecust;
            hpcust.Text = hpccust;
            fcust.Text = facust;
            nscust.Text = nstcust;
            nkcust.Text = nkacust;
            pcust.Text = prcust;
            tekcust.Text = tekncust;
            dtptek.Value = cust;
            ketcust.Text = ketecust;

            ncust.ReadOnly = false;
            tcust.ReadOnly = false;
            alcust.ReadOnly = false;
            hpcust.ReadOnly = false;
            nscust.ReadOnly = false;
            nkcust.ReadOnly = false;
            fcust.ReadOnly = false;
            pcust.ReadOnly = false;
            tekcust.ReadOnly = false;
            dtptek.Enabled = true;
            ketcust.ReadOnly = false;

        }

        private void batal_Click(object sender, EventArgs e)
        {
            if (editing == 1)
            {
                editing = 0;

                button1.Enabled = true;
                Print.Text = "Print";

                kosong.Text = "Edit";

                kosong.Enabled = true;

                ncust.Text = nacust;
                alcust.Text = alacust;
                tcust.Text = tecust;
                hpcust.Text = hpccust;
                fcust.Text = facust;
                nscust.Text = nstcust;
                nkcust.Text = nkacust;
                pcust.Text = prcust;
                tekcust.Text = tekncust;
                dtptek.Value = cust;
                ketcust.Text = ketecust;



                ncust.ReadOnly = true;
                tcust.ReadOnly = true;
                alcust.ReadOnly = true;
                nscust.ReadOnly = true;
                nkcust.ReadOnly = true;
                hpcust.ReadOnly = true;
                fcust.ReadOnly = true;
                pcust.ReadOnly = true;
                tekcust.ReadOnly = true;
                dtptek.Enabled = false;
                ketcust.ReadOnly = true;
            }
            else {
                mainmenu.idcustomer = "";
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin untuk hapus data ini ?", "Perhatian", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (var connection1 = new SqlConnection("Server=" + Settings.Default.server + ";" +
                                       "Trusted_Connection=yes;" +
                                       "user id=" + Settings.Default.username + "; " +
                                       "password=" + Settings.Default.password + "; " +
                                       "database=" + Settings.Default.database + "; " +
                                       "connection timeout=20"))
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter();
                        using (var insertCommand = new SqlCommand("delete from customer where ID = '"+mainmenu.idcustomer+"'"))
                        {

                            insertCommand.Connection = connection1;
                            cmd.InsertCommand = insertCommand;
                            //.....
                            connection1.Open();

                            int b = insertCommand.ExecuteNonQuery();

                            if (b == 0)
                            {

                            }
                            else if (b == 1)
                            {
                                mainmenu.idcustomer = "";
                                MessageBox.Show("Data dihapus", "Terhapus");
                                this.Close();
                            }



                            // .... you don't need to close the connection explicitely
                        }
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString(), "Error Occured");
                }
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }

        private void Print_Click(object sender, EventArgs e)
        {
            if (editing == 1)
            {
                if (ncust.Text.ToString().Equals(""))
                {
                    info.Text = "Info : Nama Customer Kosong";
                    info.ForeColor = System.Drawing.Color.Red;
                }
                else {
                    if (alcust.Text.ToString().Equals(""))
                    {
                        info.Text = "Info : Data Alamat Kosong";
                        info.ForeColor = System.Drawing.Color.Red;
                    }
                    else {
                        if (tcust.Text.ToString().Equals("") || hpcust.Text.ToString().Equals(""))
                        {
                            info.Text = "Info : Data No hp / Telepon Tidak Lengkap";
                            info.ForeColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            if (nscust.Text.ToString().Equals(""))
                            {
                                info.Text = "Info : Data No STB Tidak Lengkap";
                                info.ForeColor = System.Drawing.Color.Red;
                            }
                            else {
                                if (nkcust.Text.ToString().Equals(""))
                                {
                                    info.Text = "Info : Data No Kartu Tidak Lengkap";
                                    info.ForeColor = System.Drawing.Color.Red;
                                }
                                else {

                                    if (pcust.Text.ToString().Equals(""))
                                    {
                                        info.Text = "Info : Produk Customer Tidak diisi";
                                        info.ForeColor = System.Drawing.Color.Red;
                                    }
                                    else {
                                        if (tekcust.Text.ToString().Equals(""))
                                        {
                                            info.Text = "Info : Teknisi Customer Tidak Lengkap";
                                            info.ForeColor = System.Drawing.Color.Red;
                                        }
                                        else {
                                            if (Settings.Default.server.Equals(""))
                                            {
                                                mysqlform forms = new mysqlform();
                                                forms.ShowDialog();
                                            }
                                            else {
                                                try
                                                {
                                                    using (var connection1 = new SqlConnection("Server=" + Settings.Default.server + ";" +
                                                                       "Trusted_Connection=yes;" +
                                                                       "user id=" + Settings.Default.username + "; " +
                                                                       "password=" + Settings.Default.password + "; " +
                                                                       "database=" + Settings.Default.database + "; " +
                                                                       "connection timeout=20"))
                                                    {
                                                        SqlDataAdapter cmd = new SqlDataAdapter();
                                                        using (var checkCommand = new SqlCommand("select * from customer where nama_customer = '" + ncust.Text.ToString() + "'"))
                                                        {

                                                            checkCommand.Connection = connection1;
                                                            cmd.InsertCommand = checkCommand;
                                                            //.....
                                                            connection1.Open();

                                                            SqlDataReader a = checkCommand.ExecuteReader();

                                                            int b = 0;

                                                            while (a.Read())
                                                            {
                                                                b++;
                                                            }



                                                            if (b > 0)
                                                            {
                                                                DialogResult dialogResult = MessageBox.Show("Data " + ncust.Text.ToString() + " sudah pernah diregistrasi, masukkan data yang sama ? (Direkomendasi nama dengan angka belakang untuk identifikasi lebih mudah)", "Data Duplikat Terdeteksi", MessageBoxButtons.YesNo);
                                                                if (dialogResult == DialogResult.Yes)
                                                                {
                                                                    connection1.Close();
                                                                    a.Close();

                                                                    cmd = new SqlDataAdapter();
                                                                    using (var insertCommand = new SqlCommand("update customer set nama_customer='" + ncust.Text.ToString() + "',alamat_customer='" + alcust.Text.ToString() + "',no_telepon='" + tcust.Text.ToString() + "',no_handphone='" + hpcust.Text.ToString() + "',no_fax='" + fcust.Text.ToString() + "',no_stb='"+nscust.Text.ToString()+"',no_kartu='"+nkcust.Text.ToString()+"',produk_customer='" + pcust.Text.ToString() + "',teknisi_customer='" + tekcust.Text.ToString() + "',keterangan='" + ketcust.Text.ToString() + "',tanggal_pasang='" + dtptek.Value.ToString() + "' where ID = '" + mainmenu.idcustomer + "'"))
                                                                    {

                                                                        insertCommand.Connection = connection1;
                                                                        cmd.InsertCommand = insertCommand;
                                                                        //.....
                                                                        connection1.Open();

                                                                        int c = insertCommand.ExecuteNonQuery();

                                                                        if (c == 0)
                                                                        {

                                                                        }
                                                                        else if (c == 1)
                                                                        {
                                                                            mainmenu.idcustomer = "";
                                                                            info.Text = "Data diedit";
                                                                            info.ForeColor = System.Drawing.Color.Green;

                                                                            editing = 0;

                                                                            button1.Enabled = true;
                                                                            Print.Text = "Print";

                                                                            kosong.Text = "Edit";

                                                                            kosong.Enabled = true;

                                                                            ncust.ReadOnly = true;
                                                                            tcust.ReadOnly = true;
                                                                            alcust.ReadOnly = true;
                                                                            nscust.ReadOnly = true;
                                                                            nkcust.ReadOnly = true;
                                                                            hpcust.ReadOnly = true;
                                                                            fcust.ReadOnly = true;
                                                                            pcust.ReadOnly = true;
                                                                            tekcust.ReadOnly = true;
                                                                            dtptek.Enabled = false;
                                                                            ketcust.ReadOnly = true;
                                                                        }



                                                                        // .... you don't need to close the connection explicitely
                                                                    }
                                                                    //do something
                                                                }
                                                                else if (dialogResult == DialogResult.No)
                                                                {
                                                                    connection1.Close();
                                                                    a.Close();
                                                                    //do something else
                                                                }
                                                            }
                                                            else if (b == 0)
                                                            {
                                                                connection1.Close();
                                                                a.Close();
                                                                cmd = new SqlDataAdapter();
                                                                using (var insertCommand = new SqlCommand("update customer set nama_customer='" + ncust.Text.ToString() + "',alamat_customer='" + alcust.Text.ToString() + "',no_telepon='" + tcust.Text.ToString() + "',no_handphone='" + hpcust.Text.ToString() + "',no_fax='" + fcust.Text.ToString() + "',no_stb='" + nscust.Text.ToString() + "',no_kartu='" + nkcust.Text.ToString() + "',produk_customer='" + pcust.Text.ToString() + "',teknisi_customer='" + tekcust.Text.ToString() + "',keterangan='" + ketcust.Text.ToString() + "',tanggal_pasang='" + dtptek.Value.ToString() + "' where ID = '" + mainmenu.idcustomer + "'"))
                                                                {

                                                                    insertCommand.Connection = connection1;
                                                                    cmd.InsertCommand = insertCommand;
                                                                    //.....
                                                                    connection1.Open();

                                                                    int d = insertCommand.ExecuteNonQuery();

                                                                    if (d == 0)
                                                                    {

                                                                    }
                                                                    else if (d == 1)
                                                                    {
                                                                        mainmenu.idcustomer = "";
                                                                        info.Text = "Data diedit";
                                                                        info.ForeColor = System.Drawing.Color.Green;

                                                                        editing = 0;

                                                                        button1.Enabled = true;
                                                                        Print.Text = "Print";

                                                                        kosong.Text = "Edit";

                                                                        kosong.Enabled = true;

                                                                        ncust.ReadOnly = true;
                                                                        tcust.ReadOnly = true;
                                                                        alcust.ReadOnly = true;
                                                                        hpcust.ReadOnly = true;
                                                                        nscust.ReadOnly = true;
                                                                        nkcust.ReadOnly = true;
                                                                        fcust.ReadOnly = true;
                                                                        pcust.ReadOnly = true;
                                                                        tekcust.ReadOnly = true;
                                                                        dtptek.Enabled = false;
                                                                        ketcust.ReadOnly = true;
                                                                    }



                                                                    // .... you don't need to close the connection explicitely
                                                                }

                                                            }
                                                            // .... you don't need to close the connection explicitely
                                                        }

                                                    }
                                                }
                                                catch (Exception dataexcp)
                                                {
                                                    MessageBox.Show(dataexcp.ToString(), "Error On SQL Connection");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                
            }
            else {
                print();
            }
        }

        private void print() {

        }
    }
}
