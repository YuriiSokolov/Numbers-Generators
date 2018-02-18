using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generators
{
    public partial class Standart : Form
    {
        public Standart()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeffe_Click(object sender, EventArgs e)
        {
            int[] standart = new int[Convert.ToInt32(txtSSize.Text)];
            Random rand = new Random();
            for(int i = 0; i < standart.Length; i++)
            {
                standart[i] = rand.Next(0, 2);
            }
            string result = string.Concat(standart);
            OpenFileDialog OpenFile = new OpenFileDialog();
            if(OpenFile.ShowDialog() == DialogResult.OK)
            {
                string FilePath = OpenFile.FileName;
                File.WriteAllText(FilePath, result, Encoding.Default);
            }
            //txtStandart.Text += result;
        }
    }
}
