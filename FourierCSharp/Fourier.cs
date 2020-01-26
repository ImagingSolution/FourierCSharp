using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourierCSharp
{
    public static class FourierTransform
    {
        /// <summary>
        /// フーリエ変換（データ個数に基づき）
        /// </summary>
        /// <param name="compSrc"></param>
        /// <param name="compDst"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int Fourier(System.Numerics.Complex[] compSrc, ref System.Numerics.Complex[] compDst, double id = 1.0)
        {
            // 引き数チェック
            if (compSrc == null) return -1;

            // 2の何乗か？
            var n = Math.Log((double)compSrc.Length, 2.0);

            // 乗数が整数の場合(データ個数が２のｎ乗の場合)
            if (n == (int)n)
            {
                // FFT
                return Fft(compSrc, ref compDst, id);
            }else
            {
                // DFT
                return Dft(compSrc, ref compDst, id);
            }
        }

        /// <summary>
        /// 高速フーリエ変換FFT
        /// </summary>
        /// <param name="compSrc">変換前の複素数配列</param>
        /// <param name="compDst">変換後の複素数配列</param>
        /// <param name="id">フーリエ変換の場合 = 1、逆フーリエ変換の場合 = -1</param>
        /// <returns></returns>
        public static int Fft(System.Numerics.Complex[] compSrc, ref System.Numerics.Complex[] compDst, double id = 1.0)
        {
            // 引き数チェック
            if (compSrc == null) return -1;

            // データ個数
            int n = compSrc.Length;

            if (compDst == null)
            {
                compDst = new System.Numerics.Complex[n];
            }
            else if (compDst.Length != n)
            {
                compDst = new System.Numerics.Complex[n];
            }

            int i, i0, i1, j, k, arg;
            double th;


            compSrc.CopyTo(compDst, 0);

            System.Numerics.Complex comp;
            System.Numerics.Complex compTh;

            int ns = n / 2;
            double radTemp = 2.0 * Math.PI / (double)n;

            while (ns >= 1)
            {
                arg = 0;

                for (j = 0; j < n; j += 2 * ns)
                {
                    k = n / 4;

                    th = -id * radTemp * arg;
                    compTh = System.Numerics.Complex.FromPolarCoordinates(1.0, th);

                    for (i0 = j; i0 < j + ns; i0++)
                    {
                        i1 = i0 + ns;

                        comp = compDst[i1] * compTh;

                        compDst[i1] = compDst[i0] - comp;
                        compDst[i0] = compDst[i0] + comp;
                    }

                    while (k <= arg)
                    {
                        arg -= k;
                        k /= 2;

                        if (k == 0) break;
                    }

                    arg += k;
                }
                ns /= 2;
            }

            // 逆変換のとき
            if (id < 0)
            {
                for (i = 0; i < n; i++)
                {
                    compDst[i] /= (double)n;
                }
            }

            j = 1;
            for (i = 1; i < n; i++)
            {
                if (i <= j)
                {
                    comp = compDst[i - 1];
                    compDst[i - 1] = compDst[j - 1];
                    compDst[j - 1] = comp;
                }
                k = n / 2;

                while (k < j)
                {
                    j -= k ;
                    k /= 2;
                }
                j += k;
            }
            return 0;
        }

        /// <summary>
        /// 離散フーリエ変換(DFT)
        /// </summary>
        /// <param name="compSrc">変換前の複素数配列</param>
        /// <param name="compDst">変換後の複素数配列</param>
        /// <param name="id">フーリエ変換の場合 = 1、逆フーリエ変換の場合 = -1</param>
        /// <returns></returns>
        public static int Dft(System.Numerics.Complex[] compSrc, ref System.Numerics.Complex[] compDst, double id = 1.0)
        {
            // 引き数チェック
            if (compSrc == null) return -1;

            // データ個数
            int n = compSrc.Length;

            if (compDst == null)
            {
                compDst = new System.Numerics.Complex[n];
            }else if (compDst.Length != n)
            {
                compDst = new System.Numerics.Complex[n];
            }

            int i, thIndex;

            System.Numerics.Complex compSum;
            var compTh = new System.Numerics.Complex[n];

            double radTemp = -id * 2.0 * Math.PI / (double)n;

            for (i = 0; i < n; i++)
            {
                compTh[i] = System.Numerics.Complex.FromPolarCoordinates(1.0, radTemp * i);
            }

            for (int t = 0; t < n; t++)
            {
                compSum = System.Numerics.Complex.Zero;

                for (i = 0; i < n; i++)
                {
                    thIndex = (i * t) % n;

                    compSum += compSrc[i] * compTh[thIndex];
                }

                compDst[t] = compSum;

                if (id < 0)
                {
                    compDst[t] /= (double)n;
                }
            }

            return 0;
        }

        /// <summary>
        /// ハミング窓
        /// </summary>
        /// <param name="data"></param>
        public static void Hamming(System.Numerics.Complex[] data)
        {
            if (data == null) return;

            int dataCount = data.Length;

            var radTemp = 2.0 * Math.PI / (double)dataCount;

            for (int i = 0; i < dataCount; i++)
            {
                data[i] *= (0.54 - 0.46 * Math.Cos(radTemp * (double)i));
            }
        }

        /// <summary>
        /// ハニング窓
        /// </summary>
        /// <param name="data"></param>
        public static void Hanning(System.Numerics.Complex[] data)
        {
            if (data == null) return;

            int dataCount = data.Length;

            var radTemp = 2.0 * Math.PI / (double)dataCount;

            for (int i = 0; i < dataCount; i++)
            {
                data[i] *= (0.5 * (1.0 - Math.Cos(radTemp * (double)i)));
            }
        }

        /// <summary>
        /// ブラックマン窓
        /// </summary>
        /// <param name="data"></param>
        public static void Blackman(System.Numerics.Complex[] data)
        {
            if (data == null) return;

            int dataCount = data.Length;

            var radTemp = 2.0 * Math.PI / (double)dataCount;

            for (int i = 0; i < dataCount; i++)
            {
                data[i] *= (0.42 - 0.5 * Math.Cos(radTemp * (double)i) + 0.08 * Math.Cos(2.0 * radTemp * (double)i));
            }
        }

    }
}
