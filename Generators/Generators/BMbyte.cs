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
    public partial class BMbyte : Form
    {
        public BMbyte()
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
            BigInteger temp = (p - 1) / 256;
            int[] bmByteTmp = new int[size];
            time.Start();
            for (int i = 0; i < size; i++)
            {
                t = BigInteger.ModPow(a, t, p);
                for (int k = 0; k < 256; k++)
                {
                    if(BigInteger.Multiply(k, temp) <= t && BigInteger.Multiply((k + 1), temp) > t)
                    {
                        bmByteTmp[i] = k;
                        break;
                    }
                }
            }

            int[] bmBit = Func.ConvertToBit(bmByteTmp);
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
