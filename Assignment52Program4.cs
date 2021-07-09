/*
Write a program which accept matrix and check whether the matrix is
identity matrix or not.
Identity matrix is a square matrix with 1’s along the diagonal from upper left to
lower right and 0’s in all other positions.
If it satisfies the structure as explained before then the matrix is called as
identity matrix.
Input :
		1 0 0 0
		0 1 0 0
		0 0 1 0
		0 0 0 1
Output : 0
*/

using System;
namespace MatrixBase
{
class Identity:Matrix
    {
        public Identity(int iRow, int iCol) :base(iRow, iCol)
        { 
        
        }
        public bool CheckIdentity()
        {
			bool bRet=false;
			bool flag1=true;
			bool flag2=true;
			Console.WriteLine("------------------------");
            for (int i = 0; i <iMatrix.Length; i++)
            {
				for (int j = 0; j <iMatrix[i].Length; j++)
                {
				 if (i==j)
				 {
				  if (iMatrix[i][j]!=1)
				  {
				   flag1=false;
				  }
				 }
				 if (i!=j)
				 {
				  if (iMatrix[i][j]!=0)
				  {
				   flag2=false;
				  }
				 }
				}
				if ((flag1==true)&&(flag2==true))
				{
				 bRet=true;
				}
                Console.WriteLine("");
            }
			return bRet;
		}
        static void Main(string[] args)
        {
            int iRow = 0;
            int iCol = 0;
            Console.WriteLine("Check Identity Matrix");
            Console.Write("Enter number of rows:: ");
            iRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns:: ");
            iCol = Convert.ToInt32(Console.ReadLine());
            Identity obj = new Identity(iRow,iCol);
            obj.Accept();
            obj.Display();
            bool bRet=obj.CheckIdentity();
			Console.WriteLine(bRet);
            Console.ReadLine();
        }
    };
};