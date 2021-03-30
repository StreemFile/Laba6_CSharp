using System;

namespace Laba6
{
    public class VectorInt
    {
        private int[] array;
        private uint size;
        private int codeError;
        private static uint numberOfVectors = 0;

        public VectorInt()
        {
            size = 1;
            array = new int[size];
            array[0] = 0;
            numberOfVectors++;
        }

        public VectorInt(uint size)
        {
            this.size = size;
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = 0;
            }
            numberOfVectors++;
        }
        public VectorInt(uint size, int value)
        {
            this.size = size;
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = value;
            }
            numberOfVectors++;
        }

         ~VectorInt()
         {
             Console.WriteLine("Vector was destructed");
         }

        public int[] Array
        {
            get => array;
        }

        public uint Size
        {
            get => size;
        }

        public int CodeError
        {
            get => codeError;
            set => codeError = value;
        }

        public static uint NumberOfVectors
        {
            get => numberOfVectors;
        }

        public int this[uint index]
        {
            get
            {
                codeError = 0;
                if (index > size)
                {
                    codeError = -1;
                    return 0;
                }
                return array[index];
            }
            set
            {
                codeError = 0;
                if (index > size)
                {
                    codeError = -1;
                    return ;
                }
                array[index] = value;
            }
        }

        public void SetArrayElements(int value)
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = value;
            }
        }
        public void SetArrayElements(int[] value)
        {
            if (value.Length > size)
            {
                size = (uint) value.Length;
                array = new int[size];
            }
            
            for (int i = 0; i < value.Length; i++)
            {
                array[i] = value[i];
            }
        }
        public override string ToString()
        {
            string str = "\nArray: ";
            for (int i = 0; i < size; i++)
            {
                str += array[i] + ", ";
            }
            str = str.Remove(str.LastIndexOf(","));
            str += "\nsize: " + size;
            str += "\ncodeError: " + codeError;
            return str;
        }

        public static VectorInt operator ++(VectorInt vector)
        {
            for (uint i = 0; i < vector.size; i++)
            {
                vector[i]++;
            }
            return vector;
        }
        
        public static VectorInt operator --(VectorInt vector)
        {
            for (int i = 0; i < vector.size; i++)
            {
                vector.array[i]--;
            }
            return vector;
        }

        public static bool operator true(VectorInt vector)
        {
            bool elementsNotZero = false;
            for (int i = 0; i < vector.size; i++)
            {
                if (vector.array[i] != 0)
                {
                    elementsNotZero = true;
                    break;
                }
            }
            return vector.size != 0 || elementsNotZero;
        }

        public static bool operator false(VectorInt vector)
        {
            throw new NotImplementedException();
        }
        
        public static bool operator !(VectorInt vector)
        {
            return vector.size != 0;
        }

        public static VectorInt operator ~(VectorInt vector)
        {
            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] = ~vector[i];
            }

            return vector;
        }

        public static VectorInt operator +(VectorInt vector, int value)
        {
            for (uint i = 0; i < vector.size; i++)
            {
                vector[i]+= value;
            }
            return vector;
        }
        
        public static VectorInt operator +(VectorInt vector, VectorInt vector2)
        {
            if(vector.size != vector2.size) throw new InvalidOperationException("Вектори різного розміру!");
            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] += vector2[i];    
            }
            return vector;
        }
        
        public static VectorInt operator -(VectorInt vector, int value)
        {
            for (uint i = 0; i < vector.size; i++)
            {
                vector[i]-= value;
            }
            return vector;
        }
        
        public static VectorInt operator -(VectorInt vector, VectorInt vector2)
        {
            if(vector.size != vector2.size) throw new InvalidOperationException("Вектори різного розміру!");
            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] -= vector2[i];
            }
            return vector;
        }
        
        public static VectorInt operator *(VectorInt vector, int value)
        {
            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] *= value;
            }
            return vector;
        }
        
        public static VectorInt operator *(VectorInt vector, VectorInt vector2)
        {
            if(vector.size != vector2.size) throw new InvalidOperationException("Вектори різного розміру!");

            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] *= vector2[i];
            }
            return vector;
        }
        
        public static VectorInt operator /(VectorInt vector, int value)
        {
            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] /= value;
            }
            return vector;
        }
        
        public static VectorInt operator /(VectorInt vector, VectorInt vector2)
        {
            if(vector.size != vector2.size) throw new InvalidOperationException("Вектори різного розміру!");

            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] /= vector2[i];
            }
            return vector;
        }
        
        public static VectorInt operator %(VectorInt vector, int value)
        {
            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] %= value;
            }
            return vector;
        }
        
        public static VectorInt operator %(VectorInt vector, VectorInt vector2)
        {
            if(vector.size != vector2.size) throw new InvalidOperationException("Вектори різного розміру!");

            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] %= vector2[i];
            }
            return vector;
        }
        
        public static VectorInt operator |(VectorInt vector, int value)
        {
            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] |= value;
            }
            return vector;
        }
        
        public static VectorInt operator |(VectorInt vector, VectorInt vector2)
        {
            if(vector.size != vector2.size) throw new InvalidOperationException("Вектори різного розміру!");

            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] |= vector2[i];
            }
            return vector;
        }
        
        public static VectorInt operator &(VectorInt vector, int value)
        {
            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] &= value;
            }
            return vector;
        }
        
        public static VectorInt operator &(VectorInt vector, VectorInt vector2)
        {
            if(vector.size != vector2.size) throw new InvalidOperationException("Вектори різного розміру!");

            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] &= vector2[i];
            }
            return vector;
        }
        
        public static VectorInt operator ^(VectorInt vector, int value)
        {
            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] ^= value;
            }
            return vector;
        }
        
        public static VectorInt operator ^(VectorInt vector, VectorInt vector2)
        {
            if(vector.size != vector2.size) throw new InvalidOperationException("Вектори різного розміру!");

            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] ^= vector2[i];
            }
            return vector;
        }
         
        public static VectorInt operator >>(VectorInt vector, int value)
        {
            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] >>= value;
            }
            return vector;
        }
        
        public static VectorInt operator <<(VectorInt vector, int value)
        {
            for (uint i = 0; i < vector.size; i++)
            {
                vector[i] <<= value;
            }
            return vector;
        }
        
        public static bool operator ==(VectorInt vector, VectorInt vector2)
        {
            bool result = true;
            if (vector.size != vector2.size) return false;
            for (uint i = 0; i < vector.size; i++)
            {
                if (vector[i] != vector2[i])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public static bool operator !=(VectorInt vector, VectorInt vector2)
        {
            return !(vector == vector2);
        }
        
        public static bool operator >=(VectorInt vector, VectorInt vector2)
        {
            int sum = 0;
            for (uint i = 0; i < vector.size; i++)
            {
                sum += vector[i];
            }
            int sum2 = 0;
            for (uint i = 0; i < vector2.size; i++)
            {
                sum2 += vector2[i];
            }

            return sum >= sum2;
        }

        public static bool operator <=(VectorInt vector, VectorInt vector2)
        {
            int sum = 0;
            for (uint i = 0; i < vector.size; i++)
            {
                sum += vector[i];
            }
            int sum2 = 0;
            for (uint i = 0; i < vector2.size; i++)
            {
                sum2 += vector2[i];
            }

            return sum <= sum2;
        }
        
        public static bool operator >(VectorInt vector, VectorInt vector2)
        {
            int sum = 0;
            for (uint i = 0; i < vector.size; i++)
            {
                sum += vector[i];
            }
            int sum2 = 0;
            for (uint i = 0; i < vector2.size; i++)
            {
                sum2 += vector2[i];
            }

            return sum > sum2;
        }

        public static bool operator <(VectorInt vector, VectorInt vector2)
        {
            int sum = 0;
            for (uint i = 0; i < vector.size; i++)
            {
                sum += vector[i];
            }
            int sum2 = 0;
            for (uint i = 0; i < vector2.size; i++)
            {
                sum2 += vector2[i];
            }

            return sum < sum2;
        }
    }
}