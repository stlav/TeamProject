using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    class Orders
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public int PerformerId { get; set; }
        public int CustomerId { get; set; }
        public virtual Orders Orders();
    }
}
