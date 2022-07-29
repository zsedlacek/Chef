using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef
{
    public class Grill
    {
        public IGrillable? Food { get; set; }
        public async Task Cook(IGrillable food)
        {
            this.Food = food;
        }
    }
    public interface IGrillable
    {
        bool IsGrilled { get; }
    }
}
