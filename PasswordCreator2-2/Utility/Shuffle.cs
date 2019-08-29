using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator22
{
	public class Shuffle	//文字列をランダムに並び替えるクラス
	{
		public static string Execute(string password)
		{
			char x =' '; //変数の初期化
			string res = string.Empty;
			int c = 0;
			char[] pws = password.ToArray(); //文字列を配列にする
			Random random = new Random();
			//以下並び替えの処理
			while(c < password.Length) //passwordの長さ以下の回数で繰り返す
			{
				int n = random.Next(password.Length);
				if (pws[n] != x)	//未選択の場合
				{
					res += pws[n]; //配列に格納
					pws[n] = x; //選択済みの設定
					c++; //インクリメント(ループ防止)
				}
			}
			return res;
		}
	}
}
