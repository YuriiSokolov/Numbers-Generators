/*Лабораторна робота №1
 Соколов Ю. М.
 Хренов О. Г. 
 ФБ-41*/
using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Generators
{
    public partial class Librarian : Form
    {
        public Librarian()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            byte[] libbyte = Encoding.UTF8.GetBytes(txtLibrarian.Text);
            BitArray libbit = new BitArray(libbyte);
            int[] lbit = new int[libbit.Length];
            string result = string.Empty;

            for(int i = 0; i < libbit.Length; i++)
            {
                if (libbit[i] == true)
                {
                    lbit[i] += 1;
                }
                else
                {
                    lbit[i] += 0;
                }
            }
            result += string.Concat(lbit);

            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                string FilePath = OpenFile.FileName;
                File.WriteAllText(FilePath, result, Encoding.Default);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLibrarian.Clear();
        }
    }
}
