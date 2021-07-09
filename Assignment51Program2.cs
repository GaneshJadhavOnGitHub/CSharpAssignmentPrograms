/*
 Write a program which accept matrix and one number from user and return
frequency of that number.
Input :
Number : 9
		3 2 5 9
        4 3 2 2
        8 4 1 9
        3 9 7 5
Output : 3
*/

using System;
namespace MatrixBase
{
class Frequency:Matrix
    {
        public Frequency(int iRow, int iCol) :base(iRow, iCol)
        { 
        
        }
        public int CountFrequency(int iNo)
        {
			int iCnt=0;
            for (int i = 0; i < iMatrix.Length; i++)
            {
                for (int j = 0; j < iMatrix[i].Length; j++)
                {
                    if (iMatrix[i][j] == iNo)
                    {
                        iCnt++;
                    }
                }
            }
            return iCnt;
        }
        static void Main(string[] args)
        {
            int iRow = 0;
            int iCol = 0;
			int iNo=0;
            Console.WriteLine("Frequency of given number in the Matrix");
            Console.Write("Enter number of rows:: ");
            iRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns:: ");
            iCol = Convert.ToInt32(Console.ReadLine());
            Frequency obj = new Frequency(iRow, iCol);
            obj.Accept();
            obj.Display();
			Console.Write("Enter a number :: ");
			iNo=Convert.ToInt32(Console.ReadLine());
            int iRet = obj.CountFrequency(iNo);
            Console.WriteLine("Frequency of {0} in the Matrix is {1}",iNo,iRet);
            Console.ReadLine();
        }
    };
};