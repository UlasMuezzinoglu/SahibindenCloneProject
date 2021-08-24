using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.concrete
{
    public abstract class Advertisement
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; } // ilan sahibi kim ?
        public int CityId { get; set; } // şehir id // tablo aç unutma
        public bool Status { get; set; }
    }
}
