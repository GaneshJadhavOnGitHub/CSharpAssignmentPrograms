/*
Write a program which accept matrix and check whether the matrix is
Sparse matrix or not.
Sparse matrix is a matrix with the majority of its elements equal to zero.
Input :
		1 0 0 0
		0 1 0 0
		0 0 1 0
		0 0 0 1
Output : True

Input :
1 0 3 0
0 6 0 0
0 0 1 0
9 0 0 9
Output : True
*/

using System;
namespace MatrixBase
{
class Sparse:Matrix
    {
        public Sparse(int iRow, int iCol) :base(iRow, iCol)
        { 
        
        }
        public bool CheckSparse()
        {
			bool bRet=false;
			int iCnt=0;
			int MaxReach=((iMatrix.Length)*(iMatrix.Length))/2; //((4*4)/2)=(16)/2=8.
			Console.WriteLine("------------------------");
            for (int i = 0; i <iMatrix.Length; i++)
            {
				for (int j = 0; j <iMatrix[i].Length; j++)
                {
				 if (iMatrix[i][j]==0)
				 {
				  iCnt++;
				 }
				}
                Console.WriteLine("");
            }
			if (iCnt>MaxReach)
			{
			 bRet=true;
			}
			return bRet;
		}
        static void Main(string[] args)
        {
            int iRow = 0;
            int iCol = 0;
            Console.WriteLine("Check Sparse Matrix");
            Console.Write("Enter number of rows:: ");
            iRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns:: ");
            iCol = Convert.ToInt32(Console.ReadLine());
            Sparse obj = new Sparse(iRow,iCol);
            obj.Accept();
            obj.Display();
            bool bRet=obj.CheckSparse();
			Console.WriteLine(bRet);
            Console.ReadLine();
        }
    };
};