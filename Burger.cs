using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef
{
    public class Burger
    {
        private IBun _bun;

        public IBun Bun
        {
            get { return _bun; }
            set
            {
                if (_bun != null)
                {
                    throw new InvalidOperationException("Can't change bun");
                }
                _bun = value;
            }
        }

        private IBurgerMeat _meat;

        public IBurgerMeat Meat
        {
            get { return _meat; }
            set { _meat = value; }
        }


    }

    public interface IBurgerMeat { }

    public class Beef : IGrillable, IBurgerMeat
    {
        public bool IsGrilled { get; private set; }
    }

    public interface IBun { }

    public class BasicBun : IBun { }
}
