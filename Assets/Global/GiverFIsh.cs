namespace Global
{
    public class GiverFIsh
    {
        public Fish SalmonFish { get; private set; } = new Salmon();
        public Fish CrabFish { get; private set; } = new Crab();
    }
}