using System.Numerics;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace ImgCompare
{
    //Perceptual Hash Algorithm from https://github.com/coenm/ImageHash was used.
    public static class PHash
    {
        private const int SIZE = 64;
        private static readonly double Sqrt2DivSize = Math.Sqrt(2D/ SIZE);
        private static readonly double Sqrt2 = 1 / Math.Sqrt(2);
        private static List<Vector<double>>[]? _dctCoeffsSimd;

        private static List<Vector<double>>[] GenerateDCTCoeffsSimd()
        {
            List<Vector<double>>[] results = new List<Vector<double>>[SIZE];
            for (int coef = 0; coef < SIZE; coef++) {
                double[] singleResultRaw = new double[SIZE];
                for (int i = 0; i < SIZE; i++)
                {
                    singleResultRaw[i] = Math.Cos(((2.0 * i) + 1.0) * coef * Math.PI / (2.0 * SIZE));
                }

                List<Vector<double>> singleResultList = [];
                int stride = Vector<double>.Count;

                for(int i = 0; i < SIZE; i += stride)
                {
                    Vector<double> v = new Vector<double>(singleResultRaw,i);
                    singleResultList.Add(v);
                }
                results[coef] = singleResultList;
            }
            return results;
        }

        private static double CalculatedMedian64Values(IReadOnlyCollection<double> values)
        {
            return values.OrderBy(value => value).Skip(31).Take(2).Average();
        }

        private static void Dct1D_SIMD(double[] valuesRaw, double[,] coefficients, int ci, int limit = SIZE)
        {
            List<Vector<double>> valuesList = new List<Vector<double>>();
            int stride = Vector<double>.Count;
            _dctCoeffsSimd ??= GenerateDCTCoeffsSimd();

            for (int i = 0; i < valuesRaw.Length; i += stride)
            {
                valuesList.Add(new Vector<double>(valuesRaw, i));
            }
            for(int coef = 0; coef< limit; coef++)
            {
                for (int i = 0; i < valuesList.Count; i++)
                {
                    coefficients[ci, coef] += Vector.Dot(valuesList[i], _dctCoeffsSimd[coef][i]);
                }
                coefficients[ci, coef] *= Sqrt2DivSize;
                if (coef == 0)
                {
                    coefficients[ci, coef] *= Sqrt2;
                }
            }
        }
        public static ulong P_Hash (Image<Rgba32> image)
        {
            double[,] rows = new double[SIZE, SIZE];
            double[] sequence = new double[SIZE];
            double[,] matrix = new double[SIZE, SIZE];

            image.Mutate(img => img
                            .Resize(SIZE, SIZE)
                            .Grayscale(GrayscaleMode.Bt601)
                            .AutoOrient());

            for (int y = 0; y < SIZE; y++)
            {
                for (int x = 0; x < SIZE; x++)
                {
                    sequence[x] = image[x, y].R;
                }

                Dct1D_SIMD(sequence, rows, y);
            }

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < SIZE; y++)
                {
                    sequence[y] = rows[y, x];
                }

                Dct1D_SIMD(sequence, matrix, x, limit: 8);
            }

            double[] top8X8 = new double[SIZE];
            for(int y = 0; y < 8; y++)
            {
                for(int x = 0; x< 8; x++)
                {
                    top8X8[(y * 8) + x] = matrix[y, x];
                }
            }
            double median = CalculatedMedian64Values(top8X8);

            ulong mask = 1UL << (SIZE - 1);
            ulong hash = 0UL;

            for(int i = 0; i < SIZE; i++)
            {
                if (top8X8[i] > median)
                {
                    hash |= mask;
                }
                mask >>= 1;
            }

            return hash;
        }
    }
}
