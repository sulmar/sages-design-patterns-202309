using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace FactoryMethodTemplate
{
    // Static Factory Method

    public class Coordinate
    {
		// Długość geograficzna	
		public double Longitude { get; }

		// Szerokość geograficzna
		public double Latitude { get; }

		protected Coordinate(double lng, double lat)
		{
			this.Longitude = lng;
			this.Latitude = lat;
		}

        public static Coordinate CoordinateFromWkt(string wkt)
        {
            const string pattern = @"POINT \((\d*)\s(\d*)\)";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(wkt);

            if (match.Success)
            {
                double lng = double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
                double lat = double.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);

                return new Coordinate(lng, lat);
            }
            else
            {
                throw new FormatException();
            }
        }

        public static Coordinate CoordinateFromGeoJson(string geojson)
        {
            const string pattern = @"\[(\d*), (\d*)\]";

            Regex regex = new Regex(pattern);


            Match match = regex.Match(geojson);

            if (match.Success)
            {

                double lng = double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
                double lat = double.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);

                return new Coordinate(lng, lat);
            }
            else
            {
                throw new FormatException();
            }
        }




    }
}
