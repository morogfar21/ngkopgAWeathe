using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab10.Model
{
        public class measurement
    {
        public int measurementId { get; set; }
        public DateTime dato { get; set; }
        public double temperature { get; set; }
        public double humidity { get; set; }
        public double pressure { get; set; }
    }
}
