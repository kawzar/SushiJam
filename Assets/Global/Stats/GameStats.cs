namespace Global.Stats
{
    public class GameStats
    {
        private static GameStats _instance;
        public static GameStats Instance => _instance = _instance ?? new GameStats();
        protected int _score = 0;
        
        private StatsResolver _resolver;

        public void Increment()
        {
            _score = _score + _resolver.Increment();
        }

        public void Decrement()
        {
            _score = _score - _resolver.Decrement();
        }
        
        

    }
}