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

        
        public WeatherList(WeatherList w)
        {
            this._head = w._head;
            while(w._head != null)
            {
                this.Add(_head.Data);
                w._head = w._head.Next;
            }
            
            //throw new NotImplementedException();
        }









        public void FilterRange(DateTime dt, DateTime dt2)
        {
            Node<WeatherData> temp = _head;
            while (temp != null)
            {
                if(temp.Data.DateCheck<dt || _head.Data.DateCheck > dt2)
                {
                    this.Remove(temp.Data);
                }
                temp = temp.Next;
            }
        }

        public void FilterTemp(double x, int button)
        {
            Node<WeatherData> temp = _head;
            while (temp != null)
            {
                if(temp.Data.Temperature > x && button == 1)
                {
                    this.Remove(temp.Data);
                }
                else if(temp.Data.Temperature<x && button == 0)
                {
                    this.Remove(temp.Data);
                }
                temp = temp.Next;
            }
            //throw new NotImplementedException();
        }

        public void FilterDateHistory(DateTime dt)
        {
            Node<WeatherData> temp = _head;
            while(temp != null)
            {
                if(temp.Data.month!=dt.Month || temp.Data.day != dt.Day)
                {
                    this.Remove(temp.Data);
                }
                temp = temp.Next;
            }


            //throw new NotImplementedException();
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
