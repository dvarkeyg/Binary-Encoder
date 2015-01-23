using System;
//calss declaration
class DecimalToBinary
{
	//entry point of program, main method
	static void Main()
	{
		//varibale declaration using unsigned integer data types
		uint uintToBin, valDigitBit;
		//boolean data type for checking for valid entries
		bool check;

		Console.WriteLine("Binary Encoder\n");
		Console.Write("Enter an unsigned integer number: ");
		//checks the input provided by user to see if it is an
		// unsigned integer or not
		check = uint.TryParse(Console.ReadLine(), out uintToBin);
		if(check == false){
			Console.WriteLine("Invalid Entry");
			Console.Write("Please Enter a valid entry next time");
			//if the entry is invalid it exits the program
			Environment.Exit(0);
		}

		Console.Write("The binary encoding of {0} is ", uintToBin);

		valDigitBit = (uint)Math.Pow(2,31);
		//main loop that converts decimals to binary
		while(valDigitBit >=1)
		{
			//the loop starts at 2^31 and checks to see if the integer entered
			//by the use ris greater or smaller, if it is greater or equal to
			//the current power of 2 (starts at 2^31 and then decrements by 1)
			// it generates  a 1, else
			//it generates a 0
			//writes out the whole thing at the same time using Console.Write()
			if(uintToBin >= valDigitBit)
			{
				Console.Write(1);
				//subtracts current power of 2 from the value to be converted
				//and resaves it as the next value to be converted
				uintToBin -= valDigitBit;
			}
			else
				Console.Write(0);
			//divides the bit value by 2 to go to the next power of 2 in 
			//descending order (starts at 2^31 then goes to 2^30 ...)
			valDigitBit /=2;
		}
	}
}