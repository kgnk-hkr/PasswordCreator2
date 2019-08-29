using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator22
{
	public interface ILetterFactory //インターフェイスを使ってAllLetterとNonMarkとMark2をグループ化する
	{
		Letter Create(Random random, int i);
	}
}
