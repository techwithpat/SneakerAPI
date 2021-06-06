using System;

namespace SneakerAPI.Models
{
    public class Sneaker
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string ColorWay { get; set; }
        public DateTime ReleaseYear { get; set; }
        public string Description { get; set; }
    }
}