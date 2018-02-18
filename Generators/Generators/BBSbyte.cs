/*Лабораторна робота №1
 Соколов Ю. М.
 Хренов О. Г. 
 ФБ-41*/
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Numerics;
using System.Collections;
using myfunc;

namespace Generators
{
    public partial class BBSbyte : Form
    {
        public BBSbyte()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();
            time.Start();
            int size = Convert.ToInt32(txtBBSSize.Text);
            BigInteger temp = 0;
            byte[] tempbyte;
            //bool[] bbsByteTmp = new bool[8 * size];
            List<bool> bbsByteTmp = new List<bool>();
            int[] bbsByte = new int[8 * size];
            string result = string.Empty;
            BigInteger p = Func.ConvertInTen(txtP.Text, 16);
            BigInteger q = Func.ConvertInTen(txtQ.Text, 16);
            BigInteger r = Func.ConvertInTen(txtR.Text, 16);
            BigInteger n = BigInteger.Multiply(p, q);

            for (int i = 0; i < size; i++)
            {
                temp = r % 256;
                r = BigInteger.ModPow(r, 2, n);
                tempbyte = temp.ToByteArray();

                BitArray tempbit = new BitArray(tempbyte);
                /*bool[] tmp = new bool[tempbit.Length];
                for (int j = 0; j < tempbit.Length; j++)
                {
                    tmp[j] = tempbit[j];
                }
                tmp.Reverse();
                bool[] tmpbbsb = new bool[tmp.Length];
                for (int k = 0; k < 8; k++)
                {
                    tmpbbsb[k] = tmp[k];
                }
                tmpbbsb.Reverse();*/
                for (int g = tempbit.Length - 8; g < tempbit.Length; g++)
                {
                    bbsByteTmp.Add(tempbit[g]);
                }
            }

            for (int i = 0; i < bbsByteTmp.Count; i++)
            {
                if (bbsByteTmp[i] == true)
                {
                    bbsByte[i] += 1;
                }
                else
                {
                    bbsByte[i] += 0;
                }
            }
            time.Stop();

            MessageBox.Show(time.Elapsed.ToString());

            result += string.Concat(bbsByte);

            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                string FilePath = OpenFile.FileName;
                File.WriteAllText(FilePath, result, Encoding.Default);
            }
        }
    }
}
