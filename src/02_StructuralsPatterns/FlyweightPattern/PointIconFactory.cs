using System.Collections.Generic;
using System.IO;

namespace FlyweightPattern
{
    // Flyweight Factory
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> icons = new();

        public PointIcon Create(PointType pointType)
        {
            if (!icons.ContainsKey(pointType))
            {
                byte[] icon = Get(pointType);

                icons.Add(pointType, new PointIcon(pointType, icon));
            }

            return icons[pointType];

        }
       
        private static byte[] Get(PointType pointType)
        {
            string filename = $"Assets/{pointType.ToString().ToLower()}.png";
            byte[] icon = File.ReadAllBytes(filename);
            return icon;
        }
    }
}
