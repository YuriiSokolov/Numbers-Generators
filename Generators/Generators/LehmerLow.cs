/*Лабораторна робота №1
 Соколов Ю. М.
 Хренов О. Г. 
 ФБ-41*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;


namespace Generators
{
    public partial class LehmerLow : Form
    {
        public LehmerLow()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();
            time.Start();
            int size = Convert.ToInt32(txtSize.Text);
            int c = 119;
            Int64 m = Convert.ToInt64(Math.Pow(2, 32));
            Int64 a = Convert.ToInt64(Math.Pow(2, 16)) + 1;
            Int64 x = Convert.ToInt64(txtX.Text);
            List<bool> lLowTemp = new List<bool>();
            byte[] temp;
            int[] lLow = new int[8 * size];

            for (int i = 0; i < size; i++)
            {
                x = ((x * a) + c) % m;
                temp = BitConverter.GetBytes(x);
                BitArray tempbit = new BitArray(temp);
                for (int j = temp.Length - 8; j < temp.Length; j++)
                {
                    lLowTemp.Add(tempbit[j]);         
                }
            }

            for (int i = 0; i < lLowTemp.Count; i++)
            {
                if (lLowTemp[i] == true)
                {
                    lLow[i] += 1;
                }
                else
                {
                    lLow[i] += 0;
                }
            }
            time.Stop();

            MessageBox.Show(time.Elapsed.ToString());

            result += string.Concat(lLow);

            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                string FilePath = OpenFile.FileName;
                File.WriteAllText(FilePath, result, Encoding.Default);
            }
        }
    }
}
