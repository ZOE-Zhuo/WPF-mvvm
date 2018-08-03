using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation.Model
{
    public class Location
    {
        public string Name { get; set; }
        public List<Location> childern { get; set; }
    }
}