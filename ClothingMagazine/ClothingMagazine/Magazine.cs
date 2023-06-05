using System;
using System.Collections.Generic;

namespace ClothesMagazine
{
    public class Magazine
    {
        private string type;
        private int capacity;
        private List<Cloth> cloths;

        public Magazine()
        {
            cloths = new List<Cloth>();
        }


        public Magazine(string type, int capacity) : this()
        {
            Type = type;
            Capacity = capacity;
        }


        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }


        public void AddCloth(Cloth cloth)
        {
            if (capacity > cloths.Count)
            {
                cloths.Add(cloth);
            }

        }

        public bool RemoveCloth(string color)
        {

            foreach (var item in cloths)
            {
                if (item.Color == color)
                {
                    cloths.Remove(item);
                    return true;

                }
            }
            return false;


        }

        public Cloth GetSmallestCloth()
        {
            return cloths.MinBy(x => x.Size);
        }



        public Cloth GetCloth(string color)
        {
            return cloths.First(x => x.Color == color);
        }


        public int GetClothCount()
        {
            return cloths.Count;
        }


        public string Report()
        {

            return $"{Type} magazine contains:\n{string.Join(Environment.NewLine, cloths.OrderBy(x => x.Size))}";

        }


    }
}
