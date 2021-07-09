/*
Write C Sharp program which accept number of rows and number of
columns from user and display below pattern.
Input : iRow = 6 iCol = 6
Output : 
		 *   *   *   *   *   *
         *               *   *
         *           *       *
         *       *           *
         *   *               *
         *   *   *   *   *   *

		 11  12  13  14  15  16
		 21  22  23  24  25  26
		 31  32  33  34  35  36
		 41  42  43  44  45  46
		 51  52  53  54  55  56
		 61  62  63  64  65  66


*/

using System;

public class Pattern
{
  public void Display(int iRow, int iCol)
 { 
  int iSize=iRow;	  
  for (int i=1;i<=iRow;i++)
  {
   for (int j=1;j<=iCol;j++)
   {
	if ((i+j==iSize+1)&&(j!=1)&&(j!=iSize))  
     //Condition to locate elements at secondary diagonal. 
	//(j!=1)&&(j!=iSize)) is to reduce one extra *. 
	//Borderline condition and secondary conditions both are met so one extra * is printed.
	{
	 Console.Write("* ");
	}
	if((i==1)||(i==iSize)||(j==1)||(j==iSize-1))  //Condition to display borderline elements.
	{
	 Console.Write("* ");
	}
	else       //this else part is very important it prints blank spaces.
	{
    Console.Write("  ");	
  	}
   }
   Console.WriteLine("");
  }
 }
}; //End of class Pattern

public static class Assignment57Program3
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