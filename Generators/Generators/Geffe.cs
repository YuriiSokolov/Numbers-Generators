/*Лабораторна робота №1
 Соколов Ю. М.
 Хренов О. Г. 
 ФБ-41*/
using System;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Generators
{
    public partial class Geffe : Form
    {
        public Geffe()
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

        public static int[] LFSR1(string reg, int rounds)
        {
            int[] newReg = ToIntArray(reg);
            int[] s = new int[rounds];

            for (int i = 0; i < rounds; i++)
            {
                s[i] = newReg[0];
                newReg[0] = XOR(newReg[2], newReg[0]);
                newReg = Shift(newReg, newReg.Length);
            }
            return s;
        }

        public static int[] LFSR2(string reg, int rounds)
        {
            int[] newReg = ToIntArray(reg);
            int[] s = new int[rounds];

            for (int i = 0; i < rounds; i++)
            {
                s[i] = newReg[0];
                newReg[0] = XOR(XOR(XOR(newReg[0], newReg[1]), newReg[3]), newReg[4]);
                newReg = Shift(newReg, newReg.Length);
            }
            return s;
        }

        public static int[] LFSR3(string reg, int rounds)
        {
            int[] newReg = ToIntArray(reg);
            int[] s = new int[rounds];

            for (int i = 0; i < rounds; i++)
            {
                s[i] = newReg[0];
                newReg[0] = XOR(newReg[3], newReg[0]);
                newReg = Shift(newReg, newReg.Length);
            }
            return s;
        }

        public static int[] GGeffe(int[] LFSR1, int[] LFSR2, int[] LFSR3, int size)
        {
            int[] Geffe = new int[size];

            for (int i = 0; i < size; i++)
            {
                Geffe[i] = XOR(((LFSR3.Length > i ? LFSR3[i] : 0) * (LFSR1.Length > i ? LFSR1[i] : 0)), (XOR(1, (LFSR3.Length > i ? LFSR3[i] : 0)) * (LFSR2.Length > i ? LFSR2[i] : 0)));
            }

            return Geffe;
        }
        //========================================================================================

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeffe_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();

            int[] lastLFSR1 = LFSR1(txtLFSR1.Text, Convert.ToInt32(txtN1.Text));
            int[] lastLFSR2 = LFSR2(txtLFSR2.Text, Convert.ToInt32(txtN2.Text));
            int[] lastLFSR3 = LFSR3(txtLFSR3.Text, Convert.ToInt32(txtN3.Text));
            int[] Geff = GGeffe(lastLFSR1, lastLFSR2, lastLFSR3, Convert.ToInt32(txtGeffeSize.Text));
            string result = string.Concat(Geff);
            //time.Start();
            //time.Stop();
            //MessageBox.Show(time.Elapsed.ToString());
            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                string FilePath = OpenFile.FileName;
                File.WriteAllText(FilePath, result, Encoding.Default);
            }
            //txtGeffe.Text += result;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGeffe.Clear();
        }
    }
}
