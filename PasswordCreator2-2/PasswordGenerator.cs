using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator22
{
	public class PasswordGenerator
	{
		private Random random;
		public PasswordGenerator(Random random)
		{
			this.random = random;
		}

		public string MakePassword(int count,ILetterFactory factory) //MakePasswordに引数を持たせることで継承してくるインスタンスを指定する。変数factoryを用意してそこに
		{
			string password = string.Empty;
			//各子クラスのメソッドを呼び出している
			//Letter letter = new NumLetter(random); //継承なので親クラスの型を持つ変数に子クラスのインスタンスを格納できる
			//password += letter.GetLetter(); //このGetLetterは親クラスのもの？
			//letter = new LowerLetter(random);
			//password += letter.GetLetter();
			//letter = new UpperLetter(random);
			//password += letter.GetLetter();
			//letter = new MarkLetter(random);
			//password += letter.GetLetter();

			for (int i = 0; i < count; i++)
			{
				//AllLetterFactory factory = new AllLetterFactory();　//AllLetterFactoryを呼び出す
				//NonMarkLetterFactory factory = new NonMarkLetterFactory();　//NonMarkLetterFactoryを呼び出す
				Letter letter = factory.Create(random, i);
				password += letter.GetLetter();
			}
			//Shuffle shuffle = new Shuffle();
			//return Shuffle.Execute(password);
			return ArrangeEnd.Execute(Shuffle.Execute(password)); //ランダム配列の呼び出しした上で末尾を記号にする
		}

		//private string GetNumLetter()
		//{
		//	return random.Next(10).ToString();
		//}
		//private string GetLowerLetter()
		//{
		//	char c = (char)random.Next(97, 123);
		//	return c.ToStirng();
		//}
		//private string GetUpperLetter()
		//{
		//	char c = (char)random.Next(65,91);
		//	return c.ToStirng();
		//}
		//private string GetMarkLetter()
		//{
		//	string[] mark = { "!", "#", "$", "%", "&", "@" };
		//	int n = random.Next(mark.Length);
		//	return mark[n];
		//}
	}
}
