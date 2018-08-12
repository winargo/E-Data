using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using E_Data.Properties;
using System.Data.SqlClient;

namespace E_Data
{
    public partial class newdata : Form
    {
        public newdata()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Batal Input ?", "Info", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                info.Text = "Info : ";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void newdata_Load(object sender, EventArgs e)
        {
            dtptek.Format = DateTimePickerFormat.Custom;
            dtptek.CustomFormat = "dd - MM - yyyy";
            dtptek.Value = DateTime.Now;
        }

        private void kosong_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Kosongkan Data ?", "Info", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                ncust.Text = "";
                tcust.Text = "";
                hpcust.Text = "";
                ketcust.Text = "";
                alcust.Text = "";
                fcust.Text = "";
                tekcust.Text = "";
                dtptek.Value = DateTime.Now;
                pcust.Text = "";

                info.ForeColor = System.Drawing.Color.Green;
                info.Text = "Info : Data dikosongkan ";
            }
            else if (dialogResult == DialogResult.No)
            {
                info.Text = "Info : Pengosongan Dibatalkan ";
                info.ForeColor = System.Drawing.Color.Blue;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void simpan_Click(object sender, EventArgs e)
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
                                    SqlConnection myConnection = new SqlConnection("Server=" + Settings.Default.server + ";" +
                                                           "Trusted_Connection=yes;" +
                                                           "user id=" + Settings.Default.username + "; " +
                                                           "password=" + Settings.Default.password + "; " +
                                                           "database=" + Settings.Default.database + "; " +
                                                           "connection timeout=20");


                                    


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
                                            using (var insertCommand = new SqlCommand("insert into customer (ID,nama_customer,alamat_customer,no_telepon,no_handphone,no_fax,produk_customer,teknisi_customer,tanggal_pasang,create_date,keterangan) values('" + mainmenu.RandomString(499) + "','" + ncust.Text.ToString() + "','" + alcust.Text.ToString() + "','" + tcust.Text.ToString() + "','" + hpcust.Text.ToString() + "','" + fcust.Text.ToString() + "','" + pcust.Text.ToString() + "','" + tekcust.Text.ToString() + "','" + dtptek.Value.ToString() + "','" + DateTime.Now.ToShortDateString() + "','" + ketcust.Text.ToString() + "')"))
                                            {
                                                insertCommand.Connection = connection1;
                                                cmd.InsertCommand = insertCommand;
                                                //.....
                                                connection1.Open();

                                                int a = insertCommand.ExecuteNonQuery();

                                                if (a == 0)
                                                {
                                                    info.Text = "Info : Data customer (" + ncust.Text.ToString() + ") Tidak Tersimpan , terjadi kesalahan";
                                                    info.ForeColor = System.Drawing.Color.Red;
                                                }
                                                else if (a == 1)
                                                {
                                                    String Data = ncust.Text.ToString();

                                                    ncust.Text = "";
                                                    tcust.Text = "";
                                                    hpcust.Text = "";
                                                    ketcust.Text = "";
                                                    alcust.Text = "";
                                                    fcust.Text = "";
                                                    tekcust.Text = "";
                                                    dtptek.Value = DateTime.Now;
                                                    pcust.Text = "";

                                                    info.Text = "Info : Data customer (" + Data + ") Tersimpan ";
                                                    info.ForeColor = System.Drawing.Color.Green;
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
