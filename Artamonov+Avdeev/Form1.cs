using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artamonov_Avdeev
{
    public partial class Avdeevmenu : Form
    {
        public Avdeevmenu()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form backmain = new Maincraft();
            backmain.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Form first = new FormCHAnNCATb();
            //first.Show();
            //this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form second = new Avdeev();
            second.Show();
            this.Hide();
        }
    }
}
