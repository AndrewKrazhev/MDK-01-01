using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBD_prj
{
    public partial class MainForm : Form
    {
        string _formText = "Приёмная комиссия ОБПОУ КТС";
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = _formText + " 1121";
            //this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm AboutForm = new aboutForm();
            AboutForm.ShowDialog();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings SettinsForm = new Settings();
            SettinsForm.ShowDialog();
        }
    }
}
