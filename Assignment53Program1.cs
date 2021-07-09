/*
 Write c sharp program which accept number of rows and number of columns
from user and display below pattern.
Input : iRow = 4 iCol = 4
Output : A B C D
		 A B C D
		 A B C D
		 A B C D

		 11 12 13 14
		 21 22 23 24
		 31 32 33 34
		 41 42 43 44
*/

using System;

public class Pattern
{
  public void Display(int iRow, int iCol)
 { 
  for (int i=1;i<=iRow;i++)
  {
   char c='A';
   for (int j=1;j<=iCol;j++)
   {
	Console.Write("{0} ",c);
	c++;
   }
   Console.WriteLine("");
  }
 }
}; //End of class Pattern

public static class Assignment50Program1
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
}; //End of class Assignment50Program1