/*
Write a program which accept matrix from user and display transpose of the
matrix.
The transpose of a given matrix is formed by interchanging the rows and
columns of a matrix.
Input :
3 2 5 9
4 3 2 2
8 4 1 5
3 9 7 5
Output :
3 4 8 3
2 3 4 9
5 2 1 7
9 2 5 5
*/

using System;
namespace MatrixBase
{
class Transpose:Matrix
    {
        public Transpose(int iRow, int iCol) :base(iRow, iCol)
        { 
        
        }
        public void DisplayTranspose()
        {
			Console.WriteLine("Transpose of Matrix");
			int[][] iTranspose=new int[iRow][];
			for (int i=0;i<iRow;i++)
             {
               iTranspose[i]=new int[iCol];
             }
            for (int i = 0; i <iMatrix.Length; i++)
            {
				for (int j = 0; j <iMatrix[i].Length; j++)
                {
				 iTranspose[j][i]=iMatrix[i][j];
				}
		    }
          for (int i = 0; i <iMatrix.Length; i++)
            {
				for (int j = 0; j <iMatrix[i].Length; j++)
                {
				  Console.Write("  "+iTranspose[i][j]+"   ");
				}
				Console.WriteLine("");
		    }


		}
        static void Main(string[] args)
        {
            int iRow = 0;
            int iCol = 0;
            Console.WriteLine("Transpose of a Matrix");
            Console.Write("Enter number of rows:: ");
            iRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns:: ");
            iCol = Convert.ToInt32(Console.ReadLine());
            Transpose obj = new Transpose(iRow,iCol);
            obj.Accept();
            obj.Display();
            obj.DisplayTranspose();
			//obj.Display();
            Console.ReadLine();
        }
    };
};