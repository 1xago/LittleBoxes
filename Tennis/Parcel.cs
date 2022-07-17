

namespace LittleBoxes
{
    public class Parcel
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public int weight { get; set; }

        public int cost { get; set; }
        public bool speedyChipping { get; set; } = false;

         

        public Parcel(int x, int y, int z,int weight,bool speedyChipping)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.weight = weight;
            this.speedyChipping = speedyChipping;
        }
    }
}