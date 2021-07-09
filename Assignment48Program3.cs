/*
Write C Sharp program which accept N numbers from user and accept
one another number as NO , return index of last occurrence of that
NO.
Input : N : 6
NO: 66
Elements : 85 66 3 66 93 88
Output : 4
Input : N : 6
NO: 93
Elements : 85 66 3 66 93 88
Output : 5
Input : N : 6
NO: 12
Elements : 85 11 3 15 11 111
Output : Not present

*/

using System;

public class Number
{
 public int LastOccurance(int[] Arr, int iNo)
 {
   int iRet=-1;
   int iLength=Arr.Length;
   for (int i=iLength-1;i>=0;i--)
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

public static class Assignment46Program3
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
  iRet=nobj.LastOccurance(Arr,iNo);
  if (iRet!=-1)
  {
   Console.WriteLine("{0} Last Occurred at position {1}",iNo,iRet);
  }
  else
  {
   Console.WriteLine("{0} is not present in the given array.",iNo);
  }
  
 }//End of Main.
};