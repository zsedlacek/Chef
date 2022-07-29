namespace Chef
{
    public class Kitchen
    {
        public Grill Grill { get; set; }
        public Fryer Fryer { get; set; }

        public IFriesContainer FriesContainer { get; set; }
        public IPostMix PostMix { get; private set; }

        public Kitchen()
        {
            this.Grill = new Grill();
            this.Fryer = new Fryer();
            this.FriesContainer = new BasicFriesContainer();
            this.PostMix = new PostMix(1);
        }

        private async Task PrepareFood(IFryable food)
        {
            await this.Fryer.Fry(food);
        }

        public Task PrepareFries()
        {
            return this.PrepareFood(this.FriesContainer.GetFries());
        }

        public IFryable? TakeFromFrier()
        {
            return this.Fryer.GetFood();
        }
    }
}