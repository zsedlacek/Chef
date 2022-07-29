using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef
{
    public interface IFriesContainer
    {
        IFryable GetFries();
    }
    public class BasicFriesContainer : IFriesContainer
    {
        public IFryable GetFries()
        {
            return new Fries(2, 3);
        }
    }
}
