using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    interface IOperations<T>
    {
        TornArray<T> DoOperation(TornArray<T> a, TornArray<T> b);
    }

    class Sum<T> : IOperations<T>
    {
        public TornArray<T> DoOperation(TornArray<T> a, TornArray<T> b)
        {
            int lenght = a.Length < b.Length ? a.Length : b.Length;
            var result = new TornArray<T>(a.Length);

            for (int i = 0; i < lenght; i++)
                result[i] = (dynamic)a[i] + (dynamic)b[i];

            return result;
        }
    }

    class Minus<T> : IOperations<T>
    {
        public TornArray<T> DoOperation(TornArray<T> a, TornArray<T> b)
        {
            int lenght = a.Length < b.Length ? a.Length : b.Length;
            var result = new TornArray<T>(a.Length);

            for (int i = 0; i < lenght; i++)
                result[i] = (dynamic)a[i] + (dynamic)b[i];

            return result;
        }
    }

    class Multiply<T> : IOperations<T>
    {
        public TornArray<T> DoOperation(TornArray<T> a, TornArray<T> b)
        {
            int lenght = a.Length < b.Length ? a.Length : b.Length;
            var result = new TornArray<T>(a.Length);

            for (int i = 0; i < lenght; i++)
                result[i] = (dynamic)a[i] * (dynamic)b[i];

            return result;
        }
    }

    class Divide<T> : IOperations<T>
    {
        public TornArray<T> DoOperation(TornArray<T> a, TornArray<T> b)
        {
            int lenght = a.Length < b.Length ? a.Length : b.Length;
            var result = new TornArray<T>(a.Length);

            for (int i = 0; i < lenght; i++)
                result[i] = (dynamic)a[i] / (dynamic)b[i];

            return result;
        }
    }
}