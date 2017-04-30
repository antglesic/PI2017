using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Projekt_SiM
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno pokrenuta aplikacija S&M");
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                var runningPath = System.AppDomain.CurrentDomain.BaseDirectory;
                string fileName = string.Format("{0}Resources\\README.md", System.IO.Path.GetFullPath(System.IO.Path.Combine(runningPath, @"..\..\")));
                System.Diagnostics.Process.Start("wordpad.exe", fileName);
                //System.Diagnostics.Process.Start(fileName);   nepregledan tekst kada otvoren u notepadu
                //System.Diagnostics.Process.Start("http://github.com/foivz/r17015");
                // korisnik je pritisnuo F1 tipku na tipkovnici te se u pregledniku otvara poveznica navedena iznad
            }
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"\README.pdf");
        }
    }
}
