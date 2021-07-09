/*
Write C Sharp program which accept N numbers from user and return
difference between summation of even elements and summation of
odd elements.
Input : N : 6
Elements : 85 66 3 80 93 88
Output : 53 (234 - 181)
*/

using System;

class ArrayDemo
{
 public int Difference(int[] arr)
 {
	 
  int iDiff=0;
  int iSumEven=0;
  int iSumOdd=0;
  int i=0;
  int iLength=arr.Length;
try
	{
  for(i=0;i<iLength;i++) 
  {
   if ((arr[i]%2)==0)
   {
    iSumEven=iSumEven+arr[i];
   }
   else if ((arr[i]%2)!=0)
   {
    iSumOdd=iSumOdd+arr[i];
   }
  }
  iDiff=iSumEven-iSumOdd;
}
catch (IndexOutOfRangeException ex)
 {
  throw ex;
 }
 return iDiff;
 }//End of Difference
};
public static class DifferenceBetweenSummation
{
 public static void Main(string[] args)
 {
 try{
  int iSize=0;
  int iRet=0;
  ArrayDemo aobj=new ArrayDemo();
  Console.WriteLine("Enter number of elements:- ");
  iSize=Convert.ToInt32(Console.ReadLine());
  int[] Arr=new int[iSize];
  Console.WriteLine("Enter Numbers:- ");
  for (int i=0;i<iSize;i++)
  {
   Console.WriteLine("Enter number{0}",i+1);
   Arr[i]=Convert.ToInt32(Console.ReadLine());
  }
  for (int i=0;i<iSize;i++)
  {
   //Console.WriteLine("Enterd Number{0} is {1}",i+1,Arr[i]);
  }
	iRet=aobj.Difference(Arr);
	Console.WriteLine("Difference between summation of even elements and summation of odd elements is : {0}",iRet);
 }
  catch (System.IndexOutOfRangeException ex)
  {
   throw ex;
  }
 }
};

