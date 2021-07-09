/*
Write a program which accepts 2 strings from user and check whether
first N contents of two strings are equal or not.
Note : If third parameter is greater than the size of second string
then compare whole strings.
Input : Marvellous Infosystems
Marvellous Logic Building
10
Output : TRUE
*/

using System;
public class StringDemo
{
 public bool StringNCmpX(string str1, string str2,int iNo)
 {
  bool bRet=false;
  int i=0;
  int iSize1=str1.Length;
  int iSize2=str2.Length;
  char[] arr1= new char[iSize1];
  char[] arr2= new char[iSize2];
  arr1=str1.ToCharArray();
  arr2=str2.ToCharArray();
 /* if ((iSize1<iSize2)&&(iNo>=iSize1))
  {
   iNo=iSize1;
  }
  */
  if (iNo>=iSize2)
  {
   iNo=iSize2;
  }
  for (i=0;i<iNo;i++)
  {
   if (arr1[i]!=arr2[i])
   {
    bRet=false;
	break;
   }
  }
  if (i==iNo)
  {
   bRet=true;
  }
  return bRet;
 } //End of method StringNCmpX
}; //End of class StringDemo


public static class Assignment49Program3
{
 public static void Main(string[] args)
 {
  string str1, str2;
  int iNo=0;
  bool bRet;
  StringDemo sobj=new StringDemo();
  Console.WriteLine("Enter String 1 ::");
  str1=Console.ReadLine();
  Console.WriteLine("Enter String 2 ::");
  str2=Console.ReadLine();
  Console.WriteLine("Enter Number of Characters to compare ::");
  iNo=Convert.ToInt32(Console.ReadLine());
  bRet=sobj.StringNCmpX(str1,str2,iNo);
  Console.WriteLine(bRet);
 }
}