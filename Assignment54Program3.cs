/*
Write C Sharp program which accept number of rows and number of
columns from user and display below pattern.
Input : iRow = 3 iCol = 5
Output : 5 4 3 2 1
		 5 4 3 2 1
		 5 4 3 2 1
*/

using System;

public class Pattern
{
  public void Display(int iRow, int iCol)
 { 
  for (int i=1;i<=iRow;i++)
  {
   for (int j=iCol;j>=1;j--)
   {
	Console.Write(" {0} ",j);
   }
   Console.WriteLine("");
  }
 }
}; //End of class Pattern

public static class Assignment54Program3
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
}; //End of class