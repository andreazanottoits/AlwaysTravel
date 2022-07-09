using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlwaysTravel.DTO
{
    public class StageData
    {
        public Stage Stage { get; set; }
        public IEnumerable<Package> Packages { get; set; }
    }
}
