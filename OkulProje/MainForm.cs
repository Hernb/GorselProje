using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProje
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStatus((ToolStripMenuItem)sender);
            MessageBox.Show("Çıkış Yapılıyor", "Çıkış");
            this.Hide();
        }

        private void SetStatus(ToolStripMenuItem toolStripMenuItem)
        {
            toolStripStatusLabel1.Text = toolStripMenuItem.Text + " Girildi.";
        }

        private void öğrenciDersPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStatus((ToolStripMenuItem)sender);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dersPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStatus((ToolStripMenuItem)sender);
            var dersekran = new dersekran();
            dersekran.MdiParent = this;
            dersekran.Show();
        }

        private void okulYönetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStatus((ToolStripMenuItem)sender);
            var okulyönetimekran = new okulyönetimekran();
            okulyönetimekran.MdiParent = this;
            okulyönetimekran.Show();
        }

        private void öğrenciPaneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStatus((ToolStripMenuItem)sender);
            var ogrenciekran = new ogrenciekran();
            ogrenciekran.MdiParent = this;
            ogrenciekran.Show();
        }

        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStatus((ToolStripMenuItem)sender);
            var menu = new menu();
            menu.MdiParent = this;
            menu.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var okulyönetimekran = new okulyönetimekran();
            okulyönetimekran.MdiParent = this;
            okulyönetimekran.Show();
        }
    }
}
