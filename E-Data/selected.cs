using System;
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
                            hpcust.Text = a["no_handphone"].ToString();
                            fcust.Text = a["no_fax"].ToString();
                            pcust.Text = a["produk_customer"].ToString();
                            tcust.Text = a["teknisi_customer"].ToString();
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
            prcust =pcust.Text;
            tekncust = tekcust.Text;
            cust = dtptek.Value;
            ketecust = ketcust.Text;

            ncust.Text = nacust;
            alcust.Text = alacust;
            tcust.Text = tecust;
            hpcust.Text = hpccust;
            fcust.Text = facust;
            pcust.Text = prcust;
            tekcust.Text = tekncust;
            dtptek.Value = cust;
            ketcust.Text = ketecust;

            ncust.ReadOnly = false;
            tcust.ReadOnly = false;
            alcust.ReadOnly = false;
            hpcust.ReadOnly = false;
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
                pcust.Text = prcust;
                tekcust.Text = tekncust;
                dtptek.Value = cust;
                ketcust.Text = ketecust;



                ncust.ReadOnly = true;
                tcust.ReadOnly = true;
                alcust.ReadOnly = true;
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

                

            }
            else {
                print();
            }
        }

        private void print() {

        }
    }
}
