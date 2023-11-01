using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, int rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }
        public int Rating { get; set; }

        public static List<TourismDestination> tourismDestination =new List<TourismDestination>();

        public static void DestinationSort()
        {
            var sortedList = tourismDestination.OrderByDescending(o => o.Rating);
            foreach (var o in sortedList)
            {
                Console.WriteLine("Name:" + o.Name + "\t" + "Country:" +o.Country +"\t" + "Rating:" + o.Rating);
            }
        }
    }
}
