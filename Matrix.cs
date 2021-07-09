/*This is base class used for Matrix operations
 It accepts and displays a Matrix
 command to create DLL
 CSC /target:library /out:Matrix.dll Matrix.cs

*/
using System;

namespace MatrixBase
{
 public class Matrix
 {
  public int iRow;
  public int iCol;
  public int[][] iMatrix;
  Matrix()
  {
  }
  public Matrix(int iRow, int iCol)
  {
   this.iRow=iRow;
   this.iCol=iCol;
   iMatrix=new int[iRow][];
   for (int i=0;i<iRow;i++)
   {
    iMatrix[i]=new int[iCol];
   }
  }
  ~Matrix()
  {
   iMatrix=null;
  }
  public void Accept()
  {
   Console.WriteLine("Enter Elements of Matrix :: ");
   for (int i=0;i<iMatrix.Length;i++)
   {
    for (int j=0;j<iMatrix[i].Length;j++)
    {
     Console.Write("Enter Element of  [Row {0} Column {1}] :: ",i+1,j+1);
	 iMatrix[i][j]=Convert.ToInt32(Console.ReadLine());
	}
	Console.WriteLine("");
   }
  }
  public void Display()
  {
   Console.WriteLine("");
   //Console.WriteLine("Elements of Matrix are");
   Console.WriteLine("");
   for (int i=0;i<iMatrix.Length;i++)
   {
    for (int j=0;j<iMatrix[i].Length;j++)
    {
	 Console.Write("  "+iMatrix[i][j]+"  ");
	}
	Console.WriteLine("");
   }
	}
 };//End of class Matrix
}; //End of Namespace