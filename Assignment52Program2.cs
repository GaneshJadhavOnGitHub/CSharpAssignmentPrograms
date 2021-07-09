/*
 Write a program which accept matrix and reverse the contents of each row.
Input :
3 2 5 9
4 3 2 2
8 4 1 9
3 9 7 5
Output :
9 5 2 3
2 2 3 4
9 1 4 8
5 7 9 3
*/

using System;
namespace MatrixBase
{
class Reverse:Matrix
    {
        public Reverse(int iRow, int iCol) :base(iRow, iCol)
        { 
        
        }
        public void RowReverse()
        {
			Console.WriteLine("After Reversing Rows of the Matrix");
            for (int i = 0; i <iMatrix.Length; i++) //For each row
            {
		      int Begin = 0;                  //Begin at first element of the row
              int End = iMatrix[i].Length - 1;//End at last element of the row
			  while (Begin < End)           
			  {  //Swap
				 int temp=iMatrix[i][Begin];
				 iMatrix[i][Begin]=iMatrix[i][End];
                 iMatrix[i][End]=temp; 
                 Begin++;          //Increment Begin
                 End--;            //Decrement End
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
            obj.RowReverse();
			obj.Display();
            Console.ReadLine();
        }
    };
};