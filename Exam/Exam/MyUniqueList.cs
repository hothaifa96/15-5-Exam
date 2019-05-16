using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class MyUniqueList<T> where T : new()//updated with generics and Exceptions
    {

        List<T> list = new List<T>();

        public MyUniqueList()
        {

        }

        public bool Add(T item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                return true;
            }
            throw new ItemAlreadyExistExceptions();
            //return false;
        }

        public bool Remove(T item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                return true;
            }

            return false;
        }

        public T Peek(int index)
        {
            if (index < 0 && index >= list.Count)
            {
                throw new IndexOutOfRangeException();
            }
            return  (this.list[index] != null ? this.list[index] : throw new ItemNotFoundException());
        }

        public T this[int index]
        {
            
            get
            {
                if (index < 0 && index >=list.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return list[index];
            }
            set
            {

                if (list.Contains(value))
                {
                    throw  new ItemAlreadyExistExceptions();
                    //return;
                }
                list[index] = value;
            }
        }


    }
}
