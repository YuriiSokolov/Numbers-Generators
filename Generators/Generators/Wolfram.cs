/*Лабораторна робота №1
 Соколов Ю. М.
 Хренов О. Г. 
 ФБ-41*/
using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using myfunc;

namespace Generators
{
    public partial class Wolfram : Form
    {
        public Wolfram()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(txtSize.Text);
            uint[] x = new uint[size];
            uint r = Convert.ToUInt32(txtR.Text);
            string result = string.Empty;
            string bit = "00000000000000000000000000000000";

            for (int i = 0; i < size; i++)
            {
                x[i] = r % 2;
                string tempbit = Convert.ToString(r, 2);
                bit = bit.Remove(bit.Length - tempbit.Length);
                bit += string.Concat(tempbit);
                tempbit = string.Empty;
                r = Func.ConvertTen(Func.XOR(Func.ShiftBitLeft(bit), Func.OR(bit, Func.ShiftBitRight(bit))), 2);
                bit = string.Empty;
                bit = "00000000000000000000000000000000";
            }
            result += string.Concat(x);

            OpenFileDialog fileOpen = new OpenFileDialog();

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                string filePath = fileOpen.FileName;
                File.WriteAllText(filePath, result, Encoding.Default);
            }
        }
    }
}
