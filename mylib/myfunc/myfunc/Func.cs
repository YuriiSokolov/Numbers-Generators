using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Numerics;

namespace myfunc
{
    public class Func
    {
        public static BigInteger ConvertInTen(string value, int numbersys)
        {
            BigInteger inten = 0;
            BigInteger index = 1;
            for (int i = value.Length - 1; i >= 0; i--)
            {
                int temp = 0;
                if (value[i] >= '0' && value[i] <= '9')
                {
                    temp = value[i] - '0';
                }
                else
                {
                    switch (value[i])
                    {
                        case 'A': temp = 10; break;
                        case 'B': temp = 11; break;
                        case 'C': temp = 12; break;
                        case 'D': temp = 13; break;
                        case 'E': temp = 14; break;
                        case 'F': temp = 15; break;
                        default: throw new FormatException("Неизвесный символ");
                    }
                }
                inten = BigInteger.Add(inten, BigInteger.Multiply(temp, index));
                index = BigInteger.Multiply(index, numbersys);
            }
            return inten;
        }

        public static int[] ConvertToBit(int[] bytearr)
        {
            int size = bytearr.Length;
            List<bool> bitArrTmp = new List<bool>();
            int[] bitArr = new int[8 * size];
            int ind = 0;
            byte[] temp;

            for (int i = 0; i < size; i++)
            {
                temp = BitConverter.GetBytes(bytearr[i]);
                BitArray tempbit = new BitArray(temp);
                for (int g = 0; g < tempbit.Length; g++, ind++)
                {
                    bitArrTmp.Add(tempbit[g]);
                }
            }

            for (int i = 0; i < bitArr.Length; i++)
            {
                if (bitArrTmp[i] == true)
                {
                    bitArr[i] += 1;
                }
                else
                {
                    bitArr[i] += 0;
                }
            }

            return bitArr;
        }

        /*public static int XOR(int a, int b)
        {
            if (a != b) return 1;
            else return 0;
        }*/

        public static int[] ShiftLeft(int[] array)
        {
            int size = array.Length;
            int[] mas = new int[size];
            mas = array;
            int temp = mas[0];
            for (int i = 1; i < size; i++) mas[i - 1] = mas[i];
            mas[size - 1] = temp;
            return mas;
        }

        public static bool[] ArrayReverse(bool[] temparr)
        {
            bool[] array = new bool[temparr.Length];
            int j = 0;
            for (int i = temparr.Length - 1; i >= 0; i--, j++)
            {
                array[j] = temparr[i];
            }
            return array;
        }

