using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator22
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Random random = new Random();
			int count = 20;
			//ILetterFactory factory = new AllLetterFactory(); //パスワード生成のルールを何にするかをここで決める
			ILetterFactory factory = new Mark2LetterFactory();
			PasswordGenerator generator = new PasswordGenerator(random);
			string password = generator.MakePassword(count,factory);
			Console.WriteLine(password);
			
			
		}
	}
}
