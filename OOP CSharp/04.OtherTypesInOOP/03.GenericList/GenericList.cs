using System;
using System.Text;

namespace GenericList
{
    [Version(2, 32)]
    public class GenericList<T> where T : IComparable<T>
    {
        private const int defaultValue = 16;
        private T[] elements;
        private int count = 0;
        private int customSize = 0;

        public GenericList()
        {
            this.elements = new T[defaultValue];
            this.customSize = defaultValue;
        }

        public GenericList(int customSize)
            : this()
        {
            this.customSize = customSize;
            this.elements = new T[customSize];
        }

        public void AddElement(T element)
        {
            if (count + 1 == customSize) AutoGrow();
            elements[count] = element;
            count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.count)
                throw new ArgumentOutOfRangeException("The given index is out of the list's length!");
            else
            {
                T[] dummyArray = new T[customSize - 1];
                int i = 0;
                bool toEnter = false;
                foreach (T element in this.elements)
                {
                    if (i != index || toEnter == true)
                    {
                        dummyArray[i] = element;
                        i++;
                    }
                    else toEnter = true;
                }
                this.elements = dummyArray;
            }
            count--;
        }

        public int FindElement(T value)
        {
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(T value, int position)
        {
            if (count + 1 == customSize)
                AutoGrow();

            T[] dummyArray = new T[this.customSize + 1];

            for (int i = this.count; i > position; i--)
                this.elements[i] = this.elements[i - 1];

            this.count++;
            this.elements[position] = value;
        }

        public bool Contains(T value)
        {
            if (this.FindElement(value) != -1)
                return true;
            return false;
        }

        public T this[int i]
        {
            get { return this.elements[i]; }
            set { this.elements[i] = value; }
        }

        public T Min()
        {
            T[] dummyArray = new T[this.count];

            for (int i = 0; i < count; i++)
                dummyArray[i] = this.elements[i];

            Array.Sort(dummyArray);
            return dummyArray[0];
        }

        public T Max()
        {
            T[] dummyArray = new T[this.count];

            for (int i = 0; i < count; i++)
                dummyArray[i] = this.elements[i];

            Array.Sort(dummyArray);
            return dummyArray[count - 1];
        }

        public void Clear()
        {
            this.elements = new T[customSize];
        }

        private void AutoGrow()
        {
            T[] dummyArray = new T[this.customSize * 2];

            for (int i = 0; i < this.customSize; i++)
            {
                dummyArray[i] = this.elements[i];
            }

            this.customSize *= 2;
            this.elements = dummyArray;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T element in this.elements)
            {
                sb.Append(String.Format("{0} ", element));
            }

            return sb.ToString();
        }
    }
}
