using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class GenericsPractice<T>
    {
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
            {
                _data[index] = item;
            }
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
            {
                return _data[index];
            }
            else
                return default(T);
        }
    }
}
