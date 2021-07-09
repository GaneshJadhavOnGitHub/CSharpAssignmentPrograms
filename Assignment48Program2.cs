/*
 Write C Sharp program which accept N numbers from user and accept
one another number as NO , return index of first occurrence of that
NO.
Input : N : 6
NO: 66
Elements : 85 66 3 66 93 88
Output : 2
Input : N : 6
NO: 12
Elements : 85 11 3 15 11 111
Output : Not Present
*/

using System;

public class Number
{
 public int FirstOccurance(int[] Arr, int iNo)
 {
   int iRet=-1;
   int iLength=Arr.Length;
   for (int i=0;i<iLength;i++)
   {
    if (Arr[i]==iNo)
    {
     iRet=i+1;
	 break;
	}
   }
   return iRet;
 }
};

public static class Assignment46Program2
{
 public static void Main(string[] args)
 {
  int iSize=0;
  int iRet=0;
  int iNo=0;
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
  Console.Write("Enter number::");
  iNo=Convert.ToInt32(Console.ReadLine());
  iRet=nobj.FirstOccurance(Arr,iNo);
  if (iRet!=-1)
  {
   Console.WriteLine("{0} First Occurred at position {1}",iNo,iRet);
  }
  else
  {
   Console.WriteLine("{0} is not present in the given array.",iNo);
  }
  
 }//End of Main.
};