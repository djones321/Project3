using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class WeatherList : IEnumerable<WeatherData>, IList<WeatherData>
    {
        private Node<WeatherData> _head;
        private Node<WeatherData> _tail;
        private int _size;



        public WeatherList()
        {
            _head = null;
            _tail = null;
            _size = 0;
        }

        public int Count => _size;


        public void Add(WeatherData val)
        {
            Node<WeatherData> newNode = new Node<WeatherData>(val);
            if (_size == 0)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                _tail = newNode;
            }

            _size++;
            //throw new NotImplementedException();
        }

        //might have to start at head.next... 
        //or a million other possibilities if something doesn't work
        //check add and remove as well if problems occur
        public void CopyWeatherList()
        {
            if (_head == null)
            {
                return;
            }

            WeatherList w2 = new WeatherList();
            Node<WeatherData> cur = _head;
            while (cur != null)
            {
                w2.Add(cur.Data);
                cur.Next = _head.Next;
            }
            return;
            //throw new NotImplementedException();
        }

        public void FilterRange()
        {
            throw new NotImplementedException();
        }

        public void FilterTemp()
        {
            throw new NotImplementedException();
        }

        public void FilterDateHistory()
        {
            throw new NotImplementedException();
        }



        public IEnumerator<WeatherData> GetEnumerator()
        {
            return new ListEnumerator(_head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }











        public bool IsReadOnly => throw new NotImplementedException();

        public WeatherData this[int index]
        {
            get
            {
                if (_size < index - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                Node<WeatherData> cur = _head;
                int i = 0;
                while(cur != null)
                {
                    if (i == index)
                    {
                        return cur.Data;
                    }
                    cur = cur.Next;
                    i++;
                }
                return default(WeatherData);
            }
            set
            {
                if (_size < index - 1)
                {
                    Node<WeatherData> cur = _head;
                    int i = 0;
                    while(cur != null)
                    {
                        if (i == index)
                        {
                            cur.Data = value;
                            return;
                        }
                        cur = cur.Next;
                        i++;
                    }
                }
            }
        }


        public int IndexOf(WeatherData item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, WeatherData item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(WeatherData item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(WeatherData[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(WeatherData item)
        {
            if (_size == 0) return false;
            if (_head.Data.Equals(item))
            {
                _head = _head.Next;
                if(_head == null)
                {
                    _tail = null;
                }
                _size--;
                return true;
            }
            Node<WeatherData> temp = _head;
            while(temp.Next != null)
            {
                if (temp.Next.Data.Equals(item))
                {
                    temp.Next = temp.Next.Next;
                    if (temp.Next == null) _tail = temp;
                    _size--;
                    return true;
                }
                temp = temp.Next;
            }
            return false;
            //throw new NotImplementedException();
        }








        private class Node<WeatherData>
        {
            private WeatherData _data;
            private Node<WeatherData> _next;

            public Node(WeatherData d)
            {
                _data = d;
                _next = null;
            }

            public WeatherData Data
            {
                get
                {
                    return _data;
                }
                set
                {
                    _data = value;
                    return;
                }
            }

            public Node<WeatherData> Next
            {
                get
                {
                    return _next;
                }
                set
                {
                    _next = value;
                }
            }
        }












        private class ListEnumerator : IEnumerator<WeatherData>
        {
            private Node<WeatherData> _cur;

            public ListEnumerator(Node<WeatherData> first)
            {
                _cur = new Node<WeatherData>(default(WeatherData));
                _cur.Next = first;
            }

            public WeatherData Current
            {
                get
                {
                    return _cur.Data;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (_cur == null) return false;
                _cur = _cur.Next;
                if (_cur == null) return false;
                else return true;
            }

            public void Reset()
            {
            }
        }


    }
}
