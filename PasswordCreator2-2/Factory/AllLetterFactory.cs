using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator22
{
	public class AllLetterFactory:ILetterFactory　//インターフェイスの実装宣言
	{
		public Letter Create(Random random, int i)
		{
			//Letter letter = null;
			int n = i % 4; //nの順番の時にどのLetterから文字を持ってくるか
			if (n == 0) return new NumLetter(random);
			if (n == 1) return new LowerLetter(random);
			if (n == 2) return new UpperLetter(random);
			if (n == 3) return new MarkLetter(random);
			//return letter;
			return null; //なぜnull?
		}

	}
}
