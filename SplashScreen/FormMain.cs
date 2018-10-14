using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm()
        {
            Application.Run(new FormFlashScreen());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMuonSach f = new FormMuonSach();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTraSach f2 = new FormTraSach();
            f2.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
