using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop 
{
	class Program
	{
		static void Main(string[]args)
		{
			Console.Title = "Lucky Number Loop";
			Console.WriteLine("Input a number between 1-10");

			string myNumber = Console.ReadLine();

			while(myNumber != "")
			{


				int result;
				bool IsValid = int.TryParse(myNumber, out result);
				//validation step below
				if(IsValid && result <= 10 && >= 0)
				{

					result = result * 7;
					Console.WriteLine("Your lucky number is" + result + "\n");
					Console.WriteLine("Input a number between 0-10");
					myNumber = Console.ReadLine();

				}
				else
				{

					Console.WriteLine("Your input is invalid." + "\n");
					Console.WriteLine("Input a number between 0-10");
					myNumber = Console.Readline();

				}
			}
		}
	}
}

//step 1: ask user to enter a number between 1 - 10.
//step 2: Take user input and multiply by 7 to output lucky number.
//step 3: Do step 1 && step 2 until user exits the application. 
