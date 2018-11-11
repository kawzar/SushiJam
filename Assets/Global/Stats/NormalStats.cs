namespace Global.Stats
{
    public class NormalStats : StatsResolver
    {
        public override int Increment()
        {
            return 50;
        }

        public override int Decrement()
        {
            return 20;
        }
    }
}