

namespace LittleBoxes
{
    public class Parcel
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public int cost { get; set; }

        public Parcel(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}