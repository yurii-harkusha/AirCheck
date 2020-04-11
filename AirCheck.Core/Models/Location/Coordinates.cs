using System;
using System.Collections.Generic;
using System.Text;

namespace AirCheck.Core.Models.Location
{
    public class Coordinates
    {
        public Coordinates(string latitude, string longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
