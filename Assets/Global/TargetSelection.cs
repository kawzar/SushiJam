using Global.Stats;
using UnityEngine.UI;

namespace Global
{
    public class TargetSelection
    {
        private Fish _correctTarget;
        private Fish _currentTarget;

        private static TargetSelection _instance;
        public static TargetSelection Instance => _instance = _instance ?? new TargetSelection();

        public void HitTarget()
        {
            if (_currentTarget == _correctTarget)
            {
                GameStats.Instance.Increment();
            }
        }

        public void SetTarget(Fish target)
        {
            _currentTarget = target;
        }

        public void SetCorrect(Fish fish)
        {
            _correctTarget = fish;
        }
        
        
        
        
    }
}