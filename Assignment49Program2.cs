/*
Write a program which accepts 2 strings from user and check whether
contents of two strings are equal or not.
Input : Marvellous Infosystems
Marvellous Infosystems
 Output : TRUE
*/

using System;

public class StringDemo
{
 public bool StrCmpX(string str1, string str2)
 {
  bool bRet=false;
  int i=0;
  int iSize1=str1.Length;
  int iSize2=str2.Length;
  char[] arr1=new char[iSize1];
  char[] arr2=new char[iSize2];
  arr1=str1.ToCharArray();
  arr2=str2.ToCharArray();

  if (iSize1!=iSize2)
  {
   bRet=false;
  }
  else if(iSize1==iSize2)
  {
   for (i=0;i<iSize1;i++)
   {
    if (arr1[i]!=arr2[i])
    {
     bRet=false;
	 break;
	}
   }
   if (i==iSize1)
   {
    bRet=true;
   }
  }
  return bRet;
 }
};//End of class StringDemo.

public static class Assignment49Program2
{
 public static void Main(string[] args)
 {
  string str1, str2;
  bool bRet=false;
  StringDemo sobj= new StringDemo();
  Console.WriteLine("Enter String 1 :: ");
  str1=Console.ReadLine();
  Console.WriteLine("Enter String 2 :: ");
  str2=Console.ReadLine();
  bRet=sobj.StrCmpX(str1, str2);
  Console.WriteLine(bRet);
 } //End of Main.
}; //End of class Assignment49Program2

