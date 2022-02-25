//
//Write a program which checks whether 7th & 8th & 9th bit is On or OFF. 

using System;

namespace Application
{
	class Program1
	{
		public static void Main(String[] arg)
		{
			bool bRet = false;
			Lucifer obj = new Lucifer();
			obj.Accept();
			bRet = obj.CheckBit();

			if(bRet == true){
				Console.WriteLine("7th & 8th & 9th Bit is On");
			}
			else{
				Console.WriteLine(" Bit is OFF");
			}
		}
	}
}

class Number
{
	public int iNo;

	public void Accept()
	{
		Console.WriteLine("Enter Number : ");
		iNo = int.Parse(Console.ReadLine());
	}
}

class Lucifer : Number
{
	public bool CheckBit()
	{
		bool bAns = false;
		int iMask = 0x000001C0; 
		int iReuslt = 0;

		iReuslt = iNo & iMask;
		if(iReuslt == iMask)
		{
			bAns = true;
		}
		return bAns;
	}
}