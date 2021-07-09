/*
Write C Sharp program which accept number of rows and number of columns
from user and display below pattern.
Input : iRow = 3 iCol = 4
Output : 1 2 3 4
		 5 6 7 8
		 9 10 11 12
*/

using System;

public class Pattern
{
 public void Display(int iRow, int iCol)
 {
  int iNo=1;
  for (int i=1;i<=iRow;i++)
  {
   for (int j=1;j<=iCol;j++)
   {
    Console.Write("{0} ",iNo);
	iNo++;
   }
	Console.WriteLine("");
  }
 }
}; //End of class

public static class Assignment50Program5
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
}; //End of class Assignment50Program5