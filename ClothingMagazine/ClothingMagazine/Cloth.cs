namespace ClothesMagazine
{
    public class Cloth
    {
        private string color;
        private int size;
        private string type;

        public Cloth()
        {

        }

        public Cloth(string color, int size, string type) : this()
        {
            Color = color;
            Size = size;
            Type = type;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public override string ToString()
        {
            return $"Product: {Type} with size {Size}, color {Color}";
        }
    }
}
