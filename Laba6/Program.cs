using System;
using System.Reflection;

namespace Laba6
{
    class Program
    {
        static void Main(string[] args)
        {
            // One();
            // Two();
            Three();
        }

        static void One()
        {
            Console.WriteLine("Введіть координату х: ");
            int coordinateX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть координату у: ");
            int coordinateY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть колір точки: ");
            string color = Convert.ToString(Console.ReadLine());

            Point point = new Point(coordinateX, coordinateY, color);
            Console.WriteLine(point.ToString());
            Console.WriteLine("-----------INDEXATOR-----------");
            Console.WriteLine("Enter index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(point[index]);
            Console.WriteLine("-----------PLUSPLUS-----------");
            point++;
            Console.WriteLine(point.ToString());
            Console.WriteLine("-----------MINUSMINUS-----------");
            point--;
            Console.WriteLine(point.ToString()); 
            Console.WriteLine("-----------PLUS-----------");
            Console.WriteLine("Enter value: ");
            int plusValue = Convert.ToInt32(Console.ReadLine());
            point += plusValue;
            Console.WriteLine(point.ToString()); 
            Console.WriteLine("-----------MINUS-----------");
            Console.WriteLine("Enter value: ");
            int minusValue = Convert.ToInt32(Console.ReadLine());
            point -= minusValue;
            Console.WriteLine(point.ToString());
            Console.WriteLine("-----------TRUE/FALSE-----------");
            Console.WriteLine(point ? "x == y" : "x != y");
            Console.WriteLine("-----------FromString-----------");
            string body = CreatePointBody();
            Console.WriteLine("STRING: " + body);
            Point point2 = Point.FromString(body);
            Console.WriteLine("POINT: " +  point2.ToString());
        }

        static string CreatePointBody()
        {
            Console.WriteLine("Enter x,y,color:");
            int coordinateX = Convert.ToInt32(Console.ReadLine());
            int coordinateY = Convert.ToInt32(Console.ReadLine());
            string color = Convert.ToString(Console.ReadLine());
            return coordinateX + "," + coordinateY + "," + color;
        }

        static void Two()
        {
            VectorInt vectorInt = new VectorInt(2,2);
            Console.WriteLine("-------------PRINT ARRAY-------------");
            Console.WriteLine(vectorInt.ToString());
            Console.WriteLine("-------------SET ELEMENTS [1]-------------");
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = i;
            }
            vectorInt.SetArrayElements(arr);
            Console.WriteLine(vectorInt.ToString());
            
            Console.WriteLine("-------------SET ELEMENTS [2]-------------");
            int value = 5;
            vectorInt.SetArrayElements(value);
            Console.WriteLine(vectorInt.ToString());
            
            Console.WriteLine("-------------GET NUMBER OF VECTORS-------------");
            Console.WriteLine("number of vectors: " + VectorInt.NumberOfVectors);
            
            Console.WriteLine("-------------INDEXER-------------");
            vectorInt[0] = 12;
            Console.WriteLine(vectorInt.ToString());
            
            Console.WriteLine("-------------PLUSPLUS-------------");
            vectorInt++;
            Console.WriteLine(vectorInt.ToString()); 
            
            Console.WriteLine("-------------MINUSMINUS-------------");
            vectorInt--;
            Console.WriteLine(vectorInt.ToString());

            Console.WriteLine("-------------TRUE/FALSE-------------");
            Console.WriteLine(vectorInt.ToString());
            Console.WriteLine(!vectorInt ? "TRUE" : "FALSE");
            
            
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(~vectorInt);

            Console.WriteLine("-------------PLUS-------------");
            vectorInt += new VectorInt(5,3);
            Console.WriteLine(vectorInt.ToString());
            Console.WriteLine(VectorInt.NumberOfVectors);
            
            Console.WriteLine("-------------MINUS-------------");
            vectorInt -=3;
            Console.WriteLine(vectorInt.ToString());

            Console.WriteLine("****************************");
            Console.WriteLine(vectorInt * new VectorInt(5, -2));

            Console.WriteLine("/////////////////////////////");
            Console.WriteLine(vectorInt / new VectorInt(5, 2));
            
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            Console.WriteLine(vectorInt % 5);
            
            Console.WriteLine("|||||||||||||||||||||||||||||");
            Console.WriteLine(vectorInt | 5);
            
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine(vectorInt & 2); 
            
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine(vectorInt ^ 4);
            
            Console.WriteLine("--------------- >> ---------------");
            Console.WriteLine(vectorInt >> 1);

            Console.WriteLine("--------------- << ---------------");
            Console.WriteLine(vectorInt << 1);

            Console.WriteLine("--------------- == ---------------");
            Console.WriteLine(vectorInt == new VectorInt(5,2));
            
            Console.WriteLine("--------------- >= and <= ---------------");
            Console.WriteLine(vectorInt <= vectorInt);


            Console.WriteLine("--------------- > and < ---------------");
            Console.WriteLine(vectorInt > vectorInt);




        }

