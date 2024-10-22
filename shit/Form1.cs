using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xerath
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //no
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //no
        }

        private void Arcanopulse_Click(object sender, EventArgs e)
        {

            Attacks a = new Attacks();
            var asd = a.Arcanopulse(100);
        }

        private void AT_Click(object sender, EventArgs e)
        {
            Attacks a = new Attacks();
            var asd = a.AT(100);
        }
    }
}
