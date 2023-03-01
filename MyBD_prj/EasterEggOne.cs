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
    public partial class EasterEggOne : Form
    {
        public EasterEggOne()
        {
            InitializeComponent();
        }

        private void EasterEggOne_Load(object sender, EventArgs e)
        {
            this.Text = "Я после 12 часов кодинга";
        }

        private void EasterEggOne_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
