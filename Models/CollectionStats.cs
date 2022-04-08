using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloorTracker.Models
{
    public class CollectionStats
    {
        public class RootObject
        {
            public Stats stats { get; set; }
        }

        public class Stats
        {
            public float one_day_volume { get; set; }
            public float one_day_change { get; set; }
            public float one_day_sales { get; set; }
            public float one_day_average_price { get; set; }
            public float seven_day_volume { get; set; }
            public float seven_day_change { get; set; }
            public float seven_day_sales { get; set; }
            public float seven_day_average_price { get; set; }
            public float thirty_day_volume { get; set; }
            public float thirty_day_change { get; set; }
            public float thirty_day_sales { get; set; }
            public float thirty_day_average_price { get; set; }
            public float total_volume { get; set; }
            public float total_sales { get; set; }
            public float total_supply { get; set; }
            public float count { get; set; }
            public int num_owners { get; set; }
            public float average_price { get; set; }
            public int num_reports { get; set; }
            public float market_cap { get; set; }
            public float floor_price { get; set; }
        }
    }
}