        static void Three()
        {
            MatrixInt matrixInt = new MatrixInt(2,2,3);
            Console.WriteLine("-------------PRINT ARRAY-------------");
            Console.WriteLine(matrixInt.ToString());
            
            Console.WriteLine("-------------SET ELEMENTS [1]-------------");
            int[,] arr  = new int[3,3];
            int number = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = number;
                    number++;
                }
            }
            matrixInt.SetArrayElements(arr,3,3);
            Console.WriteLine(matrixInt.ToString());
            
            Console.WriteLine("-------------SET ELEMENTS [2]-------------");
            int value = 5;
            matrixInt.SetArrayElements(value);
            Console.WriteLine(matrixInt.ToString());

            Console.WriteLine("-------------GET NUMBER OF MATRIXES-------------");
            Console.WriteLine("number of vectors: " + MatrixInt.NumberOfMatrixes);
            
            Console.WriteLine("-------------INDEXER-------------");
            matrixInt[0] = 9;
            Console.WriteLine(matrixInt.ToString());
            
            Console.WriteLine("-------------PLUSPLUS-------------");
            matrixInt++;
            Console.WriteLine(matrixInt.ToString()); 
            
            Console.WriteLine("-------------MINUSMINUS-------------");
            matrixInt--;
            Console.WriteLine(matrixInt.ToString());
            
            Console.WriteLine("-------------TRUE/FALSE-------------");
            Console.WriteLine(matrixInt.ToString());
            Console.WriteLine(!matrixInt ? "TRUE" : "FALSE");
            
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(~matrixInt);

            Console.WriteLine("-------------PLUS-------------");
            matrixInt += new MatrixInt(3,3,2);
            Console.WriteLine(matrixInt.ToString());

            Console.WriteLine("-------------MINUS-------------");
            matrixInt -=3;
            Console.WriteLine(matrixInt.ToString());
            
            Console.WriteLine("****************************");
            Console.WriteLine(matrixInt * new MatrixInt(3,3,-2));

            Console.WriteLine("/////////////////////////////");
            Console.WriteLine(matrixInt / new MatrixInt(3,3,5));
            
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
            Console.WriteLine(matrixInt % 3);
            
            Console.WriteLine("|||||||||||||||||||||||||||||");
            Console.WriteLine(matrixInt | 5);
            
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            Console.WriteLine(matrixInt & 2); 
            
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine(matrixInt ^ 4);
            
            Console.WriteLine("--------------- >> ---------------");
            Console.WriteLine(matrixInt >> 1);

            Console.WriteLine("--------------- << ---------------");
            Console.WriteLine(matrixInt << 1);
            
            Console.WriteLine("--------------- == ---------------");
            Console.WriteLine(matrixInt == new MatrixInt(5,2));
            
            Console.WriteLine("--------------- >= and <= ---------------");
            Console.WriteLine(matrixInt <= matrixInt);


            Console.WriteLine("--------------- > and < ---------------");
            Console.WriteLine(matrixInt > matrixInt);

        }
    }
}