namespace FloorTracker.OpenSea.Models
{
    public class CollectionStats
    {
        public class RootObject
        {
            public Stats Stats { get; set; }
        }

        public class Stats
        {
            public float One_day_volume { get; set; }
            public float One_day_change { get; set; }
            public float One_day_sales { get; set; }
            public float One_day_average_price { get; set; }
            public float Seven_day_volume { get; set; }
            public float Seven_day_change { get; set; }
            public float Seven_day_sales { get; set; }
            public float Seven_day_average_price { get; set; }
            public float Thirty_day_volume { get; set; }
            public float Thirty_day_change { get; set; }
            public float Thirty_day_sales { get; set; }
            public float Thirty_day_average_price { get; set; }
            public float Total_volume { get; set; }
            public float Total_sales { get; set; }
            public float Total_supply { get; set; }
            public float Count { get; set; }
            public int Num_owners { get; set; }
            public float Average_price { get; set; }
            public int Num_reports { get; set; }
            public float Market_cap { get; set; }
            public float Floor_price { get; set; }
        }
    }
}
