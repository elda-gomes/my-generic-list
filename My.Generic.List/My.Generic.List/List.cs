using System;

namespace My.Generic.List
{
    public class List<T>
    {
        private T[] _listItems;
        private int _index;

        public int Length => _index;

        public List()
        {
            this._listItems = new T[5];
            this._index = 0;
        }

        public void AddRange(params T[] items)
        {
            foreach (T item in items)
            {
                Add(item);
            }
        }

        public void Add(T item)
        {
            CheckArraySize();

            this._listItems[this._index] = item;
            this._index++;
        }

        private void CheckArraySize()
        {
            if (this._index >= this._listItems.Length)
            {
                T[] transitoryArray = new T[this._index * 2];
                Array.Copy(sourceArray: this._listItems, destinationArray: transitoryArray, length: this._index);
                this._listItems = transitoryArray;
            }
        }

        public void Remove(T item)
        {
            var removingIndex = IndexOf(item);

            if (removingIndex == -1)
            {
                return;
            }

            for (int i = removingIndex; i < this._index-1; i++)
            {
                this._listItems[i] = this._listItems[i + 1];
            }

            this._index--;
        }

        public int IndexOf(T item)
        {
            var index = -1;

            for (int i = 0; i < this._index; i++)
            {
                var listItem = this._listItems[i];
                if (listItem.Equals(item))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public T this[int index] => GetItem(index);

        private T GetItem(int index)
        {
            if (index < this._index)
            {
                return this._listItems[index];
            }

            throw new IndexOutOfRangeException();
        }

        public T[] ToArray()
        {
            T[] array = new T[this._index];

            Array.Copy(sourceArray: this._listItems, destinationArray: array, length: this._index);

            return array;
        }
    }
}
