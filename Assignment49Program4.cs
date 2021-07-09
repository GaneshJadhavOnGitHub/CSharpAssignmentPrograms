/*
Accept string from user and reverse the contents of that string
by toggling the case.
Input : aCBdef
Output : FEDbcA
*/

using System;

public class StringDemo
{
 public void Display(string str)
 {
   int i=0;
   int iSize=str.Length;
   char[] arr=new char[iSize];
   arr=str.ToCharArray();
   for (i=iSize-1;i>=0;i--)
   {
    if ((arr[i]>=65)&&(arr[i]<=90))
    {
	 int Capital=Convert.ToInt32(arr[i]);
	 int Small=Capital+32;
	 arr[i]=Convert.ToChar(Small);
	 Console.Write("{0}",arr[i]);
	}
	else if ((arr[i]>=97)&&(arr[i]<=122))
	{
	 int Small=Convert.ToInt32(arr[i]);
     int Capital=Small-32;
	 arr[i]=Convert.ToChar(Capital);
	 Console.Write("{0}",arr[i]);
	}
   }
 } //End of Method
}; //End of class StringDemo

public static class Assignment49Program4
{
 public static void Main(string[] args)
 {
  string str;
  StringDemo sobj=new StringDemo();
  Console.WriteLine("Enter String :: ");
  str=Console.ReadLine();
  sobj.Display(str);
 } //End of main
};//End of class