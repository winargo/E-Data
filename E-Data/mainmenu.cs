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
using System.Windows.Media.Imaging;
using System.IO.Packaging;

namespace E_Data
{
    public partial class mainmenu : Form
    {
        public static string idcustomer = "";

        private int childFormNumber = 0;
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public mainmenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

            DateTime myDate = DateTime.ParseExact("2018-09-20", "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
            if (DateTime.Now >= myDate) {
                MessageBox.Show("Terjadi Kesalahan Internal", "ERROR");
                Application.Exit();
            }

            if (Settings.Default.server != null || Settings.Default.server != "" && Settings.Default.server != null || Settings.Default.server != "")
            {
                try
                {
                    pictureBox1.Image = new Bitmap(Settings.Default.imagedir.ToString());
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception exp) {
                    
                }
            }
            else {
                mysqlform connect = new mysqlform();
                connect.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newdata start = new newdata();
            start.Show();
        }

        private void tambahDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newdata start = new newdata();
            start.Show();
        }

        private void printDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form showsearch = new search();
            showsearch.ShowDialog();
        }

        private void searchDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form showsearch = new search();
            showsearch.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Change Background Picture ?", "Info", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Open Image";
                    dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";;

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        // Create a new Bitmap object from the picture file on disk,
                        // and assign that to the PictureBox.Image property
                        pictureBox1.Image = new Bitmap(dlg.FileName);
                        Settings.Default.imagedir = dlg.FileName;
                        Settings.Default.Save();
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public static Boolean isconnected() {
            Boolean isconnect = false;

            return isconnect;
        }

        public static Boolean isempty()
        {
            Boolean isempty = false;

            return isempty;
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mysqlform connect = new mysqlform();
            connect.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form showsearch = new search();
            showsearch.ShowDialog();
        }
    }
}
