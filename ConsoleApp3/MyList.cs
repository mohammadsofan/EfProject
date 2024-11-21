using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class MyList<T>:System.Collections.IEnumerable
    {
        private T[] List;

        public void add(T item)
        {
            if(this.List == null)
            {
                List = new T[] {item};

            }
            else
            {
                T[] dist = new T[this.List.Length + 1];
                for(int i = 0; i < List.Length; i++)
                {
                    dist[i] = this.List[i];

                }
                dist[dist.Length - 1] = item;
                this.List = dist;
            }
        }

        public void remove(int position)
        {
            if (position < 0 || position > List.Length - 1) return;
            if (List == null || List.Length == 0) return;
            T[] dist = new T[List.Length - 1];

            for(int i = 0,j=0; i < List.Length; i++)
            {
                if (position == i) continue;
                dist[j++] = List[i];

            }
            List = dist;

        }
        public T this[int index]
        {
            get
            {
                try
                {
                    return List[index];
                }
                catch(Exception e)
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (!(index < 0) && !( index > List.Length - 1))
                {
                    if (List != null && List.Length != 0)
                    {
                        List[index] = value;
                    }

                }
            }

        }
        public int Count => List.Length;
        public bool IsEmpty => List.Length==0 || List==null;
        public void print()
        {
            Console.Write("[ ");
            foreach(T item in List)
            {
                Console.Write(item+" ");
            }
            Console.Write("]");

            Console.WriteLine();
        }

        public IEnumerator GetEnumerator() => new Enumerator(this);
        class Enumerator : IEnumerator
        {
            int counter = -1;
            MyList<T> list;
            public Enumerator(MyList<T> list)
            {

                this.list = list;   

            }
            public object Current
            {
                get
                {
                    if (counter >= list.List.Length) throw new InvalidOperationException();
                    if(counter < 0 ) throw new InvalidOperationException();

                    return list.List[counter];
                }
            }

            public bool MoveNext()
            {
                if (counter >=list.List.Length) return false;
                return ++counter < list.List.Length;
            }

            public void Reset()
            {
                counter = -1;
            }
        }
    }
}
