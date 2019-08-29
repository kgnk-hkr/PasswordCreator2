using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator22
{
	public class UpperLetter : Letter //ランダムに英大文字１文字を返す方法
	{
		public UpperLetter(Random random) : base(random)
		{
		}
		public override string GetLetter()
		{
			//文字に制限を設けない場合
			//char c = (char)random.Next(65, 91);
			//return c.ToString();

			//O,Iを使用しない場合
			//配列による調整方法
			//string[] uppers = { "A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
			//int n = random.Next(uppers.Length);
			//return uppers[n];


			//繰り返し処理で調整する方法
			//nが73(I),79(O)の時はランダムで選ぶ動作を繰り返す
			int n;
			do
			{
				n = random.Next(65, 91);
			} while (n == 73 || n == 79);
			char c = (char)n;
			return c.ToString();
		}
	}
}
