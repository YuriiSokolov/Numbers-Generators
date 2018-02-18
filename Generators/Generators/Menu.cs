using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generators
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnL20_Click(object sender, EventArgs e)
        {
            L20 l20 = new L20();
            l20.Show();
        }

        private void btnStandart_Click(object sender, EventArgs e)
        {
            Standart standart = new Standart();
            standart.Show();
        }

        private void btnGeffe_Click(object sender, EventArgs e)
        {
            Geffe geffe = new Geffe();
            geffe.Show();
        }

        private void btnL89_Click(object sender, EventArgs e)
        {
            L89 l89 = new L89();
            l89.Show();
        }

        private void btnLibrarian_Click(object sender, EventArgs e)
        {
            Librarian lib = new Librarian();
            lib.Show();
        }

        private void btnBBS_Click(object sender, EventArgs e)
        {
            BBS bbs = new BBS();
            bbs.Show();
        }

        private void btnLehmerLow_Click(object sender, EventArgs e)
        {
            LehmerLow lehmerLow = new LehmerLow();
            lehmerLow.Show();
        }

        private void btnLehmerHigh_Click(object sender, EventArgs e)
        {
            LehmerHigh lehmerHigh = new LehmerHigh();
            lehmerHigh.Show();
        }

        private void btnBBS_Bytes_Click(object sender, EventArgs e)
        {
            BBSbyte form = new BBSbyte();
            form.Show();
        }

        private void btnBM_Click(object sender, EventArgs e)
        {
            BMbits form = new BMbits();
            form.Show();
        }

        private void btnBM_Bytes_Click(object sender, EventArgs e)
        {
            BMbyte form = new BMbyte();
            form.Show();
        }

        private void btnWolfram_Click(object sender, EventArgs e)
        {
            Wolfram form = new Wolfram();
            form.Show();
        }
    }
}
