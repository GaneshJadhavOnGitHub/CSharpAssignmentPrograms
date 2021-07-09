/*
Accept string from user and check whether the string is
palindrome or not without considering its case.
Input : 1abccBA1
Output : TRUE
*/

using System;
public class StringDemo
{
 public bool IsPalindrome(string str)
 {
  bool bRet=false;
  string sLowerCase=ConvertToLowerCase(str);
  int iSize=sLowerCase.Length;
  char[] arr = new char[iSize];
  arr=sLowerCase.ToCharArray();
  int i=0;
  for (i=0;i<(iSize/2);i++)
  {
   if (arr[i]!=arr[iSize-(i+1)])
   {
    bRet=false;
	break;
   }
  }
  if (i==(iSize/2))
  {
   bRet=true;
  }
  return bRet;
 } //End of Method

 public string ConvertToLowerCase(string str)
{
 int i=0;
 string sRet;
 int iSize=str.Length;
 char[] arr = new char[iSize];
 arr=str.ToCharArray();
 for (i=0;i<iSize;i++)
 {
  if ((arr[i]>='A')&&(arr[i]<='Z'))
  {
   int Capital=Convert.ToInt32(arr[i]);
   int Small=Capital+32;
   arr[i]=Convert.ToChar(Small);
  }
 }
sRet=new string(arr);
return sRet;
}

}; //End of class StringDemo

public static class Assignment49Program5
{
 public static void Main(string[] args)
 {
   string str;
   bool bRet=false;
   StringDemo sobj= new StringDemo();
   Console.WriteLine("Enter a string :: ");
   str=Console.ReadLine();
   bRet=sobj.IsPalindrome(str);
   Console.WriteLine(bRet);
 }//End of Main
}; //End of class Assignment49Program5