using System;
namespace StackOnObject.Properties
{
    public class MyStack<T>
    {
        private T[] _items;    //creat a new array


        public int Count { get; private set; }   // counter


        public int Capcity

        { get
            {
                return _items.Length;
            }
        }

        public MyStack()//default constructor!
        {
            const int defaultCapacity = 4;   //length without changing it == 4!
            _items = new T[defaultCapacity];

        }

        public MyStack(int capasity)   //constructor to give array.Length!
        {
            _items = new T[capasity];   //preventing our array to his changed Length|
        }

        public void Push(T item)   //ordinary pushing OBJECTS!!!
        {
            if (_items.Length == Count)
            {
                T[] largerArray = new T[Count * 2];

                Array.Copy(_items, largerArray, Count);

                _items = largerArray;
            }

            _items[Count++] = item;
        }

        public void Pop()
        {
            if (Count == 0)    //exception
            {
                throw new InvalidOperationException();
            }

            _items[--Count] = default;
        }

        public T Peek()
        {
            if (Count == 0)    //exception
            {
                throw new InvalidOperationException();
            }

            return _items[Count - 1];//return last obj!
        }
     }
}
