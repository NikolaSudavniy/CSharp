using System;
using System.Collections.Generic;

namespace MultiDimensionalArray
{
    class TornArray<T>
    {
        private T[] _array;
        public int Length { get; private set; }
        private static IOperations<T> operation;

        public TornArray()
        {
            Length = 0;
            _array = null;
        }

        public TornArray(int length)
        {
            _array = new T[length];
            Length = length;
        }

        public T this[int index]
        {
            get
            {
                if (index >= Length) throw new Exception("Out of range: class TornArray<T>:: public T this[int index] :: get.");
                return _array[index];
            }
            set
            {
                if (index >= Length) throw new Exception("Out of range: class TornArray<T>:: public T this[int index] :: get.");
                _array[index] = value;
            }
        }

        /// <summary>
        /// Increase array and add <i>element</i> in the end.
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            if (_array == null)
            {
                Length = 1;
                _array = new T[Length];
                _array[0] = element;
                return;
            }

            var temp = new T[Length];
            temp = (T[])_array.Clone();

            _array = new T[Length + 1];

            for (int i = 0; i < Length; i++)
                _array[i] = temp[i];

            _array[Length++] = element;
        }

        /// <summary>
        /// Increase array and add <i>element</i> in <i>index</i> position.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="index">position of new element. Can't be bigger, than Length + 1</param>
        public void Insert(T element, int index)
        {
            if (index > Length) throw new Exception("Out of range. class TornArray<T> :: public void Add(T element, int index).");

            if (_array == null)
            {
                Length = 1;
                _array = new T[Length];
                _array[0] = element;
                return;
            }

            var temp = new T[Length];
            temp = (T[])_array.Clone();

            _array = new T[++Length];

            for (int i = 0, j = 0; i < Length; i++)
                if (i == index)
                    _array[index] = element;
                else
                    _array[i] = temp[j++];
        }

        public void RemoveAll()
        {
            _array = null;
            Length = 0;
        }

        public void Remove(int index)
        {
            if (_array == null || index >= Length) return;

           // if (index >= Length) throw new Exception("Out of range. class TornArray<T> :: public void Add(T element, int index).");

            var temp = new T[Length];
            temp = (T[])_array.Clone();

            _array = new T[--Length];

            for (int i = 0, j = 0; i < Length + 1; i++)
                if (i != index)
                    _array[j++] = temp[i];
        }

        public void Remove(int indexStart, int indexEnd)
        {
            if (_array == null || indexEnd >= Length || indexStart < indexEnd) return;

            ///
        }

            /// <summary>
            /// Use object of strategy interface IOperations<T>
            /// </summary>
            /// <param name="a"> is a first operand in operation "+"</param>
            /// <param name="b"> is a second operand in operation "+"</param>
            /// <returns>Return object will have the Length as first parameter.</returns>
        public static TornArray<T> DoOperation(TornArray<T> a, TornArray<T> b)
        {
            return operation.DoOperation(a, b);
        }

        public static TornArray<T> operator +(TornArray<T> a, TornArray<T> b)
        {
            operation = new Sum<T>();
            return DoOperation(a, b);
        }

        public static TornArray<T> operator -(TornArray<T> a, TornArray<T> b)
        {
            operation = new Minus<T>();
            return DoOperation(a, b);
        }

        public static TornArray<T> operator *(TornArray<T> a, TornArray<T> b)
        {
            operation = new Multiply<T>();
            return DoOperation(a, b);
        }

        public static TornArray<T> operator /(TornArray<T> a, TornArray<T> b)
        {
            operation = new Divide<T>();
            return DoOperation(a, b);
        }

        public static bool operator true(TornArray<T> arr)
        {
            return arr.Length != 0;
        }

        public static bool operator false(TornArray<T> arr)
        {
            return arr.Length == 0;
        }

        public static bool operator ==(TornArray<T> a, TornArray<T> b)
        {
            if (a.Length != b.Length) return false;

            for (int i = 0; i < a.Length; i++)
                if ((dynamic)a[i] != (dynamic)b[i])
                    return false;

            return true;
        }

        public static bool operator !=(TornArray<T> a, TornArray<T> b)
        {
            if (a.Length != b.Length) return true;

            for (int i = 0; i < a.Length; i++)
                if ((dynamic)a[i] != (dynamic)b[i])
                    return true;

            return false;
        }

        public override bool Equals(object obj)
        {
            var array = obj as TornArray<T>;
            return array != null &&
                   EqualityComparer<T[]>.Default.Equals(this._array, array._array) &&
                   Length == array.Length;
        }

        public override int GetHashCode()
        {
            var hashCode = 1638756939;
            hashCode = hashCode * -1521134295 + EqualityComparer<T[]>.Default.GetHashCode(_array);
            hashCode = hashCode * -1521134295 + Length.GetHashCode();
            return hashCode;
        }
    }

    class ArrayOfTornArrays<T>
    {
        TornArray<T>[] array;
        int iCount;
        int Length { get; }

        public ArrayOfTornArrays(int index)
        {
            array = new TornArray<T>[index];
            Length = array.Length;
        }

        public TornArray<T> this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

    }
}
