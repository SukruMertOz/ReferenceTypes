using System;
using System.Collections.Generic;
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> citys = new List<string>();
            citys.Add("Newyork");
            citys.Add("Newyork");
            citys.Add("Newyork");
            citys.Add("Newyork");
            citys.Add("Newyork");
            citys.Add("Newyork");
            citys.Add("Newyork");

            Console.WriteLine(citys.Count);

            MyList <string> citys2 = new MyList<string>();
            
            citys2.Add("Ankara");
            citys2.Add("Ankara");
            citys2.Add("Ankara");
            citys2.Add("Ankara");
            citys2.Add("Ankara");
            citys2.Add("Ankara");
            citys2.Add("Ankara");
            citys2.Add("Ankara");
            citys2.Add("Ankara");
            citys2.Add("Ankara");
            citys2.Add("Ankara");
            Console.WriteLine(citys2.Count);
        }
    }
    class MyList<T> //Generic Class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
           
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i <_tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }

        }
    }
   

}
