/*
 Write a program which accept matrix and return largest number from both the
diagonals
Input :
		3   2   5   9
        4   3   2   2
        8   4   1   9
        3   9   7   5
		11  12  13  14
		21  22  23  24
		31  32  33  34
		41  42  43  44

		Diagonal:- 1
		 11
            22
			   33
			       44  
        Diagonal:- 2
		           14
                23
             32
          41
Output : 9

*/

using System;
namespace MatrixBase
{
class MaxDiagonal:Matrix
    {
        public MaxDiagonal(int iRow, int iCol) :base(iRow, iCol)
        { 
        
        }
        public int FindMaxDiagonal()
        {
			int iRet=0;
			int MaxDiagonal1=0;
			int MaxDiagonal2=0;
            for (int i = 0; i <iMatrix.Length; i++)
            {
                for (int j = 0; j <iMatrix[i].Length; j++)
                {
                    if (i==j)
                    {
                      if (iMatrix[i][j]>MaxDiagonal1)
                      {
                       MaxDiagonal1=iMatrix[i][j];
					  }
                    }
                }
            }
			//int k=0;
			for (int i = 0; i <iMatrix.Length; i++)
            {
                for (int j = 0; j < iMatrix[i].Length; j++)
                {
				/*
				 while (k!=iMatrix.Length-1)
                 {
                  if ((i==k)&&(j==iMatrix[i].Length-k))
                 {
                  if (iMatrix[i][j]>MaxDiagonal2)
                      {
                       MaxDiagonal2=iMatrix[i][j];
					  }
				 }
				  k++;
				 }
				 */
                 if ((i==0)&&(j==iMatrix[i].Length))
                 {
                  if (iMatrix[i][j]>MaxDiagonal2)
                      {
                       MaxDiagonal2=iMatrix[i][j];
					  }
				 }
				 if ((i==1)&&(j==(iMatrix[i].Length-i)))
                 {
                  if (iMatrix[i][j]>MaxDiagonal2)
                      {
                       MaxDiagonal2=iMatrix[i][j];
					  }
				 }
				 if ((i==2)&&(j==(iMatrix[i].Length-i)))
                 {
                  if (iMatrix[i][j]>MaxDiagonal2)
                      {
                       MaxDiagonal2=iMatrix[i][j];
					  }
				 }
				 if ((i==3)&&(j==(iMatrix[i].Length-i)))
                 {
                  if (iMatrix[i][j]>MaxDiagonal2)
                      {
                       MaxDiagonal2=iMatrix[i][j];
					  }
				 }
                }
				//k++;
            }
            if (MaxDiagonal1>MaxDiagonal2)
            {
             iRet=MaxDiagonal1;
			}
			else
			{
			 iRet=MaxDiagonal2;
			}
            return iRet;
        }
        static void Main(string[] args)
        {
            int iRow = 0;
            int iCol = 0;
            Console.WriteLine("Largest number from the diagonals in the Matrix");
            Console.Write("Enter number of rows:: ");
            iRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns:: ");
            iCol = Convert.ToInt32(Console.ReadLine());
            MaxDiagonal obj = new MaxDiagonal(iRow, iCol);
            obj.Accept();
            obj.Display();
            int iRet = obj.FindMaxDiagonal();
            Console.WriteLine("Largest number from the diagonals is {0}",iRet);
            Console.ReadLine();
        }
    };
};