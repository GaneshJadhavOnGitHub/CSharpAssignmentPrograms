/*
Write a program which accept matrix and swap the contents of consecutive rows.
Input :
		3   2   5   9
        4   3   2   2
        8   4   1   9
        3   9   7   5

Output :
        4 3 2 2
		3 2 5 9
		3 9 7 5
		8 4 1 9
		
		00  01  02  03
		10  11  12  13
		20  21  22  23
		30  31  32  33
		
*/
using System;
namespace MatrixBase
{
class Swap:Matrix
    {
        public Swap(int iRow, int iCol) :base(iRow, iCol)
        { 
        
        }
        public void SwapRows()
        {
		 int temp=0;
         for (int k=0;k<iMatrix.Length-1;k++) //for 4 rows we have to use swap function 2 times.
         {
          if ((k%2)==0)  //If row is even. Swap elements of even (0th) row with odd row (row1)... and  So on...
          {
           for (int j = 0; j < iMatrix.Length; j++)
           {
            temp = iMatrix[k][j];
            iMatrix[k][j] = iMatrix[k+1][j];
            iMatrix[k+1][j] = temp;
           }
		  }
		 }
	      
		}
        static void Main(string[] args)
        {
            int iRow = 0;
            int iCol = 0;
            Console.WriteLine("Swap Consecutive rows of the Matrix");
            Console.Write("Enter number of rows:: ");
            iRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns:: ");
            iCol = Convert.ToInt32(Console.ReadLine());
            Swap obj = new Swap(iRow, iCol);
            obj.Accept();
            obj.Display();
			Console.WriteLine("");
            Console.WriteLine("After swapping Consecutive Rows");
            obj.SwapRows();
			obj.Display();
            Console.ReadLine();
        }
    };
};