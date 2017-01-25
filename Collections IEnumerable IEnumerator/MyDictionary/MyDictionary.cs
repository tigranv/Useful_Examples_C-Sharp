using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue> : IEnumerable<object>, IEnumerator<object>
    {
        private readonly TKey[] key;
        private readonly TValue[] value;
        private readonly int lenght;

        int position = -1;

        # region Свойство длинны коллекции
        public int Lenght
        {
            get { return lenght; }
        }
        #endregion

        #region constructor
        public MyDictionary(int n)
        {
            key = new TKey[n];
            value = new TValue[n];
            lenght = n;
        }
        #endregion

        #region indexer
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index];
                return "Index out of range";
            }
        }
        #endregion

        #region Methot for adding key-value
        public void Add(int i, TKey k, TValue l)
        {
            key[i] = k;
            value[i] = l;
        }
        #endregion

        #region Realisation IEnumerator<T>
        public bool MoveNext()
        {
            if (position < key.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get { return key[position] + " " + value[position]; }
        }

        object IEnumerator.Current
        {
            get { return key[position] + " " + value[position]; }
        }
        #endregion

        #region Realisation IEnumerable<T>

        public IEnumerator<object> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public void Dispose()
        {
            Reset();
        }

        #endregion
    }
}
