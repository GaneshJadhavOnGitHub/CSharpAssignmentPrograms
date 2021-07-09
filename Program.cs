/*
Write a program which accept matrix from user and return addition of diagonal
elements.
Input : 3 2 5 9
        4 3 2 2
        8 4 1 5
        3 9 7 5
Output : 12
This program is done using a DLL file Matrix.dll. So refer this dll in project.
 */

using System;
using MatrixBase; //To use Matrix.dll
namespace Assignment51Program1
{
    public class Client:Matrix
    {
        public Client(int iRow, int iCol) : base(iRow, iCol)
        {
            
        }
        public int AddDiagonal()
        {
            int iSum = 0;
            for (int i = 0; i < iMatrix.Length; i++)
            {
                for (int j = 0; j < iMatrix[i].Length; j++)
                {
                    if (i == j)
                    {
                        iSum = iSum + iMatrix[i][j];
                    }
                }
            }
            return iSum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int iRow = 0;
            int iCol = 0;
            Console.WriteLine("Addition of diagonal elements in the Matrix");
            Console.Write("Enter number of rows:: ");
            iRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns:: ");
            iCol = Convert.ToInt32(Console.ReadLine());
            Client dobj = new Client(iRow, iCol);
            dobj.Accept();
            dobj.Display();
            int iRet = dobj.AddDiagonal();
            Console.WriteLine("");
            Console.WriteLine("Addition of diagonal elements is {0}", iRet);
            Console.ReadLine();
        }
    }
}
