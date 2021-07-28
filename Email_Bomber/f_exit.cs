using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Bomber
{
    public partial class f_exit : Form
    {
        public f_exit()
        {
            InitializeComponent();
        }

        private void b_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
