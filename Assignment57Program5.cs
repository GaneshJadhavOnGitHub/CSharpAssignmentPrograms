/*
Write a C Sharp program which accept number of rows and number of
columns from user and display below pattern.
Input : iRow = 4 iCol = 4
Output:
        1   2   3   4   5
		1   2           5
        1       3       5
        1           4   5
		1   2   3   4   5
		
		11  12  13  14  15
		21  22  23  24  25
		31  32  33  34  35
		41  42  43  44  45
		51  52  53  54  55

		
*/

using System;

public class Pattern
{
  public void Display(int iRow, int iCol)
 { 
  int iSize=iRow;	  
  for (int i=1;i<=iRow+1;i++)
  {
   for (int j=1;j<=iCol+1;j++)
   {
    if (i==j)
	{
     Console.Write(i+" ");
	}
	else if ((i==1)||(i==iSize+1)||(j==1)||(j==iSize+1))
	{
	 Console.Write(j+" ");
	}
    /*
	else if ((i==1)||(i==iSize+1))
    {
     Console.Write(j+" ");
	}
	else if ((j==1)||(j==iSize+1))
	{
	 Console.Write(j+" ");
	}
	*/
	//else if((i!=j)&&(i!=1)&&(i!=iSize+1)&&(j!=1)&&(j!=iSize+1)&&(i+j>=iSize+1))
    else //if((i+j)>=iSize+1)
	{
	 Console.Write("  ");  //Use two blank spaces here. One space is blank and another one is blank space between two elements.
	}
   }
   Console.WriteLine("");
  }
 }
}; //End of class Pattern

public static class Assignment57Program5
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