        public static string XOR(string a, string b)
        {
            string bitresult = string.Empty;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    bitresult += '1';
                }
                else
                {
                    bitresult += '0';
                }
            }
            return bitresult;
        }

        public static string OR(string a, string b)
        {
            string bitresult = string.Empty;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '0' && b[i] == '0')
                {
                    bitresult += '0';
                }
                else
                {
                    bitresult += '1';
                }
            }
            return bitresult;
        }

        public static int[] ToIntArray(string a)
        {
            int[] bitarray = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                bitarray[i] = int.Parse(a[i].ToString());
            }

            return bitarray;
        }

        public static string ShiftBitLeft(string a)
        {
            int[] bitarray = ToIntArray(a);
            int temp = bitarray[0];

            for (int i = 1; i < bitarray.Length; i++)
            {
                bitarray[i - 1] = bitarray[i];
            }
            bitarray[bitarray.Length - 1] = temp;
            string bitresult = string.Empty;
            bitresult += string.Concat(bitarray);

            return bitresult;
        }

        public static string ShiftBitRight(string a)
        {
            int[] bitarray = ToIntArray(a);
            int temp = bitarray[bitarray.Length - 1];

            for (int i = bitarray.Length - 2; i >= 0; i--)
            {
                bitarray[i + 1] = bitarray[i];
            }
            bitarray[0] = temp;
            string bitresult = string.Empty;
            bitresult += string.Concat(bitarray);

            return bitresult;
        }

        public static uint ConvertTen(string value, uint numbersys)
        {
            uint inten = 0;
            uint index = 1;
            for (int i = value.Length - 1; i >= 0; i--)
            {
                uint temp = 0;
                if (value[i] >= '0' && value[i] <= '9')
                {
                    temp = (uint)(value[i] - '0');
                }
                else
                {
                    switch (value[i])
                    {
                        case 'A': temp = 10; break;
                        case 'B': temp = 11; break;
                        case 'C': temp = 12; break;
                        case 'D': temp = 13; break;
                        case 'E': temp = 14; break;
                        case 'F': temp = 15; break;
                        default: throw new FormatException("Неизвесный символ");
                    }
                }
                inten = inten + (temp * index);
                index = index * numbersys;
            }
            return inten;
        }

        public static UInt64 LongRandom()
        {
            byte[] temp = new byte[8];
            Random rand = new Random();
            rand.NextBytes(temp);

            return BitConverter.ToUInt64(temp, 0);
        }

        public static string BBSBit(int length)
        {
            BigInteger[] bit = new BigInteger[length];
            string result = string.Empty;
            BigInteger p = ConvertInTen("D5BBB96D30086EC484EBA3D7F9CAEB07", 16);
            BigInteger q = ConvertInTen("425D2B9BFDB25B9CF6C416CC6E37B59C1F", 16);
            BigInteger r = LongRandom();
            BigInteger n = BigInteger.Multiply(p, q);
            for (int i = 0; i < bit.Length; i++)
            {
                bit[i] = r % 2;
                r = BigInteger.ModPow(r, 2, n);
            }

            result += string.Concat(bit);

            return result;
        }

        public static BigInteger Euclid(BigInteger a, BigInteger m)
        {
            if (a < 0)
            {
                a = m + a;
            }
            if (a == m)
            {
                return m;
            }
            else
            {
                while (a != 0 && m != 0)
                {
                    if (a > m)
                    {
                        a = a % m;
                    }
                    else
                    {
                        m = m % a;
                    }
                }
                return BigInteger.Add(a, m);
            }
        }

        public static bool MillerRab(BigInteger num, int k)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                BigInteger tempNum = num - 1;
                BigInteger d = tempNum;
                int s = 0;

                do
                {
                    d = d / 2;
                    s++;
                } while (d % 2 == 0);

                for (int i = 0; i < k; i++)
                {
                    BigInteger x = new BigInteger();
                    do
                    {
                        x = ConvertInTen(BBSBit(128), 2);
                    } while (x > num);
                    if (Euclid(num, x) > 1)
                    {
                        return false;
                    }
                    else
                    {
                        if (BigInteger.ModPow(x, d, num) == 1 || BigInteger.ModPow(x, d, num) == -1)
                        {
                            return true;
                        }
                        else
                        {
                            for (int r = 1; r < s; r++)
                            {
                                BigInteger pow = BigInteger.Multiply(d, (BigInteger)Math.Pow(2, r));
                                BigInteger tempX = BigInteger.ModPow(x, pow, num);
                                if (tempX == -1)
                                {
                                    return true;
                                }
                                if (tempX == 1)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
                return false;
            }
        }
        //==========================================[Расширеный алгоритм Евклида]=================================
        public static BigInteger ExtendedEuclid(BigInteger a, BigInteger b, out BigInteger x, out BigInteger y)
        {
            BigInteger d;
            if (b == 0)
            {
                d = a;
                x = 1;
                y = 0;
                return d;
            }
            else
            {
                BigInteger x1 = 0;
                BigInteger x2 = 1;
                BigInteger y1 = 1;
                BigInteger y2 = 0;
                BigInteger q, r;
                while (b > 0)
                {
                    q = a / b;
                    r = a % b;
                    x = x2 - (q * x1);
                    y = y2 - (q * y1);
                    a = b;
                    b = r;
                    x2 = x1;
                    x1 = x;
                    y2 = y1;
                    y1 = y;
                }
                d = a;
                x = x2;
                y = y2;
                return d;
            }
        }
        //==============================================[Обратный элемент]=======================================
        public static BigInteger InverseElement(BigInteger a, BigInteger m)
        {
            BigInteger x, y;
            BigInteger d = ExtendedEuclid(a, m, out x, out y);
            if (d == 1)
            {
                x = (x % m + m) % m;
                if (x < 0)
                {
                    x = x + m;
                }
                return x;
            }
            else
            {
                return 0;
            }
        }

        public static BigInteger GenPrime()
        {
            BigInteger num = new BigInteger();
            do
            {
                num = ConvertInTen(BBSBit(128), 2);
            } while (!MillerRab(num, 20));

            return num;
        }

        public static BigInteger GenPrimeFast()
        {
            BigInteger num = ConvertInTen(BBSBit(128), 2);
            int[] arrPrime = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29,
                31, 37, 41, 43, 47, 59, 61, 67, 71, 73, 79, 83,
                89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151};
            for (int i = 0; i < arrPrime.Length; i++)
            {
                if (num % arrPrime[i] == 0)
                {
                    i = 0;
                    num = ConvertInTen(BBSBit(128), 2);
                }
            }
            while (!MillerRab(num, 20))
            {
                num = num + 2;
            }

            return num;
        }

        public static BigInteger NumBluma()
        {
            BigInteger blum = new BigInteger();
            do
            {
                blum = 4 * ConvertInTen(BBSBit(128), 2) + 3;
            } while (!MillerRab(blum, 20));

            return blum;
        }

        public static int Jakobi(BigInteger x, BigInteger n)
        {
            if (Euclid(x, n) != 1)
            {
                return 0;
            }
            else
            {
                int symbolJakobi = 1;
                if (x < 0)
                {
                    x = x * (-1);
                    if ((n % 4) == 3)
                    {
                        symbolJakobi = symbolJakobi * (-1);
                        return symbolJakobi;
                    }
                }
                else
                {
                    while (x != 0)
                    {
                        int temp = 0;
                        while ((x % 2) == 0)
                        {
                            temp = temp + 1;
                            x = x / 2;
                        }
                        if ((temp % 2) == 1)
                        {
                            if ((n % 8) == 3 || (n % 8) == 5)
                            {
                                symbolJakobi = symbolJakobi * (-1);
                            }
                        }
                        if ((x % 4) == 3 && (n % 4) == 3)
                        {
                            symbolJakobi = symbolJakobi * (-1);
                        }
                        BigInteger tempX = x;
                        x = n % tempX;
                        n = tempX;
                    }
                    return symbolJakobi;
                }
                return symbolJakobi;
            }
        }

        public static BigInteger[] SqrtBlum(BigInteger y, BigInteger p, BigInteger q, BigInteger n)
        {
            BigInteger[] sqrt = new BigInteger[4];
            BigInteger tempStep1 = (p + 1) / 4;
            BigInteger tempStep2 = (q + 1) / 4;
            BigInteger s1 = BigInteger.ModPow(y, tempStep1, p);
            BigInteger s2 = BigInteger.ModPow(y, tempStep2, q);
            BigInteger u = new BigInteger();
            BigInteger v = new BigInteger();
            ExtendedEuclid(p, q, out u, out v);
            BigInteger nintwo = BigInteger.Pow(n, 2);
            BigInteger ups2 = u * p * s2;
            BigInteger vqs1 = v * q * s1;

            if(ups2 < 0)
            {
                while (ups2 < 0)
                {
                    ups2 = ups2 + nintwo;
                }
            }

            ups2 = ups2 % n;

            if (vqs1 < 0)
            {
                while (vqs1 < 0)
                {
                    vqs1 = vqs1 + nintwo;
                }
            }

            vqs1 = vqs1 % n;

            sqrt[0] = (nintwo + ups2 + vqs1) % n;
            sqrt[1] = (nintwo - ups2 + vqs1) % n;
            sqrt[2] = (nintwo + nintwo - ups2 - vqs1) % n;
            sqrt[3] = (nintwo + ups2 - vqs1) % n;

            return sqrt;
        }

        public static BigInteger TextNormal(BigInteger m, BigInteger n)
        {
            byte[] bytes = n.ToByteArray();
            int l = bytes.Length;
            byte[] bytesm = m.ToByteArray();
            int lengthM = bytesm.Length;
            if (lengthM < (l - 10))
            {
                BigInteger r = ConvertInTen(BBSBit(64), 2);
                BigInteger twoin26 = BigInteger.Pow(2, 64);
                int step = 8 * (l - 2);
                BigInteger twoinstep = BigInteger.Pow(2, step);
                BigInteger Mn = 255 * twoinstep + m * twoin26 + r;
                return Mn;
            }
            else
            {
                throw new FormatException("m слишком большое");
            }
        }

        public static bool QuadRes(BigInteger mN, BigInteger p, BigInteger q)
        {
            if(Jakobi(mN, p) == 1 && Jakobi(mN, q) == 1)
            {
                return true;
            }
            return false;
        }
    }
}
