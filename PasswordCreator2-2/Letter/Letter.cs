using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreator22
{
	public class Letter //子クラス(Num,Upper,Mark,Lower)に共通の機能を付けている
						//親クラスがRandomクラスのインスタンスを受ける
	{
		protected Random random; //protectedは子クラスが使用できるようにするための修飾子
		public Letter(Random random) //コンストラクター
		{
			this.random = random;	//引数の値をprotected変数に格納
		}
		public virtual string GetLetter() //子クラスはこのメソッドを使える
		{
			return string.Empty; //戻り値
		}
	}
}
