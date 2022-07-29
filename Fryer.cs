namespace Chef
{
    public class Fryer
    {
        private IFryable? _food;
        private bool _busy;
        private int _temperature;
        private bool _on;
        public Fryer()
        {
            _on = true;
            _temperature = 100;
        }

        public IFryable? Food
        {
            get { return _food; }
            set
            {
                if (_food != null)
                {
                    throw new InvalidOperationException("Can't remove food");
                }
                _food = value;
            }
        }

        public async Task Fry(IFryable food)
        {
            food.Fry(_temperature);
        }

        public IFryable? GetFood()
        {
            if (this.Food == null)
            {
                Console.WriteLine("No food to take");
                return null;
                throw new InvalidOperationException("No food to take");
            }
            if (this.Food.State == FoodState.Raw)
            {
                Console.WriteLine("Food is not ready");
                return null;
                throw new InvalidOperationException("Food is not ready");
            }
            var food = this.Food;
            _food = null;
            return food;
        }

    }

    public interface IFryable
    {
        public FoodState State { get; }
        public Task<IFried> Fry(int frierTemperature);
    }

    public interface IFried
    {

    }

    public class FriedFries : IFried { }

    public enum FoodState
    {
        Raw, Done, Burnt
    }

    public class Fries : IFryable
    {
        private static CancellationTokenSource _cts;
        public int BuyPrice { get; private set; }
        public int SellPrice { get; private set; }

        public Fries(int buyPrice, int sellPrice)
        {
            this.BuyPrice = buyPrice;
            this.SellPrice = sellPrice;
            _cts = new CancellationTokenSource();
        }
        public FoodState State { get; private set; }

        public async Task<IFried> Fry(int frierTemperature)
        {
            var token = _cts.Token;
            Console.WriteLine("Frying...");
            await Task.Delay(333);
            Console.WriteLine("1/3");
            await Task.Delay(666);
            Console.WriteLine("Food fried.");
            this.State = FoodState.Done;
            await Task.Delay(1000);
            Console.WriteLine("Food burnt.");
            this.State = FoodState.Burnt;
            return new FriedFries();
        }
    }

}
