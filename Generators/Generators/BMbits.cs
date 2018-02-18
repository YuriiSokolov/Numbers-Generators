/*Лабораторна робота №1
 Соколов Ю. М.
 Хренов О. Г. 
 ФБ-41*/
using System;
using System.Text;
using System.Windows.Forms;
using System.Numerics;
using System.IO;
using myfunc;

namespace Generators
{
    public partial class BMbits : Form
    {
        public BMbits()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();
            int size = Convert.ToInt32(txtBMSize.Text);
            string result = string.Empty;
            BigInteger p = Func.ConvertInTen(txtP.Text, 16);
            BigInteger a = Func.ConvertInTen(txtA.Text, 16);
            BigInteger t = Func.ConvertInTen(txtT.Text, 16);
            BigInteger temp = (p - 1) / 2;
            int[] bmBit = new int[size];
            time.Start();
            for (int i = 0; i < size; i++)
            {
                t = BigInteger.ModPow(a, t, p);
                if (t < temp)
                {
                    bmBit[i] = 1;
                }
                else
                {
                    bmBit[i] = 0;
                }
            }
            time.Stop();
            MessageBox.Show(time.Elapsed.ToString());
            result += string.Concat(bmBit);

            OpenFileDialog fileOpen = new OpenFileDialog();

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                string filePath = fileOpen.FileName;
                File.WriteAllText(filePath, result, Encoding.Default);
            }
        }
    }
}
