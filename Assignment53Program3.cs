/*
Write C Sharp program which accept number of rows and number of columns
from user and display below pattern.
Input : iRow = 3 iCol = 5
Output : A   A   A   A   A
         B   B   B   B   B
		 C   C   C   C   C

		 11  12  13  14  15
		 21  22  23  24  25
		 31  32  33  34  35
*/

using System;

public class Pattern
{
 public void Display(int iRow, int iCol)
 {
  char c='A';
  for (int i=1;i<=iRow;i++)
  {
   for (int j=1;j<=iCol;j++)
   {
    Console.Write("{0} ",c);
   }
   Console.WriteLine("");
   c++;
  }
 }
}; //End of class

public static class Assignment50Program3
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
}; //End of class Assignment50Program3