/*
Write C Sharp program which accept number of rows and number of columns
from user and display below pattern.
Input : iRow = 4 iCol = 5
Output : 4  4  4  4  4
		 3  3  3  3  3
		 2  2  2  2  2
		 1  1  1  1  1

		 11 12 13 14 15
		 21 22 23 24 25
		 31 32 33 34 35
		 41 42 43 44 45
*/

using System;

class Pattern
{
 public void Display(int iRow, int iCol)
 {
  int iNo=iRow;
  for (int i=1;i<=iRow;i++)
  {
   for (int j=1;j<=iCol;j++)
   {
    Console.Write("{0} ",iNo);
   }
   Console.WriteLine("");
   iNo--;
  }
 }
};// end of class

public static class Assignment50Program4
{
 public static void Main(string[] args)
 {
   int iRow=0;
   int iCol=0;
   Pattern pobj=new Pattern();
   Console.Write("Enter number of Rows :: ");
   iRow=Convert.ToInt32(Console.ReadLine());
   Console.Write("Enter number of Columns :: ");
   iCol=Convert.ToInt32(Console.ReadLine());
   pobj.Display(iRow,iCol);
 }
}; //End of class Assignment50Program4