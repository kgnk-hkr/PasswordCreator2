using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator22
{
	public class MarkLetter:Letter　//記号をランダムで返す
	{
		public MarkLetter(Random random) : base(random)
		{
		}
		public override string GetLetter()
		{
			string[] mark = { "!", "#", "$", "%", "&", "@" };
			int n = random.Next(mark.Length);
			return mark[n];
		}
	}
}
