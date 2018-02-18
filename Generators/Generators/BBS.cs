/*Лабораторна робота №1
 Соколов Ю. М.
 Хренов О. Г. 
 ФБ-41*/
using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Numerics;
using myfunc;

namespace Generators
{
    public partial class BBS : Form
    {
        public BBS()
        {
            InitializeComponent();
        }

        /*public int[] inten(string val16)
        {
            int[] temp = new int[val16.Length];
            BigInteger val = 0;
            BigInteger val10 = 0;
            for(int i = 0; i < val16.Length; i++)
            {
                if(val16[i] == 'A')
                {
                    temp[i] = 10;
                }
                if (val16[i] == 'B')
                {
                    temp[i] = 11;
                }
                if (val16[i] == 'C')
                {
                    temp[i] = 12;
                }
                if (val16[i] == 'D')
                {
                    temp[i] = 13;
                }
                if (val16[i] == 'E')
                {
                    temp[i] = 14;
                }
                if (val16[i] == 'F')
                {
                    temp[i] = 15;
                }
                else
                {               
                    temp[i] = Convert.ToInt32(val16[i]);
                }
            }
            for(int j = 0; j < val16.Length - 1; j++)
            {
                val = BigInteger.Multiply(temp[j], BigInteger.Pow(16, (val16.Length - j - 1)));
                val10 = BigInteger.Add(val, val10); 
            }
            return temp;
        }*/

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();
            time.Start();
            BigInteger[] bit = new BigInteger[Convert.ToInt32(txtBBSSize.Text)];
            string result = string.Empty;
            BigInteger p = Func.ConvertInTen(txtP.Text, 16);
            BigInteger q = Func.ConvertInTen(txtQ.Text, 16);
            BigInteger r = Func.ConvertInTen(txtR.Text, 16);
            BigInteger n = BigInteger.Multiply(p, q);
            for (int i = 0; i < bit.Length; i++)
            {
                bit[i] = r % 2;
                r = BigInteger.ModPow(r, 2, n);
            }
            time.Stop();

            MessageBox.Show(time.Elapsed.ToString());

            result += string.Concat(bit);

            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                string FilePath = OpenFile.FileName;
                File.WriteAllText(FilePath, result, Encoding.Default);
            }
        }
    }
}
