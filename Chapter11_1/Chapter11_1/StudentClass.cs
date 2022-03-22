using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11_1
{
	class StudentClass : IEnumerable
	{
		object[] classArray = new Object[];

		public IEnumerator GetEnumerator()
		{
			throw new NotImplementedException();
		}
		//학생들의 Enumerator를 반환해주는 Enumerator
		class StudentEnumerator : IEnumerator
		{
			public object Current => throw new NotImplementedException();

			public bool MoveNext()
			{
				throw new NotImplementedException();
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}
		}
	}
}
