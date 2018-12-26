using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notebook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            InitializeComponent();
        }

        private void новоеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mdiChild = Form1.getInstance();
            mdiChild.MdiParent = this;
            mdiChild.Show();
        }

        private void закрытьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] form = MdiChildren;
            foreach (Form f in form)
            {
                f.Close();
            }
        }


        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Windows win = new WindowsRus(new Russian());
            win.GetLng();
            Properties.Settings.Default.Language = "ru-RU";
            Properties.Settings.Default.Save();
        }

        private void английскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Windows win = new WindowsRus(new English());
            win.GetLng();
            Properties.Settings.Default.Language = "en";
            Properties.Settings.Default.Save();
        }
    }
}
