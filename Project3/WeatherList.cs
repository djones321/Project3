using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class WeatherList : IEnumerable, IList
    {
        private Node _head;
        private Node _tail;
        private int _size;

        public WeatherList()
        {
            _head = null;
            _tail = null;
            _size = 0;
        }

        public WeatherList(WeatherList w)
        {
            _head = null;
            _tail = null;
            _size = w._size;
            int i = 0;
            Node temp = w._head;
            while (i < _size)
            {
                this.Add(temp.Data);
                temp = temp.Next;
                _size--;
                i++;
            }
        }

        public int Count => _size;



        public int Add(WeatherData val)
        {
            Node newNode = new Node(val);
            if (_head == null)
            {
                _head = newNode;
            }
            if (_tail == null)
            {
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                _tail = newNode;
            }

            _size++;
            return 1;
            //throw new NotImplementedException();
        }

        public void FilterTemp(double x, bool button)
        {
            Node temp = _head;
            int i = 0;
            while (i < _size)
            {
                if (temp.Data.Temperature < x && button)
                {
                    this.Remove(temp.Data);
                }
                else if (temp.Data.Temperature > x && !button)
                {
                    this.Remove(temp.Data);
                }
                temp = temp.Next;
                i++;
            }
            //throw new NotImplementedException();
        }

        public void FilterRange(DateTime dt, DateTime dt2)
        {
            Node temp = _head;
            while (temp != null)
            {
                if (temp.Data.DateCheck < dt || temp.Data.DateCheck > dt2)
                {
                    this.Remove(temp.Data);
                }
                if (temp.Data.DateCheck < dt || temp.Data.DateCheck > dt2)
                {
                    this.Remove(temp.Data);
                }
                temp = temp.Next;
            }
        }

        public void FilterDateHistory(DateTime dt)
        {
            Node temp = _head;
            while (temp != null)
            {
                if (temp.Data.month != dt.Month || temp.Data.day != dt.Day)
                {
                    this.Remove(temp.Data);
                }
                temp = temp.Next;
            }


            //throw new NotImplementedException();
        }



        public object this[int index] {
            get
            {
                if (_size < index - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                Node cur = _head;
                int i = 0;
                while (cur != null)
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
                    Node cur = _head;
                    int i = 0;
                    while (cur != null)
                    {
                        if (i == index)
                        {
                            cur.Data = (WeatherData)value;
                            return;
                        }
                        cur = cur.Next;
                        i++;
                    }
                }
            }
        }


        public bool IsReadOnly => throw new NotImplementedException();

        public bool IsFixedSize => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public int Add(object value)
        {
            return this.Add((WeatherData)value);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object item)
        {
            this.Remove((WeatherData)item);
        }

        public bool Remove(WeatherData item)
        {
            if (_size == 0) return false;
            if (_head.Data.Equals(item))
            {
                _head = _head.Next;
                if (_head == null)
                {
                    _tail = null;
                }
                _size--;
                return true;
            }
            Node temp = _head;
            while (temp.Next != null)
            {
                if (temp.Next.Data == item)
                {
                    temp.Next = temp.Next.Next;
                    if (temp.Next == null) _tail = temp;
                    _size--;
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }










        private class Node
        {
            private WeatherData _data;
            private Node _next;

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

            public Node Next
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
            private Node _cur;

            public ListEnumerator(Node first)
            {
                _cur = new Node(default(WeatherData));
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
