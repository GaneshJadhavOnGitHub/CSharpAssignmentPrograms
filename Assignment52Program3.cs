/*
 Write a program which accept matrix and reverse the contents of each column.
Input :
3 2 5 9
4 3 2 2
8 4 1 9
3 9 7 5
Output :
3 9 7 5
8 4 1 9
4 3 2 2
3 2 5 9
*/

using System;
namespace MatrixBase
{
class Reverse:Matrix
    {
        public Reverse(int iRow, int iCol) :base(iRow, iCol)
        { 
        
        }
        public void ColReverse()
        {
			Console.WriteLine("After Reversing Colunms of the Matrix");
            for (int i = 0; i <iMatrix.Length; i++)
            {
		      int Begin = 0;
              int End = iMatrix.Length - 1;
			  while (Begin < End)
			  {
				 int temp=iMatrix[Begin][i];
				 iMatrix[Begin][i]=iMatrix[End][i];
                 iMatrix[End][i]=temp;
                 Begin++;
                 End--;
			  }
			}
		  }

   static void Main(string[] args)
        {
            int iRow = 0;
            int iCol = 0;
            Console.WriteLine("Matrix");
            Console.Write("Enter number of rows:: ");
            iRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns:: ");
            iCol = Convert.ToInt32(Console.ReadLine());
            Reverse obj = new Reverse(iRow,iCol);
            obj.Accept();
            obj.Display();
            obj.ColReverse();
			obj.Display();
            Console.ReadLine();
        }
    };
};