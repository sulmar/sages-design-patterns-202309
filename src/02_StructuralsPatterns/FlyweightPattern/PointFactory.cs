using System.Collections.Generic;

namespace FlyweightPattern
{
    public class PointService
    {        
        private readonly IEnumerable<Point> points;

        public PointService(PointIconFactory iconFactory)
        {
            this.points = new List<Point>
            {
                new Point(1, 2, iconFactory.Create(PointType.Coffee)),
                new Point(10, 20, iconFactory.Create(PointType.Coffee)),
                new Point(15, 25,iconFactory.Create(PointType.Hotel)),
            };
        }

        public IEnumerable<Point> Create()
        {                      
            return points;
        }
    }
}
