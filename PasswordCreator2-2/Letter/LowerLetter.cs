using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator22
{
	public class LowerLetter : Letter //ランダムに英小文字を1文字返す
	{
		public LowerLetter(Random random) : base(random)
		{
		}
		public override string GetLetter()
		{
			//文字に制限を設けない場合
			//char c = (char)random.Next(97, 123);
			//return c.ToString();

			//lを使用しない場合

			//配列で調整する方法
			//string[] lowers = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
			//int n = random.Next(lowers.Length);
			//return lowers[n];

			/*
			//繰り返し処理で調整する方法
			int n;
			do
			{
				n = random.Next(97, 123);
			}
			while (n == 108);
			char c = (char)n;
			return c.ToString();
			*/

			//LINQで処理する方法
			string[] lowers = Enumerable.Range(97, 26).Where(x => x != 108).Select(x => ((char)x).ToString()).ToArray();
			int n = random.Next(lowers.Length);
			return lowers[n];


		}
	}
}
