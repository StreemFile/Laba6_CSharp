using System;

namespace Laba6
{
    public class MatrixInt
    {
        private int[,] arrayInt;
        private int n;
        private int m;
        private int codeError;
        private static int numberOfMatrixes = 0;

        public MatrixInt()
        {
            n = 1;
            m = 1;
            arrayInt = new int[n, m];
            arrayInt[0, 0] = 0;
            numberOfMatrixes++;
        }

        public MatrixInt(int n, int m)
        {
            this.n = n;
            this.m = m;
            arrayInt = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arrayInt[i, j] = 0;
                }
            }

            numberOfMatrixes++;
        }

        public MatrixInt(int n, int m, int value)
        {
            this.n = n;
            this.m = m;
            arrayInt = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arrayInt[i, j] = value;
                }
            }

            numberOfMatrixes++;
        }

        ~MatrixInt()
        {
            Console.WriteLine("Matrix was destructed");
        }

        public int[,] ArrayInt
        {
            get => arrayInt;
        }

        public int N
        {
            get => n;
        }

        public int M
        {
            get => m;
        }

        public int CodeError
        {
            get => codeError;
            set => codeError = value;
        }

        public static int NumberOfMatrixes
        {
            get => numberOfMatrixes;
        }

        public override string ToString()
        {
            string str = "Array: \n";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    str += arrayInt[i, j] + "\t";
                }

                str += "\n";
            }

            str += "\nn: " + n;
            str += "\nm: " + m;
            str += "\ncodeError: " + codeError;
            return str;
        }

        public void SetArrayElements(int value)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arrayInt[i, j] = value;
                }
            }
        }

        public void SetArrayElements(int[,] value, int n, int m)
        {
            if (this.n != n || this.m != m)
            {
                this.n = n;
                this.m = m;
                arrayInt = new int[n, m];
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arrayInt[i, j] = value[i, j];
                }
            }
        }

        public int this[int i, int j]
        {
            get
            {
                codeError = 0;
                if (i > n || j > m)
                {
                    codeError = -1;
                    return 0;
                }

                return arrayInt[i, j];
            }
            set
            {
                codeError = 0;
                if (i > n || j > m)
                {
                    codeError = -1;
                    return;
                }

                arrayInt[i, j] = value;
            }
        }

        public int this[int k]
        {
            get
            {
                codeError = 0;
                if (k > n * m)
                {
                    codeError = -1;
                    return 0;
                }

                bool flag = false;
                int index = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (index == k)
                        {
                            return arrayInt[i,j];
                        }

                        index++;
                    }
                }
                return 0;
            }
            set
            {
                codeError = 0;
                if (k > n * m)
                {
                    codeError = -1;
                    return ;
                }
                int index = 0;
                for (int i = 0; i < n; i++)
                {
                    bool flag = false;
                    for (int j = 0; j < m; j++)
                    {
                        if (index == k)
                        {
                            arrayInt[i,j] = value;
                            flag = true;
                            break;
                        }
                    }
                    if (flag) break;
                    index++;
                }
            }
        }

        public static MatrixInt operator ++(MatrixInt matrix)
        {
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    matrix[i, j]++;
                }
            }

            return matrix;
        }

        public static MatrixInt operator --(MatrixInt matrix)
        {
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    matrix[i, j]--;
                }
            }

            return matrix;
        }

        public static bool operator true(MatrixInt array)
        {
            bool elementsNotZero = false;
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    if (array[i, j] != 0)
                    {
                        elementsNotZero = true;
                        break;
                    }
                }
            }

            return array.n != 0 && array.m != 0 || elementsNotZero;
        }

        public static bool operator false(MatrixInt array)
        {
            throw new NotImplementedException();
        }

        public static bool operator !(MatrixInt array)
        {
            return array.n != 0 && array.m != 0;
        }

        public static MatrixInt operator ~(MatrixInt array)
        {
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] = ~array[i, j];
                }
            }

            return array;
        }

        public static MatrixInt operator +(MatrixInt array, int value)
        {
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] += value;
                }
            }

            return array;
        }

        public static MatrixInt operator +(MatrixInt array, MatrixInt array2)
        {
            if (array.n != array2.n || array.m != array2.m)
            {
                throw new InvalidOperationException("Матриці різного розміру!");
            }

            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] += array2[i, j];
                }
            }

            return array;
        }

        public static MatrixInt operator -(MatrixInt array, int value)
        {
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] -= value;
                }
            }

            return array;
        }

        public static MatrixInt operator -(MatrixInt array, MatrixInt array2)
        {
            if (array.n != array2.n || array.m != array2.m)
            {
                throw new InvalidOperationException("Матриці різного розміру!");
            }

            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] -= array2[i, j];
                }
            }

            return array;
        }

        public static MatrixInt operator *(MatrixInt array, int value)
        {
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] *= value;
                }
            }

            return array;
        }

        public static MatrixInt operator *(MatrixInt array, MatrixInt array2)
        {
            if (array.n != array2.n || array.m != array2.m)
            {
                throw new InvalidOperationException("Матриці різного розміру!");
            }

            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] *= array2[i, j];
                }
            }

            return array;
        }

        public static MatrixInt operator /(MatrixInt array, int value)
        {
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] /= value;
                }
            }

            return array;
        }

        public static MatrixInt operator /(MatrixInt array, MatrixInt array2)
        {
            if (array.n != array2.n || array.m != array2.m)
            {
                throw new InvalidOperationException("Матриці різного розміру!");
            }

            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] /= array2[i, j];
                }
            }

            return array;
        }

        public static MatrixInt operator %(MatrixInt array, int value)
        {
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] %= value;
                }
            }

            return array;
        }

        public static MatrixInt operator %(MatrixInt array, MatrixInt array2)
        {
            if (array.n != array2.n || array.m != array2.m)
            {
                throw new InvalidOperationException("Матриці різного розміру!");
            }

            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] %= array2[i, j];
                }
            }

            return array;
        }

        public static MatrixInt operator |(MatrixInt array, int value)
        {
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] |= value;
                }
            }

            return array;
        }

        public static MatrixInt operator |(MatrixInt array, MatrixInt array2)
        {
            if (array.n != array2.n || array.m != array2.m)
            {
                throw new InvalidOperationException("Матриці різного розміру!");
            }

            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] |= array2[i, j];
                }
            }

            return array;
        }

        public static MatrixInt operator &(MatrixInt array, int value)
        {
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] &= value;
                }
            }

            return array;
        }

        public static MatrixInt operator &(MatrixInt array, MatrixInt array2)
        {
            if (array.n != array2.n || array.m != array2.m)
            {
                throw new InvalidOperationException("Матриці різного розміру!");
            }

            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] &= array2[i, j];
                }
            }

            return array;
        }

        public static MatrixInt operator ^(MatrixInt array, int value)
        {
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] ^= value;
                }
            }

            return array;
        }

        public static MatrixInt operator ^(MatrixInt array, MatrixInt array2)
        {
            if (array.n != array2.n || array.m != array2.m)
            {
                throw new InvalidOperationException("Матриці різного розміру!");
            }

            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] ^= array2[i, j];
                }
            }

            return array;
        }

        public static MatrixInt operator >>(MatrixInt array, int value)
        {
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] >>= value;
                }
            }

            return array;
        }

        public static MatrixInt operator <<(MatrixInt array, int value)
        {
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    array[i, j] <<= value;
                }
            }

            return array;
        }

        public static bool operator ==(MatrixInt array, MatrixInt array2)
        {
            bool result = true;
            if (array.n != array2.n || array.m != array2.m) return false;
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    if (array[i, j] != array2[i, j])
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        public static bool operator !=(MatrixInt array, MatrixInt array2)
        {
            return !(array == array2);
        }

        public static bool operator >=(MatrixInt array, MatrixInt array2)
        {
            int sum = 0;
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    sum += array[i, j];
                }
            }

            int sum2 = 0;
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    sum2 += array2[i, j];
                }
            }

            return sum >= sum2;
        }

        public static bool operator <=(MatrixInt array, MatrixInt array2)
        {
            int sum = 0;
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    sum += array[i, j];
                }
            }

            int sum2 = 0;
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    sum2 += array2[i, j];
                }
            }

            return sum <= sum2;
        }

        public static bool operator >(MatrixInt array, MatrixInt array2)
        {
            int sum = 0;
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    sum += array[i, j];
                }
            }

            int sum2 = 0;
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    sum2 += array2[i, j];
                }
            }

            return sum > sum2;
        }

        public static bool operator <(MatrixInt array, MatrixInt array2)
        {
            int sum = 0;
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    sum += array[i, j];
                }
            }

            int sum2 = 0;
            for (int i = 0; i < array.n; i++)
            {
                for (int j = 0; j < array.m; j++)
                {
                    sum2 += array2[i, j];
                }
            }

            return sum < sum2;
        }
    }
}