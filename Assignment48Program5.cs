/*
Write C Sharp program which accept N numbers from user and return
product of all odd elements.
Input : N : 6
Elements : 15 66 3 70 10 88
Output : 45
Input : N : 6
Elements : 44 66 72 70 10 88
Output : 0
*/

using System;

public class Number
{
 public int ProductOdd(int[] Arr)
 {
   int i=0;
   int iLength=Arr.Length;
   int iMult=1;
   for (i=0;i<iLength;i++)
   {
    if ((Arr[i]%2)!=0)
    {
     iMult=iMult*Arr[i];
	 Assignment46Program5.flag=true; //Odd number is present.
	}
   }
   return iMult;
 }
};

public static class Assignment46Program5
{
 public static bool flag=false;  //Flag to check whether control entered in the if condition block in the ProductOdd Method.
 public static void Main(string[] args)
 {
  int iSize=0;
  int iRet=0;
  Number nobj=new Number();
  Console.Write("Enter number of elements: ");
  iSize=Convert.ToInt32(Console.ReadLine());
  int[] Arr=new int[iSize];
  Console.WriteLine("Enter Numbers:: ");
  for (int i=0;i<iSize;i++)
  {
   Console.Write("Enter Number{0}:: ",i+1);
   Arr[i]=Convert.ToInt32(Console.ReadLine());
  }
  Console.WriteLine("");
  iRet=nobj.ProductOdd(Arr);
  if (iRet!=1)
  {
   Console.WriteLine("Product of all odd numbers in the given array is :: {0}",iRet);
  }
  else if (iRet==1)
  {
    if (flag==false) //flag is false i.e. odd number is not present
    {
     Console.WriteLine("Odd number is not present in the array");
	}
	else
	{
	 Console.WriteLine("Product of all odd numbers in the given array is :: {0}",iRet);
	}
  }
 }//End of Main
};