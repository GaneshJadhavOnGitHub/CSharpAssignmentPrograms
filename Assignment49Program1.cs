/*
Write a C Sharp program which accepts 2 strings from user and
concat N characters of second string after first string.Value of N
should be accepted from user.
Note : If third parameter is greater than the size of second string
then concat whole string after first string.
Input : Marvellous Infosystems
Logic Building
5
Output : “Marvellous Infosystems Logic”
*/

using System;

public class StringDemo
{
 public string StringNCatX(string src, string dest, int iNo)
 {
  string sRet;
  int iSizeArrOut=0;
  bool flag=false;
  int iSize1=src.Length;
  int iSize2=dest.Length;
  char[] arr1=new char[iSize1];
  char[] arr2=new char[iSize2];
  arr1=src.ToCharArray();
  arr2=dest.ToCharArray();
  if (iNo>=iSize2)              //Third parameter is greater than size of second string.
  {             
   iSizeArrOut=iSize1+1+iSize2;
   flag=true;
  }
  else if(iNo<iSize2)           //Third parameter is less than size of second string.
  {
   iSizeArrOut=iSize1+1+iNo;
   flag=false;
  }
  char[] arrConcatenated=new char[iSizeArrOut];
  for (int i=0;i<iSize1;i++)
  {
   arrConcatenated[i]=arr1[i];
  }
  arrConcatenated[iSize1]=' ';
  if (flag==true)
  {
   for (int i=0;i<iSize2;i++)
   {
    arrConcatenated[(iSize1+1+i)]=arr2[i];
   }
  }
  else if (flag==false)
  {
   for (int i=0;i<iNo;i++)
   {
    arrConcatenated[iSize1+1+i]=arr2[i];
   }
  }
  sRet=new string(arrConcatenated);
  return sRet;
 } //End of method
};//End of class StringDemo

public static class Assignment49Program1
{
 public static void Main(string[] args)
 {
  string str1, str2;
  int iNo=0;
  string sRet;
  StringDemo sobj=new StringDemo();
  Console.WriteLine("Enter String 1 ::");
  str1=Console.ReadLine();
  Console.WriteLine("Enter String 2 ::");
  str2=Console.ReadLine();
  Console.WriteLine("Enter Number of Characters to concat ::");
  iNo=Convert.ToInt32(Console.ReadLine());
  sRet=sobj.StringNCatX(str1,str2,iNo);
  Console.WriteLine("String after Concatenation::  {0}",sRet);
 }
}