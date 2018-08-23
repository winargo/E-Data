using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Data.Properties;
using System.Data.SqlClient;

namespace E_Data
{
    public partial class mysqlform : Form
    {
        public mysqlform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection myConnection = new SqlConnection("Server=" + svrdata.Text.ToString() + ";" +
                                       "Trusted_Connection=yes;" +
                                       "user id=" + textBox4.Text.ToString() + "; " +
                                       "password=" + textBox5.Text.ToString() + "; " +
                                       "database=" + textBox3.Text.ToString() + "; " +
                                       "connection timeout=20");
                myConnection.Open();
                MessageBox.Show("Connected !!!");

                Settings.Default.server = svrdata.Text.ToString();
                Settings.Default.database = textBox3.Text.ToString();
                Settings.Default.username = textBox4.Text.ToString();
                Settings.Default.password = textBox5.Text.ToString();

                Settings.Default.Save();

                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("failed!" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mysqlform_Load(object sender, EventArgs e)
        {
            svrdata.Text = Settings.Default.server;
            textBox3.Text = Settings.Default.database;
            textBox4.Text = Settings.Default.username;
            textBox5.Text = Settings.Default.password;
        }
    }
}
