using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator22
{
	public class NumLetter : Letter
	{
		public NumLetter(Random random) : base(random) //baseは親クラスのこと。親クラスに引数randomを送る
		
		{
		}
		public override string GetLetter() //親クラスで使われてるGetLetterメソッドを使う
		{
			return random.Next(10).ToString(); //10未満の数字を呼び出してstring型に変換
		}
	}
}
