using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_dz6
{
    internal class Book
    {
        public int PublishingHouseId { get; set; }
        public string? Title { get; set; }
        public PublishingHouse? PublishingHouse { get; set; }
    }
}
