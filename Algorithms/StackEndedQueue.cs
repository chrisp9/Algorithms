using System;

namespace Algorithms
{
    public class StackEndedQueue<T>
    {
        public int Length { get; private set; }

        private T[] _array;

        private int _stackPointer = 0;
        private int _queuePointer = 0;

        public StackEndedQueue(int size)
        {
            _array = new T[size];
            _stackPointer = 0;
            _queuePointer = _array.Length - 1;

            Length = 0;
        }

        public void Push(T item)
        {
            if (Length == _array.Length)
                throw new IndexOutOfRangeException("Collection is full");

            _array[_stackPointer] = item;
            _stackPointer = GetNext(_stackPointer);
            Length++;
        }

        public T Pop()
        {
            if (Length == 0)
            {
                throw new IndexOutOfRangeException("Collection is empty");
            }

            _stackPointer = GetPrevious(_stackPointer);
            var element = _array[_stackPointer];
            _array[_stackPointer] = default(T);

            Length--;
            return element;
        }

        public void Enqueue(T item)
        {
            if(Length == _array.Length)
            {
                throw new IndexOutOfRangeException("Collection is full");
            }

            _array[_queuePointer] = item;
            _queuePointer = GetPrevious(_queuePointer);
            Length++;
        }

        private int GetPrevious(int index)
        {
            return index > 0
                ? index - 1
                : _array.Length - 1;
        }

        private int GetNext(int index)
        {
            return index < _array.Length - 1
                ? index + 1
                : 0;
        }
    }
}
