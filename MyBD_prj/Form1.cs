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
            Text = Properties.Settings.Default.Name;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Enter(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            Text = Properties.Settings.Default.Name;
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            InputForm _inputForm = new InputForm();
            _inputForm.MdiParent= this;
            _inputForm.Show();
        }

        private void toolStripButton3_MouseMove(object sender, MouseEventArgs e)
        {
            hintStatusLabel.Text = "Открыть основную форму";
        }

        private void toolStrip1_MouseLeave(object sender, EventArgs e)
        {
            hintStatusLabel.Text = "";
        }
    }
}
