/*Лабораторна робота №1
 Соколов Ю. М.
 Хренов О. Г. 
 ФБ-41*/
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Generators
{
    public partial class L20 : Form
    {
        public L20()
        {
            InitializeComponent();
        }

        //=================================[Доп функции]==========================================
        public static int XOR(int a, int b)
        {
            if (a != b) return 1;
            else return 0;
        }

        public static int[] Shift(int[] array, int size)
        {
            int[] mas = new int[size];
            mas = array;
            int temp = mas[0];
            for (int i = 1; i < size; i++) mas[i - 1] = mas[i];
            mas[size - 1] = temp;
            return mas;
        }

        public static int[] ToIntArray(string reg)
        {
            int[] intArray = new int[reg.Length];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = int.Parse(reg[i].ToString());
            }
            return intArray;
        }

        public static int[] GL20(string reg, int t, int rounds)
        {
            int[] newReg = ToIntArray(reg);
            int[] s = new int[rounds];

            for (int i = 0; i < rounds; i++)
            {
                s[i] = newReg[0];
                newReg[0] = XOR(XOR(newReg[t - 3], newReg[t - 5]), XOR(newReg[t - 9], newReg[t - 20]));
                newReg = Shift(newReg, newReg.Length);
            }
            return s;
        }

        private void btnL20_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtLSize.Text) >= 20)
            {
                int[] l20 = new int[Convert.ToInt32(txtLSize.Text)];
                l20 = GL20(txtL20.Text, Convert.ToInt32(txtLSize.Text), Convert.ToInt32(txtL20Size.Text));
                string result = string.Concat(l20);
                OpenFileDialog OpenFile = new OpenFileDialog();
                if(OpenFile.ShowDialog() == DialogResult.OK)
                {
                    string FilePath = OpenFile.FileName;
                    File.WriteAllText(FilePath, result, Encoding.Default);
                }
            }
            else
            {
                MessageBox.Show("t должно быть больше 20");
            }
        }
    }
}
