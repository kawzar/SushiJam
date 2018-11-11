using UnityEngine;

namespace Global.Stats
{
    public class GameStats
    {
        private static GameStats _instance;
        public static GameStats Instance => _instance = _instance ?? new GameStats();
        protected int _score = 0;
        
        private StatsResolver _resolver;
        
        private GameStats()
        {
            _resolver = new NormalStats();
        }

        public void Increment()
        {
            Debug.Log("Changed score beefore " + _score);
            _score = _score + _resolver.Increment();
            Debug.Log("Changed score " + _score);
        }

        public void Decrement()
        {
            _score = _score - _resolver.Decrement();
        }
        
        public int GetScore()
        {
            return _score;
        }

    }
}