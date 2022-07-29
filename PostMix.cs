using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef
{

    public class PostMix : IPostMix
    {
        public PostMix(int slots)
        {
            Slots = slots;
        }

        public int Slots { get; private set; }
        public async Task<ICola> GetCola()
        {
            await Task.Delay(3000);
            return new Cola(2, 3);
        }
    }

    public interface IPostMix
    {
        Task<ICola> GetCola();
    }

    public class Cola : ICola
    {
        public Cola(int buyPrice, int sellPrice)
        {
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
        }

        public int BuyPrice { get; private set; }

        public int SellPrice { get; private set; }
    }

    public interface ICola : IBuyable
    {
    }

    public interface IBuyable
    {
        int BuyPrice { get; }
        int SellPrice { get; }
    }
}
