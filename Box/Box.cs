using System;
namespace Box
{
	public class Box<T>
	{
		private List<T> items;
		

		public Box()
		{
			items = new List<T>();
		}
	
		public void Add(T item)
		{
			items.Add(item);
		}

		public T Remove()
		{
			T firstItem = items[Count -1];
			items.RemoveAt(items.Count-1);
			return firstItem;
		}

        public int Count
        {
            get { return items.Count; }
        }

    }
}

