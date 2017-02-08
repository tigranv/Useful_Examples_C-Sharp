using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Collection : IEnumerable //, IEnumerator
    {
        int[] array = null;

        public Collection()
        {
            array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * i;
            }
        }

        

        int position = -1;

        public void Reset()
        {
            position = -1;
        }

        //public object Current
        //{
        //    get { return array[position]; }
        //}        

        //public bool MoveNext()
        //{
        //    if (position < array.Length-1)
        //    {
        //        position++;
        //        return true;    
        //    }
        //    else
        //    {
        //        Reset();
        //        return false;
        //    }
        //}


        // no need of MoveNext() an Current() if you use yield
        public IEnumerator GetEnumerator()
        {
            while (true)
            {
                if (position < array.Length - 1)
                {
                    position++;
                    yield return array[position];
                }
                else
                {
                    Reset();
                    yield break;      
                }

            };
        }
    }
}
