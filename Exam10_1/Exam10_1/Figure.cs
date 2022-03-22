using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam10_1
{
	abstract class Figure : IFigureable
	{
		abstract public double Area();

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
