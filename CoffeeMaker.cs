using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef
{
    public class CoffeeMaker : ICoffeeMaker
    {
        public async Task<ICoffee> MakeCoffee()
        {
            throw new NotImplementedException();
        }
    }

    public interface ICoffee { }

    public interface ICoffeeMaker
    {
        Task<ICoffee> MakeCoffee();
    }
}
