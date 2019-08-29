using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator22
{
	public abstract class LetterFactory //AllLetterとNonMarkLetterどちらを使うか選ぶためのもの
	{
		public abstract Letter Create(Random random, int i); //抽象メソッドにするためのなので処理は書かない
	}
}
