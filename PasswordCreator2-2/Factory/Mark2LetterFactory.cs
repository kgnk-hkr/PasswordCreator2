using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator22
{
	public class Mark2LetterFactory: ILetterFactory
	{
		public Letter Create(Random random,int i)
		{
			if (i <= 1)
			{
				return new MarkLetter(random);
			}
			else
			{
				//int n = i % 3;
				//if (n == 0)
				//return new NumLetter(random);
				//if (n == 1)
				//return new LowerLetter(random);
				//if (n == 2)
				//return new UpperLetter(random);
				//return null;
				var factory = new NonMarkLetterFactory();
				return factory.Create(random, i);
			}
			throw new NotImplementedException();
		}
	}
}
