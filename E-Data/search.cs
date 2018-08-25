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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {
            searchbox.KeyDown += new KeyEventHandler(tb_KeyDown);
           

            cb1.Items.Add("nama_customer");
            cb1.Items.Add("alamat_customer");
            cb1.Items.Add("no_telepon");
            cb1.Items.Add("no_handphone");
            cb1.Items.Add("produk_customer");
            cb1.Items.Add("teknisi_customer");
            cb1.Items.Add("keterangan");
            cb1.SelectedIndex = 0;
            cb1.Refresh();

            cb2.Items.Add("nama_customer");
            cb2.Items.Add("alamat_customer");
            cb2.Items.Add("no_telepon");
            cb2.Items.Add("no_handphone");
            cb2.Items.Add("produk_customer");
            cb2.Items.Add("teknisi_customer");
            cb2.Items.Add("keterangan");
            cb2.Refresh();

            cb2.SelectedIndex = 0;

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
                    using (var checkCommand = new SqlCommand("select * from customer order by "+ cb2.Text +" asc",connection1))
                    {

                        using (var adapter = new SqlDataAdapter(checkCommand))
                        {
                            connection1.Open();
                            var myTable = new DataTable();
                            adapter.Fill(myTable);
                            dataGridView1.DataSource = myTable;
                        }

                        // .... you don't need to close the connection explicitely
                    }

                }
            }
            catch (Exception dataexcp)
            {
                MessageBox.Show(dataexcp.ToString(), "Error On SQL Connection ");
            }
        }
        public void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
                        using (var checkCommand = new SqlCommand("select * from customer where " + cb1.Text + " like  '%" + searchbox.Text.ToString() + "%' order by " + cb2.Text + " asc",connection1))
                        {

                            using (var adapter = new SqlDataAdapter(checkCommand))
                            {
                                connection1.Open();
                                var myTable = new DataTable();
                                adapter.Fill(myTable);
                                dataGridView1.DataSource = myTable;
                            }
                        }

                    }
                    
                    
                }
                catch (Exception dataexcp)
                {
                    MessageBox.Show( dataexcp.ToString(), "Error On SQL Connection ");
                }
            }
            if (e.KeyCode == Keys.F5)
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
                        using (var checkCommand = new SqlCommand("select * from customer order by " + cb2.Text + " asc", connection1))
                        {

                            using (var adapter = new SqlDataAdapter(checkCommand))
                            {
                                connection1.Open();
                                var myTable = new DataTable();
                                adapter.Fill(myTable);
                                dataGridView1.DataSource = myTable;
                            }
                        }

                    }


                }
                catch (Exception dataexcp)
                {
                    MessageBox.Show(dataexcp.ToString(), "Error On SQL Connection ");
                }
            }
        }

        /*private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                mainmenu.idcustomer = row.Cells["ID"].Value.ToString();
                selected selecte = new selected();
                selecte.ShowDialog();
            }
        }*/

        private void dataGridView1_CellMouseDoubleClick(Object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;
            if (dgv.CurrentRow.Selected)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                mainmenu.idcustomer = row.Cells["ID"].Value.ToString();
                selected selecte = new selected();
                selecte.ShowDialog();
            }
        }



        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                this.dataGridView1.CurrentRow.Selected = true;
                e.Handled = true;
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                mainmenu.idcustomer = row.Cells["ID"].Value.ToString();
                selected selecte = new selected();
                selecte.ShowDialog();
            }
        }
       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void refresh() {
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
                    using (var checkCommand = new SqlCommand("select * from customer order by " + cb2.Text + " asc", connection1))
                    {

                        using (var adapter = new SqlDataAdapter(checkCommand))
                        {
                            connection1.Open();
                            var myTable = new DataTable();
                            adapter.Fill(myTable);
                            dataGridView1.DataSource = myTable;
                        }

                        // .... you don't need to close the connection explicitely
                    }

                }
            }
            catch (Exception dataexcp)
            {
                MessageBox.Show(dataexcp.ToString(), "Error On SQL Connection ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bHandled = false;
            // switch case is the easy way, a hash or map would be better, 
            // but more work to get set up.
            switch (keyData)
            {
                case Keys.F5:
                    refresh();
                    bHandled = true;
                    break;
            }
            return bHandled;
        }
    }
}
