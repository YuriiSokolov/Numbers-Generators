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
    public partial class L89 : Form
    {
        public L89()
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

        public static int[] GL89(string reg, int t, int rounds)
        {
            int[] newReg = ToIntArray(reg);
            int[] s = new int[rounds];

            for (int i = 0; i < rounds; i++)
            {
                s[i] = newReg[0];
                newReg[0] = XOR(newReg[t - 38], newReg[t - 89]);
                newReg = Shift(newReg, newReg.Length);
            }
            return s;
        }

        private void btnL89_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtLSize.Text) >= 89)
            {
                int[] l89 = new int[Convert.ToInt32(txtLSize.Text)];
                l89 = GL89(txtL89.Text, Convert.ToInt32(txtLSize.Text), Convert.ToInt32(txtL89Size.Text));
                string result = string.Concat(l89);
                OpenFileDialog OpenFile = new OpenFileDialog();
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    string FilePath = OpenFile.FileName;
                    File.WriteAllText(FilePath, result, Encoding.Default);
                }
            }
            else
            {
                MessageBox.Show("t должно быть больше 89");
            }
        }
    }
}
