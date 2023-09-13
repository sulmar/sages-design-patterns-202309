namespace FlyweightPattern
{
    // Flyweight
    public class PointIcon
    {
        public PointType Type { get; set; }
        public byte[] Icon { get; set; }

        public PointIcon(PointType type, byte[] icon)
        {
            this.Type = type;
            this.Icon = icon;
        }
    }
}