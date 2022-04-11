using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.DataAcess
{
    public class Custom
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<int> Ingredients { get; set; }

        public List<int> Removed { get; set; }

        public List<int> Added { get; set; }


    }
}
